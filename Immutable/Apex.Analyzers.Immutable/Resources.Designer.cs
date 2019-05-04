﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apex.Analyzers.Immutable {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Apex.Analyzers.Immutable.Resources", typeof(Resources).GetTypeInfo().Assembly);
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
        ///   Looks up a localized string similar to Fields in an immutable type must be readonly.
        /// </summary>
        internal static string IMM001Description {
            get {
                return ResourceManager.GetString("IMM001Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Field &apos;{0}&apos; is not declared as readonly.
        /// </summary>
        internal static string IMM001MessageFormat {
            get {
                return ResourceManager.GetString("IMM001MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fields in an immutable type must be readonly.
        /// </summary>
        internal static string IMM001Title {
            get {
                return ResourceManager.GetString("IMM001Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Auto properties in an immutable type must not define a set method.
        /// </summary>
        internal static string IMM002Description {
            get {
                return ResourceManager.GetString("IMM002Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property &apos;{0}&apos; defines a set method.
        /// </summary>
        internal static string IMM002MessageFormat {
            get {
                return ResourceManager.GetString("IMM002MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Auto properties in an immutable type must not define a set method.
        /// </summary>
        internal static string IMM002Title {
            get {
                return ResourceManager.GetString("IMM002Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Types of fields in an immutable type must be immutable.
        /// </summary>
        internal static string IMM003Description {
            get {
                return ResourceManager.GetString("IMM003Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type of field &apos;{0}&apos; is not immutable.
        /// </summary>
        internal static string IMM003MessageFormat {
            get {
                return ResourceManager.GetString("IMM003MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Types of fields in an immutable type must be immutable.
        /// </summary>
        internal static string IMM003Title {
            get {
                return ResourceManager.GetString("IMM003Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Types of auto properties in an immutable type must be immutable.
        /// </summary>
        internal static string IMM004Description {
            get {
                return ResourceManager.GetString("IMM004Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type of auto property &apos;{0}&apos; is not immutable.
        /// </summary>
        internal static string IMM004MessageFormat {
            get {
                return ResourceManager.GetString("IMM004MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Types of auto properties in an immutable type must be immutable.
        /// </summary>
        internal static string IMM004Title {
            get {
                return ResourceManager.GetString("IMM004Title", resourceCulture);
            }
        }
    }
}
