﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.AspNet.WebHooks.Properties {
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
    internal class ReceiverResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ReceiverResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.AspNet.WebHooks.Properties.ReceiverResources", typeof(ReceiverResources).Assembly);
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
        ///   Looks up a localized string similar to Multiple types were found that match the WebHook receiver named &apos;{0}&apos;. This can happen if multiple receivers are defined with the same name but different casing which is not supported. The request for &apos;{0}&apos; has found the following matching receivers: {1}{2}..
        /// </summary>
        internal static string Manager_MultipleAmbiguousReceiversFound {
            get {
                return ResourceManager.GetString("Manager_MultipleAmbiguousReceiversFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No WebHook receiver has been registered with the name &apos;{0}&apos;. Please use one of the registered receivers..
        /// </summary>
        internal static string Manager_UnknownReceiver {
            get {
                return ResourceManager.GetString("Manager_UnknownReceiver", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebHook request must contain an entity body formatted as HTML Form Data..
        /// </summary>
        internal static string Receiver_BadFormData {
            get {
                return ResourceManager.GetString("Receiver_BadFormData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expecting exactly one &apos;{0}&apos; header field in the WebHook request but found {1}. Please ensure that the request contains exactly one &apos;{0}&apos; header field..
        /// </summary>
        internal static string Receiver_BadHeader {
            get {
                return ResourceManager.GetString("Receiver_BadHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebHook request must contain an entity body formatted as JSON..
        /// </summary>
        internal static string Receiver_BadJson {
            get {
                return ResourceManager.GetString("Receiver_BadJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The HTTP &apos;{0}&apos; method is not supported by the &apos;{1}&apos; WebHook receiver..
        /// </summary>
        internal static string Receiver_BadMethod {
            get {
                return ResourceManager.GetString("Receiver_BadMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In order for the incoming WebHook request to be verified, the &apos;{0}&apos; setting must be set to a value between {1} and {2} characters long..
        /// </summary>
        internal static string Receiver_BadSecret {
            get {
                return ResourceManager.GetString("Receiver_BadSecret", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebHook signature provided by the &apos;{0}&apos; header field does not match the value expected by the &apos;{1}&apos; receiver. WebHook request is invalid..
        /// </summary>
        internal static string Receiver_BadSignature {
            get {
                return ResourceManager.GetString("Receiver_BadSignature", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebHook request entity body cannot be empty..
        /// </summary>
        internal static string Receiver_NoBody {
            get {
                return ResourceManager.GetString("Receiver_NoBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebHook request must contain an entity body formatted as HTML Form Data..
        /// </summary>
        internal static string Receiver_NoFormData {
            get {
                return ResourceManager.GetString("Receiver_NoFormData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebHook receiver &apos;{0}&apos; requires HTTPS in order to be secure. Please register a WebHook URI of type &apos;{1}&apos;..
        /// </summary>
        internal static string Receiver_NoHttps {
            get {
                return ResourceManager.GetString("Receiver_NoHttps", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebHook request must contain an entity body formatted as JSON..
        /// </summary>
        internal static string Receiver_NoJson {
            get {
                return ResourceManager.GetString("Receiver_NoJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WebHook receiver &apos;{0}&apos; could not process WebHook due to error: {1}.
        /// </summary>
        internal static string ReceiverController_Failure {
            get {
                return ResourceManager.GetString("ReceiverController_Failure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processing incoming WebHook request with receiver &apos;{0}&apos;..
        /// </summary>
        internal static string ReceiverController_Processing {
            get {
                return ResourceManager.GetString("ReceiverController_Processing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No WebHook receiver is registered with the name &apos;{0}&apos;..
        /// </summary>
        internal static string ReceiverController_Unknown {
            get {
                return ResourceManager.GetString("ReceiverController_Unknown", resourceCulture);
            }
        }
    }
}
