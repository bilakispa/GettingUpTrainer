﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GettingUpTrainer.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.5.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2.1")]
        public string AppVersion {
            get {
                return ((string)(this["AppVersion"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::GettingUpTrainer.Key HotkeyPlayerHealth {
            get {
                return ((global::GettingUpTrainer.Key)(this["HotkeyPlayerHealth"]));
            }
            set {
                this["HotkeyPlayerHealth"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::GettingUpTrainer.Key HotkeyPlayerPower {
            get {
                return ((global::GettingUpTrainer.Key)(this["HotkeyPlayerPower"]));
            }
            set {
                this["HotkeyPlayerPower"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::GettingUpTrainer.Key HotkeyPlayerRep {
            get {
                return ((global::GettingUpTrainer.Key)(this["HotkeyPlayerRep"]));
            }
            set {
                this["HotkeyPlayerRep"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::GettingUpTrainer.Key HotkeyPlayerPosition {
            get {
                return ((global::GettingUpTrainer.Key)(this["HotkeyPlayerPosition"]));
            }
            set {
                this["HotkeyPlayerPosition"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::GettingUpTrainer.Key HotkeyEnemyHealth {
            get {
                return ((global::GettingUpTrainer.Key)(this["HotkeyEnemyHealth"]));
            }
            set {
                this["HotkeyEnemyHealth"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::GettingUpTrainer.Key HotkeyEnemyPosition {
            get {
                return ((global::GettingUpTrainer.Key)(this["HotkeyEnemyPosition"]));
            }
            set {
                this["HotkeyEnemyPosition"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::GettingUpTrainer.PlayerPositionCollection PlayerPositions {
            get {
                return ((global::GettingUpTrainer.PlayerPositionCollection)(this["PlayerPositions"]));
            }
            set {
                this["PlayerPositions"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::GettingUpTrainer.Key HotkeyPedestrianPosition {
            get {
                return ((global::GettingUpTrainer.Key)(this["HotkeyPedestrianPosition"]));
            }
            set {
                this["HotkeyPedestrianPosition"] = value;
            }
        }
    }
}
