﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Okra.Helpers;

namespace Okra.Services
{
    public abstract class LifetimeManagerBase : ILifetimeManager
    {
        // *** Fields ***

        private HashSet<ILifetimeAware> _registeredServices = new HashSet<ILifetimeAware>();

        // *** Constructors ***

        public LifetimeManagerBase()
        {
        }

        // *** Methods ***

        public void Register(ILifetimeAware service)
        {
            // Validate parameters

            if (service == null)
                throw new ArgumentNullException(nameof(service));

            if (_registeredServices.Contains(service))
                throw new InvalidOperationException(ResourceHelper.GetErrorResource("Exception_InvalidOperation_CannotRegisterServiceMultipleTimes"));

            // Add the service to the internal list

            _registeredServices.Add(service);
        }

        public void Unregister(ILifetimeAware service)
        {
            // Validate parameters

            if (service == null)
                throw new ArgumentNullException(nameof(service));

            if (!_registeredServices.Contains(service))
                throw new InvalidOperationException(ResourceHelper.GetErrorResource("Exception_InvalidOperation_CannotUnregisterUnregisteredService"));

            // Remove the service from the internal list

            _registeredServices.Remove(service);
        }

        // *** Protected Methods ***

        protected virtual Task SuspendServicesAsync()
        {
            IEnumerable<Task> resumingTasks = _registeredServices.Select(service => service.OnSuspending());
            return Task.WhenAll(resumingTasks);
        }

        protected virtual Task ResumeServicesAsync()
        {
            IEnumerable<Task> resumingTasks = _registeredServices.Select(service => service.OnResuming());
            return Task.WhenAll(resumingTasks);
        }
    }
}
