using Microsoft.Extensions.DependencyInjection;

namespace MissingCoverage.Host
{
    public static class ServiceDescriptorExtensions
    {
        public static bool CheckLifetime(this ServiceDescriptor serviceDescriptor, ServiceLifetime serviceLifetime = ServiceLifetime.Transient)
        {
            return serviceDescriptor.Lifetime == serviceLifetime;
        }
    }
}
