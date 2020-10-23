﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VMware.ScriptRuntimeService.APIGateway.Properties {
    using System;
    
    
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
    public class APIGatewayResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal APIGatewayResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("VMware.ScriptRuntimeService.APIGateway.Properties.APIGatewayResources", typeof(APIGatewayResources).Assembly);
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
        ///   Looks up a localized string similar to 1.0.0.
        /// </summary>
        public static string ApiVersion {
            get {
                return ResourceManager.GetString("ApiVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument transformation script not found for &apos;{0}&apos;.
        /// </summary>
        public static string ArgumentScriptsController_ArgumentTransformationScriptNotFound {
            get {
                return ResourceManager.GetString("ArgumentScriptsController_ArgumentTransformationScriptNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Session &apos;{0}&apos; doesn&apos;t exist.
        /// </summary>
        public static string InvalidSessionException_SessionDoesntExist {
            get {
                return ResourceManager.GetString("InvalidSessionException_SessionDoesntExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Session &apos;{0}&apos; has expired.
        /// </summary>
        public static string InvalidSessionException_SessionExpired {
            get {
                return ResourceManager.GetString("InvalidSessionException_SessionExpired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create runspace for user &quot;{0}&quot; failed with error: {1}.
        /// </summary>
        public static string MultiTenantRunspaceProvider_CreateFailed {
            get {
                return ResourceManager.GetString("MultiTenantRunspaceProvider_CreateFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Get runspace for user &quot;{0}&quot; failed with error: {1}.
        /// </summary>
        public static string MultiTenantRunspaceProvider_GetFailed {
            get {
                return ResourceManager.GetString("MultiTenantRunspaceProvider_GetFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Kill runspace for user &quot;{0}&quot; failed with error: {1}.
        /// </summary>
        public static string MultiTenantRunspaceProvider_KillFailed {
            get {
                return ResourceManager.GetString("MultiTenantRunspaceProvider_KillFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to List runspaces for user &quot;{0}&quot; failed with error: {1}.
        /// </summary>
        public static string MultiTenantRunspaceProvider_ListFailed {
            get {
                return ResourceManager.GetString("MultiTenantRunspaceProvider_ListFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User &quot;{0}&quot; doesn&apos;t have running runspaces.
        /// </summary>
        public static string MultiTenantRunspaceProvider_UserHasNoRunspaces {
            get {
                return ResourceManager.GetString("MultiTenantRunspaceProvider_UserHasNoRunspaces", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User &quot;{0}&quot; doesn&apos;t have runspace with id &quot;{1}&quot;.
        /// </summary>
        public static string MultiTenantRunspaceProvider_UserHasNoRunspaceWithId {
            get {
                return ResourceManager.GetString("MultiTenantRunspaceProvider_UserHasNoRunspaceWithId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Runspace where script runs doesn&apos;t respond. Could be because script active time is longer than maximum allowed time for a script execution.
        /// </summary>
        public static string PollingScriptExecutionPersister_ScriptFailed_RunspaceDisappeared {
            get {
                return ResourceManager.GetString("PollingScriptExecutionPersister_ScriptFailed_RunspaceDisappeared", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No VC refresh token is available for connect PowerCLI operation.
        /// </summary>
        public static string PowerCLIVCloginController_NoRefreshTokenAvailable_For_Session {
            get {
                return ResourceManager.GetString("PowerCLIVCloginController_NoRefreshTokenAvailable_For_Session", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Acquire Authorization Token from STS failed..
        /// </summary>
        public static string PowerCLIVCLoginController_Post_AcquireAuthorizationTokenFailed {
            get {
                return ResourceManager.GetString("PowerCLIVCLoginController_Post_AcquireAuthorizationTokenFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to # Script Runtime Service API
        ///
        ///Script Runtime Service for vSphere (SRS) allows running PowerShell and PowerCLI scripts. SRS is a VC add-on that is deployed separately from VCSA. SRS can be accessed via REST API that allows you to create PowerShell instances and run PowerShell and PowerCLI scripts within. No Connect-VIServer is required to run PowerCLI against VC(s) SRS is registered to.
        ///
        ///## Authetication
        ///
        ///SRS uses VC SSO as Identity and Authentication Server. Two types of authentication are supported.  [rest of string was truncated]&quot;;.
        /// </summary>
        public static string ProductApiDescription {
            get {
                return ResourceManager.GetString("ProductApiDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to v1.
        /// </summary>
        public static string ProductAPIVersion {
            get {
                return ResourceManager.GetString("ProductAPIVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Script Runtime Service for vSphere.
        /// </summary>
        public static string ProductName {
            get {
                return ResourceManager.GetString("ProductName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 1.0.
        /// </summary>
        public static string ProductVersion {
            get {
                return ResourceManager.GetString("ProductVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Runspace Provider failed to destroy runspace with id &apos;{0}&apos;.
        /// </summary>
        public static string RunspaceController_Kill_RunspaceProviderKillFailed {
            get {
                return ResourceManager.GetString("RunspaceController_Kill_RunspaceProviderKillFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are no runspaces.
        /// </summary>
        public static string RunspaceController_List_NoRunspaces {
            get {
                return ResourceManager.GetString("RunspaceController_List_NoRunspaces", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Runspace Provider failed to list user runspaces.
        /// </summary>
        public static string RunspaceController_List_RunspaceProviderListFailed {
            get {
                return ResourceManager.GetString("RunspaceController_List_RunspaceProviderListFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Maximum number of running runspaces is reached.
        /// </summary>
        public static string RunspaceController_Post_MaxnumberOfRunspacesReached {
            get {
                return ResourceManager.GetString("RunspaceController_Post_MaxnumberOfRunspacesReached", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Runspace with id &apos;{0}&apos; not found.
        /// </summary>
        public static string RunspaceNotFound {
            get {
                return ResourceManager.GetString("RunspaceNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Runspace &apos;{0}&apos; is not ready to run script. Runspace state is: {1}.
        /// </summary>
        public static string RunspaceNotReady {
            get {
                return ResourceManager.GetString("RunspaceNotReady", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Script Storage Service failed to retrieve script execution output.
        /// </summary>
        public static string ScriptOutputController_ScriptStorageService_FailedToRetrieveScriptOutput {
            get {
                return ResourceManager.GetString("ScriptOutputController_ScriptStorageService_FailedToRetrieveScriptOutput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Runspace failed to cancel the script execution.
        /// </summary>
        public static string ScriptsController_RunspaceFailedToCancelScriptExecution {
            get {
                return ResourceManager.GetString("ScriptsController_RunspaceFailedToCancelScriptExecution", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Runspace failed to process the script execution request.
        /// </summary>
        public static string ScriptsController_RunspaceFailedToProcessScriptRequest {
            get {
                return ResourceManager.GetString("ScriptsController_RunspaceFailedToProcessScriptRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Script with id &apos;{0}&apos; not found.
        /// </summary>
        public static string ScriptsController_ScriptNotFound {
            get {
                return ResourceManager.GetString("ScriptsController_ScriptNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Script Storage Service failed to retrieve script execution history.
        /// </summary>
        public static string ScriptsController_ScriptStorageService_FailedToRetrieveScripts {
            get {
                return ResourceManager.GetString("ScriptsController_ScriptStorageService_FailedToRetrieveScripts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Script Storage Service failed to retrieve script execution streams.
        /// </summary>
        public static string ScriptStreamsController_ScriptStorageService_FailedToRetrieveScriptStreams {
            get {
                return ResourceManager.GetString("ScriptStreamsController_ScriptStorageService_FailedToRetrieveScriptStreams", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Saml Token is not valid.
        /// </summary>
        public static string SessionsController_AuthenticationFailed {
            get {
                return ResourceManager.GetString("SessionsController_AuthenticationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Authorization header is not valid or session has been expired..
        /// </summary>
        public static string SessionsController_AuthorizationHeaderIsNotValid {
            get {
                return ResourceManager.GetString("SessionsController_AuthorizationHeaderIsNotValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sessions Service failed to delete session.
        /// </summary>
        public static string SessionsController_SessionsService_FailedToDeleteSession {
            get {
                return ResourceManager.GetString("SessionsController_SessionsService_FailedToDeleteSession", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to X-SRS-API-KEY.
        /// </summary>
        public static string SRSAuthorizationHeader {
            get {
                return ResourceManager.GetString("SRSAuthorizationHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to VMware, Inc..
        /// </summary>
        public static string Vendor {
            get {
                return ResourceManager.GetString("Vendor", resourceCulture);
            }
        }
    }
}