//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CineShowAPP.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-4NLK0BU\\SQLEXPRESS;Initial Catalog=CineSHOW_BDMIn_TablaPeli_A" +
            "uxil;Integrated Security=True")]
        public string CineSHOW_BDMIn_TablaPeli_AuxilConnectionString {
            get {
                return ((string)(this["CineSHOW_BDMIn_TablaPeli_AuxilConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=localhost;Initial Catalog=CineSHOW_BDMIn_TablaPeli_Auxil;Integrated S" +
            "ecurity=True")]
        public string CineSHOW_BDMIn_TablaPeli_AuxilConnectionStringFer {
            get {
                return ((string)(this["CineSHOW_BDMIn_TablaPeli_AuxilConnectionStringFer"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-4NLK0BU\\SQLEXPRESS;Initial Catalog=CineSHOW;Integrated Securi" +
            "ty=True")]
        public string CineSHOWConnectionStringBDTc {
            get {
                return ((string)(this["CineSHOWConnectionStringBDTc"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(localdb)\\ServerMeli;Initial Catalog=CineSHOW;Integrated Security=Tru" +
            "e")]
        public string CineSHOWConnectionStringEntradas {
            get {
                return ((string)(this["CineSHOWConnectionStringEntradas"]));
            }
        }
    }
}
