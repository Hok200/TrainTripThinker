﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrainTripThinker.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.5.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Settings.json")]
        public string SettingsJson {
            get {
                return ((string)(this["SettingsJson"]));
            }
            set {
                this["SettingsJson"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Train Trip Thinker行程表(*.tttlst)|*.tttlst|JavaScript Object Notation(*.json)|*.jso" +
            "n|すべてのファイル(*.*)|*.*")]
        public string TTTDocumentFilter {
            get {
                return ((string)(this["TTTDocumentFilter"]));
            }
            set {
                this["TTTDocumentFilter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("名称未設定")]
        public string DefaultDocumentName {
            get {
                return ((string)(this["DefaultDocumentName"]));
            }
            set {
                this["DefaultDocumentName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://github.com/nnm-t/TrainTripThinker/wiki")]
        public string WikiUrl {
            get {
                return ((string)(this["WikiUrl"]));
            }
            set {
                this["WikiUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://github.com/nnm-t/TrainTripThinker")]
        public string GitHubUrl {
            get {
                return ((string)(this["GitHubUrl"]));
            }
            set {
                this["GitHubUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://kamisawa.net/")]
        public string WebSiteUrl {
            get {
                return ((string)(this["WebSiteUrl"]));
            }
            set {
                this["WebSiteUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Resources\\OSSLicense.txt")]
        public string LicenseTextPath {
            get {
                return ((string)(this["LicenseTextPath"]));
            }
            set {
                this["LicenseTextPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Portable Network Graphics(*png)|*.png|すべてのファイル(*.*)|*.*")]
        public string PNGImageFilter {
            get {
                return ((string)(this["PNGImageFilter"]));
            }
            set {
                this["PNGImageFilter"] = value;
            }
        }
    }
}
