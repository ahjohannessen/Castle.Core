﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Castle.log4netIntegration {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class log4netConfig {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal log4netConfig() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Castle.log4netIntegration.log4netConfig", typeof(log4netConfig).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;configuration&gt;
        ///
        ///	&lt;log4net&gt;
        ///
        ///		&lt;appender name=&quot;Console&quot; type=&quot;log4net.Appender.ConsoleAppender&quot;&gt;
        ///			&lt;layout type=&quot;log4net.Layout.PatternLayout&quot;&gt;
        ///				&lt;conversionPattern value=&quot;%date [%thread] %-5level %logger [%property{NDC}] - %message%newline&quot; /&gt;
        ///			&lt;/layout&gt;
        ///		&lt;/appender&gt;
        ///
        ///
        ///		&lt;!-- Setup the root category, add the appenders and set the default level --&gt;
        ///		&lt;root&gt;
        ///			&lt;!-- ALL, DEBUG, INFO, WARN, ERROR, FATAL, OFF--&gt;
        ///			&lt;priority value=&quot;ALL&quot; /&gt;
        ///			&lt;appen [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Config {
            get {
                return ResourceManager.GetString("Config", resourceCulture);
            }
        }
    }
}
