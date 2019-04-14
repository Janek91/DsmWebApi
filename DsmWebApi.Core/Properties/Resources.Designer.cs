﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18046
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DsmWebApi.Core.Properties
{


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
    internal class Resources
    {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources()
        {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DsmWebApi.Core.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to API does not exist.
        /// </summary>
        internal static string ApiDoesNotExistMessage
        {
            get
            {
                return ResourceManager.GetString("ApiDoesNotExistMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to API version is not supported.
        /// </summary>
        internal static string ApiVersionNotSupported
        {
            get
            {
                return ResourceManager.GetString("ApiVersionNotSupported", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Connection time out.
        /// </summary>
        internal static string ConnectionTimeOutMessage
        {
            get
            {
                return ResourceManager.GetString("ConnectionTimeOutMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Insufficient user privilege.
        /// </summary>
        internal static string InsufficientUserPrivilegeMessage
        {
            get
            {
                return ResourceManager.GetString("InsufficientUserPrivilegeMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Invalid parameters.
        /// </summary>
        internal static string InvalidParametersMessage
        {
            get
            {
                return ResourceManager.GetString("InvalidParametersMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Method does not exist.
        /// </summary>
        internal static string MethodDoesNotExist
        {
            get
            {
                return ResourceManager.GetString("MethodDoesNotExist", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Multiple login detected.
        /// </summary>
        internal static string MultipleLoginDetected
        {
            get
            {
                return ResourceManager.GetString("MultipleLoginDetected", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Unknown error code.
        /// </summary>
        internal static string UnknownErrorCodeMessage
        {
            get
            {
                return ResourceManager.GetString("UnknownErrorCodeMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Unknown error.
        /// </summary>
        internal static string UnknownErrorMessage
        {
            get
            {
                return ResourceManager.GetString("UnknownErrorMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The &quot;{0}&quot; API is not supported by your DSM system..
        /// </summary>
        internal static string UnsupportedApiMessage
        {
            get
            {
                return ResourceManager.GetString("UnsupportedApiMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The supported version of the authentication API is not in the range of the versions supported by the DSM system (Supported version = {0}, Range = {1}-{2}).
        /// </summary>
        internal static string UnsupportedApiVersionMessage
        {
            get
            {
                return ResourceManager.GetString("UnsupportedApiVersionMessage", resourceCulture);
            }
        }
    }
}
