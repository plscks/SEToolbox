﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SEToolboxUpdate.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SEToolboxUpdate.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to {0} is designed to be used interally by SEToolbox during the Installation and Update process.
        ///
        ///{0} [/I] [/U] [/B]
        ///  /I - Install
        ///  /U - Uninstall
        ///  /B - Update Binaries.
        /// </summary>
        internal static string AppParameterHelpMessage {
            get {
                return ResourceManager.GetString("AppParameterHelpMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SEToolboxUpdate Options.
        /// </summary>
        internal static string AppParameterHelpTitle {
            get {
                return ResourceManager.GetString("AppParameterHelpTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to By cancelling the UAC request you are running with old base files, and risk corrupting any Space Engineers world when you save.
        ///
        ///If you accept this risk, then press Yes to continue..
        /// </summary>
        internal static string CancelUACMessage {
            get {
                return ResourceManager.GetString("CancelUACMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update cancelled.
        /// </summary>
        internal static string CancelUACTitle {
            get {
                return ResourceManager.GetString("CancelUACTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred whilst attempting to updating the base files.
        ///You may attempt to run SEToolbox but you risk corrupting any Space Engineers world when you save.
        ///It is recommended you close the application now, then download the latest version of SEToolbox.
        ///
        ///If you want to ignore the error and attempt to run SEToolbox as it is, then press Yes to continue..
        /// </summary>
        internal static string UpdateErrorMessage {
            get {
                return ResourceManager.GetString("UpdateErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update error.
        /// </summary>
        internal static string UpdateErrorTitle {
            get {
                return ResourceManager.GetString("UpdateErrorTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The base version of Space Engineers has changed.
        ///SEToolbox needs to update the base files from Space Engineers before starting.
        ///
        ///Please press OK to continue..
        /// </summary>
        internal static string UpdateRequiredMessage {
            get {
                return ResourceManager.GetString("UpdateRequiredMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Space Engineers update detected.
        /// </summary>
        internal static string UpdateRequiredTitle {
            get {
                return ResourceManager.GetString("UpdateRequiredTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The base version of Space Engineers has changed.
        ///SEToolbox needs to update the base files from Space Engineers before starting.
        ///
        ///Please press Yes at the UAC prompt to continue..
        /// </summary>
        internal static string UpdateRequiredUACMessage {
            get {
                return ResourceManager.GetString("UpdateRequiredUACMessage", resourceCulture);
            }
        }
    }
}
