﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CleanCode.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Warnings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Warnings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CleanCode.Resources.Warnings", typeof(Warnings).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Too many chained references. This might be violating the Law of Demeter. ({0} / {1}).
        /// </summary>
        public static string ChainedReferences {
            get {
                return ResourceManager.GetString("ChainedReferences", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Class contains too many methods. This might be violating the Single Responsibility Principle. ({0} / {1}).
        /// </summary>
        public static string ClassTooBig {
            get {
                return ResourceManager.GetString("ClassTooBig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Excessive depth of nested code blocks. ({0} / {1}).
        /// </summary>
        public static string ExcessiveDepth {
            get {
                return ResourceManager.GetString("ExcessiveDepth", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This expression is too complex. ({0} / {1}).
        /// </summary>
        public static string ExpressionTooComplex {
            get {
                return ResourceManager.GetString("ExpressionTooComplex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This argument is used as a flag in the method. This might be violating the Single Responsibility Principle..
        /// </summary>
        public static string FlagArgument {
            get {
                return ResourceManager.GetString("FlagArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The usage of the suffix &apos;{0}&apos; is discouraged because it&apos;s too generic. Choose a meaningful name instead to clarify its intent and responsibilities..
        /// </summary>
        public static string HollowTypeName {
            get {
                return ResourceManager.GetString("HollowTypeName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of this method is too short to be meaningful..
        /// </summary>
        public static string MethodNameNotMeaningful {
            get {
                return ResourceManager.GetString("MethodNameNotMeaningful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This method is too long, indicating that it has too much responsibility. ({0} / {1}).
        /// </summary>
        public static string MethodTooLong {
            get {
                return ResourceManager.GetString("MethodTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This method has too many declarations. ({0} / {1}).
        /// </summary>
        public static string TooManyDeclarations {
            get {
                return ResourceManager.GetString("TooManyDeclarations", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are too many interfaces being passed in to this constructor. It might be violating the Single Responsibility Principle. ({0} / {1}).
        /// </summary>
        public static string TooManyDependencies {
            get {
                return ResourceManager.GetString("TooManyDependencies", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This method requires too many arguments. ({0} / {1}).
        /// </summary>
        public static string TooManyMethodArguments {
            get {
                return ResourceManager.GetString("TooManyMethodArguments", resourceCulture);
            }
        }
    }
}
