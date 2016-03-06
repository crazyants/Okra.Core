namespace Microsoft.Extensions.DependencyInjection.Abstractions
{
    using Okra.Helpers;
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        //private static readonly ResourceManager _resourceManager
        //    = new ResourceManager("Microsoft.Extensions.DependencyInjection.Abstractions.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// Multiple constructors accepting all given argument types have been found in type '{0}'. There should only be one applicable constructor.
        /// </summary>
        internal static string AmbiguousConstructorMatch
        {
            get { return GetString("AmbiguousConstructorMatch"); }
        }

        /// <summary>
        /// Multiple constructors accepting all given argument types have been found in type '{0}'. There should only be one applicable constructor.
        /// </summary>
        internal static string FormatAmbiguousConstructorMatch(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("AmbiguousConstructorMatch"), p0);
        }

        /// <summary>
        /// Unable to locate implementation '{0}' for service '{1}'.
        /// </summary>
        internal static string CannotLocateImplementation
        {
            get { return GetString("CannotLocateImplementation"); }
        }

        /// <summary>
        /// Unable to locate implementation '{0}' for service '{1}'.
        /// </summary>
        internal static string FormatCannotLocateImplementation(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("CannotLocateImplementation"), p0, p1);
        }

        /// <summary>
        /// Unable to resolve service for type '{0}' while attempting to activate '{1}'.
        /// </summary>
        internal static string CannotResolveService
        {
            get { return GetString("CannotResolveService"); }
        }

        /// <summary>
        /// Unable to resolve service for type '{0}' while attempting to activate '{1}'.
        /// </summary>
        internal static string FormatCannotResolveService(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("CannotResolveService"), p0, p1);
        }

        /// <summary>
        /// A suitable constructor for type '{0}' could not be located. Ensure the type is concrete and services are registered for all parameters of a public constructor.
        /// </summary>
        internal static string NoConstructorMatch
        {
            get { return GetString("NoConstructorMatch"); }
        }

        /// <summary>
        /// A suitable constructor for type '{0}' could not be located. Ensure the type is concrete and services are registered for all parameters of a public constructor.
        /// </summary>
        internal static string FormatNoConstructorMatch(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("NoConstructorMatch"), p0);
        }

        /// <summary>
        /// No service for type '{0}' has been registered.
        /// </summary>
        internal static string NoServiceRegistered
        {
            get { return GetString("NoServiceRegistered"); }
        }

        /// <summary>
        /// No service for type '{0}' has been registered.
        /// </summary>
        internal static string FormatNoServiceRegistered(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("NoServiceRegistered"), p0);
        }

        /// <summary>
        /// Implementation type cannot be '{0}' because it is indistinguishable from other services registered for '{1}'.
        /// </summary>
        internal static string TryAddIndistinguishableTypeToEnumerable
        {
            get { return GetString("TryAddIndistinguishableTypeToEnumerable"); }
        }

        /// <summary>
        /// Implementation type cannot be '{0}' because it is indistinguishable from other services registered for '{1}'.
        /// </summary>
        internal static string FormatTryAddIndistinguishableTypeToEnumerable(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("TryAddIndistinguishableTypeToEnumerable"), p0, p1);
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            //var value = _resourceManager.GetString(name);
            var value = ResourceHelper.GetErrorResource(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
