﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using AMT_RVMATGenerator.stuff;

namespace AMT_RVMATGenerator.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.5.0.0")]
    internal sealed partial class Data : global::System.Configuration.ApplicationSettingsBase {
        
        private static Data defaultInstance = ((Data)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Data())));
        
        public static Data Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public RVMATSettings Settings {
            get {
                return ((RVMATSettings)(this["Settings"]));
            }
            set {
                this["Settings"] = value;
            }
        }
    }
}
