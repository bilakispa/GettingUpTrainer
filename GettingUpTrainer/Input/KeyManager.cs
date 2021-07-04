using System;
using System.Threading;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;

namespace GettingUpTrainer
{
    public class KeyManager
    {
        // Keys holder
        private Dictionary<string, Key> keys;

        // Update thread
        private Thread thread;
        private int interval = 20; // ms

        // Keys events
        public delegate void KeyHandler(string ControlName, int Id, string Name);
        public event KeyHandler KeyUpEvent;
        public event KeyHandler KeyDownEvent;

        // Key Up
        protected void OnKeyUp(string ControlName, int Id, string Name)
        {
            if (KeyUpEvent != null) {
                KeyUpEvent(ControlName, Id, Name);
            }
        }

        // Key Down
        protected void OnKeyDown(string ControlName, int Id, string Name)
        {
            if (KeyDownEvent != null) {
                KeyDownEvent(ControlName, Id, Name);
            }
        }

        // Init
        public KeyManager()
        {
            keys = new Dictionary<string, Key>();
            thread = new Thread(new ParameterizedThreadStart(Update));
            thread.Start();
        }

        // Add key
        public void AddKey(string controlName, int keyId, string keyName)
        {
            if (!keys.ContainsKey(controlName)) {
                keys.Add(controlName, new Key(keyId, keyName));
            }
        }

        public void AddKey(string controlName, Key key)
        {
            if ((key != null) && !keys.ContainsKey(controlName)) {
                keys.Add(controlName, key);
            }
        }

        // Remove Key
        public void RemoveKey(string controlName)
        {
            if (keys.ContainsKey(controlName)) {
                keys.Remove(controlName);
            }
        }

        // Get Key
        public Key GetKey(string controlName)
        {
            Key value;
            if (keys.TryGetValue(controlName, out value)) {
                return value;
            }
            return null;
        }

        // Update Thread
        private void Update(object sender)
        {
            while (true) {
                if (keys.Count > 0) {
                    List<Key> keysData = new List<Key>(keys.Values);
                    if (keysData != null && keysData.Count > 0) {
                        foreach (Key key in keysData) {
                            if (Convert.ToBoolean(Hook.GetKeyState(key.Id) & (int)Hook.KEYS.KEY_PRESSED)) {
                                if (!key.IsKeyDown) {
                                    key.IsKeyDown = true;
                                    OnKeyDown(keys.FirstOrDefault(x => x.Value == key).Key, key.Id, key.Name);
                                }
                            } else {
                                if (key.IsKeyDown) {
                                    key.IsKeyDown = false;
                                    OnKeyUp(keys.FirstOrDefault(x => x.Value == key).Key, key.Id, key.Name);
                                }
                            }
                        }
                    }
                }
                Thread.Sleep(interval);
            }
        }
    }
}
