using SharpDX.Direct2D1;
using SharpDX.DirectWrite;
using SharpDX.Mathematics.Interop;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Factory = SharpDX.Direct2D1.Factory;
using FontFactory = SharpDX.DirectWrite.Factory;

namespace GettingUpTrainer
{
    public partial class Overlay : Form
    {
        static string MODULE_RHAPSODY_NAME = "G_rhapsody.sgl";

        // Process
        private Process _process = null;
        private IntPtr _handle;
        private IntPtr _rhapsodyModule = (IntPtr)0;
        private Thread _updateStream = null, _windowStream = null;

        // Keys Control
        private KeyManager _keyManager;

        // Settings
        private bool _showMenu = false;
        private bool _drawPlayerStats = false;
        private bool _drawEnemyStats = false;

        // SharpDX
        private WindowRenderTarget _device;
        private HwndRenderTargetProperties _renderProperties;
        private SolidColorBrush _solidColorBrush;
        private Factory _factory;
        private bool _isResized = false;
        private bool _isMinimized = false;

        // SharpDX Font
        private TextFormat _font, _fontBig, _fontSmall;
        private FontFactory _fontFactory;
        private const string _fontFamilyCalibri = "Calibri";
        private const string _fontFamilyCourier = "Courier New";
        private const float _fontSize = 14.0f;
        private const float _fontSizeBig = 16.0f;
        private const float _fontSizeSmall = 12.0f;

        // RawColor4 Colors
        private RawColor4 _colorTransparent = new RawColor4(Color.Transparent.R, Color.Transparent.G, Color.Transparent.B, Color.Transparent.A);
        private RawColor4 _colorRed = new RawColor4(Color.Red.R, Color.Red.G, Color.Red.B, Color.Red.A);
        private RawColor4 _colorGreen = new RawColor4(Color.Green.R, Color.Green.G, Color.Green.B, Color.Green.A);
        private RawColor4 _colorBlue = new RawColor4(Color.Blue.R, Color.Blue.G, Color.Blue.B, Color.Blue.A);
        private RawColor4 _colorWhite = new RawColor4(Color.White.R, Color.White.G, Color.White.B, Color.White.A);
        private RawColor4 _colorGold = new RawColor4(Color.Gold.R, Color.Gold.G, Color.Gold.B, Color.Gold.A);

        // Screen Size
        Rectangle _rect;
  
        public Overlay(Process process)
        {
            InitializeComponent();

            _process = process;
            _handle = Handle;

            Thread.Sleep(5000); //Bug fix for trying to get ProcessModuleCollection too early
            //Get Module's base address
            foreach (ProcessModule procModule in _process.Modules) {
                if (procModule.ModuleName == MODULE_RHAPSODY_NAME)
                    _rhapsodyModule = procModule.BaseAddress;
            }
            

            int initialStyle = Imports.GetWindowLong(this.Handle, -20);
            Imports.SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);

            IntPtr HWND_TOPMOST = new IntPtr(-1);
            const UInt32 SWP_NOSIZE = 0x0001;
            const UInt32 SWP_NOMOVE = 0x0002;
            const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

            Imports.SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
            OnResize(null);
        }

        // Set window style
        protected override void OnResize(EventArgs e)
        {
            int[] margins = new int[] { 0, 0, _rect.Width, _rect.Height };
            Imports.DwmExtendFrameIntoClientArea(this.Handle, ref margins);
        }

        private void DrawWindow_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.Visible = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Width = _rect.Width;
            this.Height = _rect.Height;

            // Window name
            this.Name = Process.GetCurrentProcess().ProcessName + "~Overlay";
            this.Text = Process.GetCurrentProcess().ProcessName + "~Overlay";

            // Init factory
            _factory = new Factory();
            _fontFactory = new FontFactory();

            // Render settings
            _renderProperties = new HwndRenderTargetProperties()
            {
                Hwnd = this.Handle,
                PixelSize = new SharpDX.Size2(_rect.Width, _rect.Height),
                PresentOptions = PresentOptions.None
            };

            // Init device
            _device = new WindowRenderTarget(_factory, new RenderTargetProperties(new PixelFormat(SharpDX.DXGI.Format.B8G8R8A8_UNorm, AlphaMode.Premultiplied)), _renderProperties);

            // Init brush
            _solidColorBrush = new SolidColorBrush(_device, _colorWhite);

            // Init font's
            _font = new TextFormat(_fontFactory, _fontFamilyCalibri, _fontSize);
            _fontBig = new TextFormat(_fontFactory, _fontFamilyCourier, _fontSizeBig);
            _fontSmall = new TextFormat(_fontFactory, _fontFamilyCalibri, _fontSizeSmall);

            // Open process
            Memory.OpenProcess(_process.Id);

            // Init update thread
            _updateStream = new Thread(new ParameterizedThreadStart(DirectXThread));
            _updateStream.Start();

            // Init window thread (resize / position)
            _windowStream = new Thread(new ParameterizedThreadStart(SetWindow));
            _windowStream.Start();

