﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinForm_Controle_De_Estoque.Properties {
    
    
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
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=172.168.255.252;Initial Catalog=db_05790_1_C_2_2017;User ID=05790_1_C" +
            "_2_2017;Password=Foreveralone123")]
        public string db_05790_1_C_2_2017ConnectionString {
            get {
                return ((string)(this["db_05790_1_C_2_2017ConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-94KVFQM;Initial Catalog=BDVendas;Persist Security Info=True;U" +
            "ser ID=Thiago;Password=Foreveralone123")]
        public string BDVendasConnectionString {
            get {
                return ((string)(this["BDVendasConnectionString"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int NivelUsuarioLogado {
            get {
                return ((int)(this["NivelUsuarioLogado"]));
            }
            set {
                this["NivelUsuarioLogado"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string NomeUsuarioLogado {
            get {
                return ((string)(this["NomeUsuarioLogado"]));
            }
            set {
                this["NomeUsuarioLogado"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=Thiago-PC\\SERVER;Initial Catalog=\"Thiago\'s DataBase\";Persist Security" +
            " Info=True;User ID=sa;Password=Foreveralone123")]
        public string Thiago_s_DataBaseConnectionString {
            get {
                return ((string)(this["Thiago_s_DataBaseConnectionString"]));
            }
        }
    }
}