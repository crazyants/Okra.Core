﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Okra.Core {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal Resources() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Okra.Core.Resources", typeof(Resources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
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
        ///    Looks up a localized string similar to Multiple constructors accepting all given argument types have been found in type &apos;{0}&apos;. There should only be one applicable constructor..
        /// </summary>
        public static string AmbiguousConstructorMatch {
            get {
                return ResourceManager.GetString("AmbiguousConstructorMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Unable to locate implementation &apos;{0}&apos; for service &apos;{1}&apos;..
        /// </summary>
        public static string CannotLocateImplementation {
            get {
                return ResourceManager.GetString("CannotLocateImplementation", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Unable to resolve service for type &apos;{0}&apos; while attempting to activate &apos;{1}&apos;..
        /// </summary>
        public static string CannotResolveService {
            get {
                return ResourceManager.GetString("CannotResolveService", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The list of pages cannot contain a &apos;null&apos; page..
        /// </summary>
        public static string Exception_ArgumentException_EnumerableContainsNullPage {
            get {
                return ResourceManager.GetString("Exception_ArgumentException_EnumerableContainsNullPage", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The argument must be a member access lambda expression..
        /// </summary>
        public static string Exception_ArgumentException_ShouldBeAMemberAccessLambdaExpression {
            get {
                return ResourceManager.GetString("Exception_ArgumentException_ShouldBeAMemberAccessLambdaExpression", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The argument contains an undefined enumeration value..
        /// </summary>
        public static string Exception_ArgumentException_SpecifiedEnumIsNotDefined {
            get {
                return ResourceManager.GetString("Exception_ArgumentException_SpecifiedEnumIsNotDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The argument cannot be null or an empty string..
        /// </summary>
        public static string Exception_ArgumentException_StringIsNullOrEmpty {
            get {
                return ResourceManager.GetString("Exception_ArgumentException_StringIsNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The specified index is outside the bounds of the array..
        /// </summary>
        public static string Exception_ArgumentOutOfRange_ArrayIndexOutOfRange {
            get {
                return ResourceManager.GetString("Exception_ArgumentOutOfRange_ArrayIndexOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The parameter must be greater than zero..
        /// </summary>
        public static string Exception_ArgumentOutOfRange_ParameterMustBePositive {
            get {
                return ResourceManager.GetString("Exception_ArgumentOutOfRange_ParameterMustBePositive", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The parameter must be greater than or equal to zero..
        /// </summary>
        public static string Exception_ArgumentOutOfRange_ParameterMustBeZeroOrPositive {
            get {
                return ResourceManager.GetString("Exception_ArgumentOutOfRange_ParameterMustBeZeroOrPositive", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The specified ActivationKind is not supported..
        /// </summary>
        public static string Exception_InvalidOperation_ActivationKindNotSupported {
            get {
                return ResourceManager.GetString("Exception_InvalidOperation_ActivationKindNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to You cannot dispose the root AppContainer..
        /// </summary>
        public static string Exception_InvalidOperation_CannotDisposeRootAppContainer {
            get {
                return ResourceManager.GetString("Exception_InvalidOperation_CannotDisposeRootAppContainer", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to You cannot navigate backwards as the back stack is empty..
        /// </summary>
        public static string Exception_InvalidOperation_CannotGoBackWithEmptyBackStack {
            get {
                return ResourceManager.GetString("Exception_InvalidOperation_CannotGoBackWithEmptyBackStack", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to You cannot navigate forwards as the forward stack is empty..
        /// </summary>
        public static string Exception_InvalidOperation_CannotGoForwardWithEmptyForwardStack {
            get {
                return ResourceManager.GetString("Exception_InvalidOperation_CannotGoForwardWithEmptyForwardStack", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Cannot modify a read-only collection..
        /// </summary>
        public static string Exception_InvalidOperation_CannotModifyReadOnlyCollection {
            get {
                return ResourceManager.GetString("Exception_InvalidOperation_CannotModifyReadOnlyCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Cannot modify share properties as a share target..
        /// </summary>
        public static string Exception_InvalidOperation_CannotModifyShareProperties {
            get {
                return ResourceManager.GetString("Exception_InvalidOperation_CannotModifyShareProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Cannot navigate as a page named &apos;{0}&apos; does not exist..
        /// </summary>
        public static string Exception_InvalidOperation_CannotNavigateAsPageIsNotFound {
            get {
                return ResourceManager.GetString("Exception_InvalidOperation_CannotNavigateAsPageIsNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to You cannot register a service multiple times..
        /// </summary>
        public static string Exception_InvalidOperation_CannotRegisterServiceMultipleTimes {
            get {
                return ResourceManager.GetString("Exception_InvalidOperation_CannotRegisterServiceMultipleTimes", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Cannot unregister the service as it is not currently registered..
        /// </summary>
        public static string Exception_InvalidOperation_CannotUnregisterUnregisteredService {
            get {
                return ResourceManager.GetString("Exception_InvalidOperation_CannotUnregisterUnregisteredService", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The called constructor is not supported for the action &apos;{0}&apos;..
        /// </summary>
        public static string Exception_InvalidOperation_ConstructorNotSupportedForAction {
            get {
                return ResourceManager.GetString("Exception_InvalidOperation_ConstructorNotSupportedForAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The &apos;{0}&apos; property cannot be set after the application has been activated..
        /// </summary>
        public static string Exception_InvalidOperation_PropertyCannotBeSetAfterActivation {
            get {
                return ResourceManager.GetString("Exception_InvalidOperation_PropertyCannotBeSetAfterActivation", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The &apos;{0}&apos; service has already been injected into the container..
        /// </summary>
        public static string Exception_InvalidOperation_ServiceAlreadyInjected {
            get {
                return ResourceManager.GetString("Exception_InvalidOperation_ServiceAlreadyInjected", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The service &apos;{0}&apos; has not been injected into the container..
        /// </summary>
        public static string Exception_InvalidOperation_ServiceNotInjected {
            get {
                return ResourceManager.GetString("Exception_InvalidOperation_ServiceNotInjected", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The specified page &apos;{0}&apos; does not exist in the navigation stack..
        /// </summary>
        public static string Exception_InvalidOperation_SpecifiedPageDoesNotExistInNavigationStack {
            get {
                return ResourceManager.GetString("Exception_InvalidOperation_SpecifiedPageDoesNotExistInNavigationStack", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to A suitable constructor for type &apos;{0}&apos; could not be located. Ensure the type is concrete and services are registered for all parameters of a public constructor..
        /// </summary>
        public static string NoConstructorMatch {
            get {
                return ResourceManager.GetString("NoConstructorMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to No service for type &apos;{0}&apos; has been registered..
        /// </summary>
        public static string NoServiceRegistered {
            get {
                return ResourceManager.GetString("NoServiceRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Implementation type cannot be &apos;{0}&apos; because it is indistinguishable from other services registered for &apos;{1}&apos;..
        /// </summary>
        public static string TryAddIndistinguishableTypeToEnumerable {
            get {
                return ResourceManager.GetString("TryAddIndistinguishableTypeToEnumerable", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The bootstrapper must be initialized before performing this operation..
        /// </summary>
        internal static string Exception_InvalidOperation_BootstrapperNotInitialized {
            get {
                return ResourceManager.GetString("Exception_InvalidOperation_BootstrapperNotInitialized", resourceCulture);
            }
        }
    }
}