            // Init Key Listener
            _keyManager = new KeyManager();
            _keyManager.AddKey(Keys.F9);
            _keyManager.AddKey(Keys.F10);
            _keyManager.AddKey(Keys.F12);
            _keyManager.KeyDownEvent += new KeyManager.KeyHandler(KeyDownEvent);
        }

        // Key Down Event
        private void KeyDownEvent(int keyId, string keyName)
        {
            switch ((Keys)keyId) {
                case Keys.F9:
                    _drawPlayerStats = !_drawPlayerStats;
                    break;
                case Keys.F10:
                    _drawEnemyStats = !_drawEnemyStats;
                    break;
                case Keys.F12:
                    _showMenu = !_showMenu;
                    break;
            }
        }

        // FPS Stats
        private static int _lastTick;
        private static int _lastFrameRate;
        private static int _frameRate;

        //Check if game is running
        private bool IsGameRunning()
        {
            foreach (Process p in Process.GetProcesses()) {
                if (p.ProcessName == _process.ProcessName)
                    return true;
            }
            return false;
        }

        //Draw thread
        private void DirectXThread(object sender)
        {
            while(IsGameRunning())
            {
                // Resize
                if (_isResized) {
                    _device.Resize(new SharpDX.Size2(_rect.Width, _rect.Height));
                    _isResized = false;
                }

                // Begin Draw
                _device.BeginDraw();
                _device.Clear(_colorTransparent);

                // Check Window State
                if (!_isMinimized) { //Change that, MEGU will be never minimized
                    //Draw info text
                    DrawText("Getting Up Trainer [v1.0]", _rect.Left, _rect.Top, _colorRed, _fontBig);

                    // Draw Menu
                    if(_showMenu) {
                        int currentY = _rect.Top + (int)(2*_fontBig.FontSize);
                        DrawText(" [F9] Show Player Stats = " + _drawPlayerStats, _rect.Left, currentY, _colorGold, _fontBig);
                        currentY += (int)_fontBig.FontSize;
                        DrawText("[F10] Show Enemy Stats = " + _drawEnemyStats, _rect.Left, currentY, _colorGreen, _fontBig);
                        currentY += (int)_fontBig.FontSize;
                        DrawText("[F12] Close the menu", _rect.Left, currentY, _colorRed, _fontBig);
                    }

                    //Read and Draw game memory addresses
                    ReadGameMemory();   
                }

                // End Draw
                _device.EndDraw();
                CalculateFrameRate();
            }

            Memory.CloseProcess();
            Environment.Exit(0);
        }

        private void ReadGameMemory()
        {
            Int32 spawnedActors = Memory.Read<Int32>(_rhapsodyModule.ToInt32() + GameOffsets.ACTORS_SPAWNED);

            if (spawnedActors > 0) {
                Int32 ptrActors = Memory.Read<Int32>(_rhapsodyModule.ToInt32() + GameOffsets.ACTOR_BASE);
                if (!Memory.IsValid(ptrActors))
                    return;

                //add those to a struct
                Int32[] ptrActorBase = new Int32[spawnedActors];
                Int32[] ptrActorStats = new Int32[spawnedActors];
                float[] actorCurrentHealth = new float[spawnedActors];
                float[] actorMaxHealth = new float[spawnedActors];
                float[] actorPositionX = new float[spawnedActors];
                float[] actorPositionY = new float[spawnedActors];
                float[] actorPositionZ = new float[spawnedActors];
                for (int i = 0; i < spawnedActors - 1; i++) {
                    ptrActorBase[i] = Memory.Read<Int32>(ptrActors + i * 4); //0x0 = PlayerBase, 0x4 = EnemyBase 1, etc
                    if (!Memory.IsValid(ptrActorBase[i]))
                        return;

                    ptrActorStats[i] = Memory.Read<Int32>(ptrActorBase[i] + GameOffsets.ACTOR_STATS);
                    if (!Memory.IsValid(ptrActorStats[i]))
                        return;

                    actorCurrentHealth[i] = Memory.Read<float>(ptrActorStats[i] + GameOffsets.ACTOR_CURRENT_HEALTH);
                    actorMaxHealth[i] = Memory.Read<float>(ptrActorStats[i] + GameOffsets.ACTOR_MAX_HEALTH);
                    actorPositionX[i] = Memory.Read<float>(ptrActorStats[i] + GameOffsets.ACTOR_POSITION_X);
                    actorPositionY[i] = Memory.Read<float>(ptrActorStats[i] + GameOffsets.ACTOR_POSITION_Y);
                    actorPositionZ[i] = Memory.Read<float>(ptrActorStats[i] + GameOffsets.ACTOR_POSITION_Z);
                }

                //Show Values
                int currentY = (int)(_rect.Bottom - _font.FontSize); //Draw from bottom to top
                if (_drawEnemyStats) {
                    for (int i = spawnedActors - 1; i >= 1; i--) {
                        _solidColorBrush.Color = _colorWhite;
                        DrawText("[Position] X: " + actorPositionX[i].ToString("F") + " Y: " + actorPositionY[i].ToString("F") + " Z: " + actorPositionZ[i].ToString("F"), _rect.Left, currentY);
                        currentY -= (int)_font.FontSize;
                        DrawText("[Health] Current:" + actorCurrentHealth[i].ToString("F") + " Max: " + actorMaxHealth[i].ToString("F"), _rect.Left, currentY);
                        currentY -= (int)_font.FontSize;
                        DrawText("(Enemy " + i + ")", _rect.Left, currentY, _colorGreen);
                        currentY -= (int)(2* _font.FontSize);
                    }
                }

                if (_drawPlayerStats) {
                    _solidColorBrush.Color = _colorWhite;
                    DrawText("[Position] X: " + actorPositionX[0].ToString("F") + " Y: " + actorPositionY[0].ToString("F") + " Z: " + actorPositionZ[0].ToString("F"), _rect.Left, currentY);
                    currentY -= (int)_font.FontSize;
                    DrawText("[Health] Current:" + actorCurrentHealth[0].ToString("F") + " Max: " + actorMaxHealth[0].ToString("F"), _rect.Left, currentY);
                    currentY -= (int)_font.FontSize;
                    DrawText("(Player)", _rect.Left, currentY, _colorGold);
                }
            }
        }

        private void SetWindow(object sender)
        {
            while (true) {
                IntPtr targetWnd = IntPtr.Zero;
                targetWnd = Imports.FindWindow(null, _process.MainWindowTitle);
                if (targetWnd != IntPtr.Zero) {
                    RECT targetSize = new RECT();
                    Imports.GetWindowRect(targetWnd, out targetSize);

                    // Game is Minimized
                    if (targetSize.Left < 0 && targetSize.Top < 0 && targetSize.Right < 0 && targetSize.Bottom < 0) {
                        _isMinimized = true;
                        continue;
                    }

                    // Reset
                    _isMinimized = false;

                    RECT borderSize = new RECT();
                    Imports.GetClientRect(targetWnd, out borderSize);

                    int dwStyle = Imports.GetWindowLong(targetWnd, Imports.GWL_STYLE);

                    int windowheight;
                    int windowwidth;
                    int borderheight;
                    int borderwidth;

                    if (_rect.Width != (targetSize.Bottom - targetSize.Top)
                        && _rect.Width != (borderSize.Right - borderSize.Left))
                        _isResized = true;

                    _rect.Width = targetSize.Right - targetSize.Left;
                    _rect.Height = targetSize.Bottom - targetSize.Top;

                    if ((dwStyle & Imports.WS_BORDER) != 0) {
                        windowheight = targetSize.Bottom - targetSize.Top;
                        windowwidth = targetSize.Right - targetSize.Left;

                        _rect.Height = borderSize.Bottom - borderSize.Top;
                        _rect.Width = borderSize.Right - borderSize.Left;

                        borderheight = (windowheight - borderSize.Bottom);
                        borderwidth = (windowwidth - borderSize.Right) / 2; //only want one side
                        borderheight -= borderwidth; //remove bottom

                        targetSize.Left += borderwidth;
                        targetSize.Top += borderheight;

                        _rect.X = targetSize.Left;
                        _rect.Y = targetSize.Top;
                    }
                    Imports.MoveWindow(_handle, targetSize.Left, targetSize.Top, _rect.Width, _rect.Height, true);
                }
                Thread.Sleep(300);
            }
        }

        public int CalculateFrameRate()
        {
            int tickCount = Environment.TickCount;
            if (tickCount - _lastTick >= 1000) {
                _lastFrameRate = _frameRate;
                _frameRate = 0;
                _lastTick = tickCount;
            }
            _frameRate++;
            return _lastFrameRate;
        }

        // Close window event
        private void DrawWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _updateStream.Abort();
            _windowStream.Abort();
            Memory.CloseProcess();

            // Close main process
            Environment.Exit(0);
        }

        // Draw Functions
        #region Draw Functions
        private void DrawText(string text, int X, int Y)
        {
            _device.DrawText(text, _font, new RawRectangleF(X, Y, _font.FontSize * text.Length, Math.Abs(Y - _font.FontSize)), _solidColorBrush);
        }

        private void DrawText(string text, int X, int Y, RawColor4 color4)
        {
            _solidColorBrush.Color = color4;
            _device.DrawText(text, _font, new RawRectangleF(X, Y, _font.FontSize * text.Length, Math.Abs(Y - _font.FontSize)), _solidColorBrush);
        }

        private void DrawText(string text, int X, int Y, RawColor4 color4, TextFormat textFormat)
        {
            _solidColorBrush.Color = color4;
            _device.DrawText(text, textFormat, new RawRectangleF(X, Y, textFormat.FontSize * text.Length, Math.Abs(Y - textFormat.FontSize)), _solidColorBrush);
        }
        #endregion
    }
}
