using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GettingUpTrainer.Forms
{
	public partial class OverlayForm : Form
	{
		private IntPtr _targetHWnd;
		private IntPtr _hWinEventMoveHook, _hWinEventForegroundHook;
		private RECT _rect = new RECT();
		protected Hook.WinEventDelegate _winEventMoveDelegate, _winEventForegroundDelegate;
		private static GCHandle _GCSafetyMoveHandle, _GCSafetyForegroundHandle;

		private Graphics _graphics;
		private Font _drawFont = new Font("Calibri", 16);
		SolidBrush _drawBrush = new SolidBrush(Color.Gold);

		public OverlayForm()
		{
			InitializeComponent();

			_winEventMoveDelegate = new Hook.WinEventDelegate(WinEventMoveCallback);
			_GCSafetyMoveHandle = GCHandle.Alloc(_winEventMoveDelegate);

			_winEventForegroundDelegate = new Hook.WinEventDelegate(WinEventForegroundCallback);
			_GCSafetyForegroundHandle = GCHandle.Alloc(_winEventForegroundDelegate);
		}

		private void OverlayForm_Load(object sender, EventArgs e)
		{
			// Make transparent form, in front, and without any border
			this.BackColor = Color.Black;
			this.TransparencyKey = Color.Black;
			this.TopMost = true;
			this.FormBorderStyle = FormBorderStyle.None;

			// Make Form to be passing mouse clicks to other windows
			int initialStyle = Hook.GetWindowLong(this.Handle, -20);
			Hook.SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);
		}

		private void OverlayForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_GCSafetyMoveHandle.IsAllocated) {
				_GCSafetyMoveHandle.Free();
			}

			if (_GCSafetyForegroundHandle.IsAllocated) {
				_GCSafetyForegroundHandle.Free();
			}

			Hook.WinEventUnhook(_hWinEventMoveHook);
			Hook.WinEventUnhook(_hWinEventForegroundHook);
		}

		public void BindOverlayToGameProcess(Process targetProcess)
		{
			_targetHWnd = targetProcess.MainWindowHandle;
			uint targetThreadId = Hook.GetWindowThread(_targetHWnd);

			if (_targetHWnd != IntPtr.Zero) {
				_hWinEventMoveHook = Hook.WinEventHookOne(Hook.SWEH_Events.EVENT_OBJECT_LOCATIONCHANGE, _winEventMoveDelegate, (uint)targetProcess.Id, targetThreadId);
				_hWinEventForegroundHook = Hook.WinEventHookOne(Hook.SWEH_Events.EVENT_SYSTEM_FOREGROUND, _winEventForegroundDelegate, 0, 0);

				_rect = Hook.GetWindowRect(_targetHWnd);
				IntPtr foregroundHWnd = Hook.GetForegroundWindow();

				// Set initial size, location, and visibility
				this.Size = new Size(_rect.Right - _rect.Left, _rect.Bottom - _rect.Top);
				this.Location = new Point(_rect.Left, _rect.Top);
				this.Visible = _targetHWnd == foregroundHWnd;
			}
		}

		// Event callback to detect when the target window has moved
		protected void WinEventMoveCallback(IntPtr hWinEventHook, Hook.SWEH_Events eventType, IntPtr hWnd, Hook.SWEH_ObjectId idObject, long idChild, uint dwEventThread, uint dwmsEventTime)
		{
			if (hWnd == _targetHWnd && eventType == Hook.SWEH_Events.EVENT_OBJECT_LOCATIONCHANGE && idObject == (Hook.SWEH_ObjectId)Hook.SWEH_CHILDID_SELF) {
				_rect = Hook.GetWindowRect(_targetHWnd);
				this.Size = new Size(_rect.Right - _rect.Left, _rect.Bottom - _rect.Top);
				this.Location = new Point(_rect.Left, _rect.Top);
			}
		}

		// Event callback to detect when any window has been been the new foreground
		protected void WinEventForegroundCallback(IntPtr hWinEventHook, Hook.SWEH_Events eventType, IntPtr hWnd, Hook.SWEH_ObjectId idObject, long idChild, uint dwEventThread, uint dwmsEventTime)
		{
			if (hWnd == _targetHWnd && eventType == Hook.SWEH_Events.EVENT_SYSTEM_FOREGROUND) {
				this.Visible = true;
			} else {
				this.Visible = false;
			}
		}

		private void OverlayForm_Paint(object sender, PaintEventArgs e)
		{
			_graphics = e.Graphics;
			_graphics.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;

			// Basic string draw
			String appString = String.Format("{0} [v{1}]", Properties.Resources.GettingUpTrainer, Properties.Settings.Default.AppVersion);
			int widthOffset = 8;
			int heightOffset = 31;

			_graphics.DrawString(appString, _drawFont, _drawBrush, widthOffset, heightOffset);

			//String healthString = "Health;
			//_graphics.DrawString(healthString, _drawFont, _drawBrush, 125 + widthOffset, 78 + heightOffset);
		}
	}
}
