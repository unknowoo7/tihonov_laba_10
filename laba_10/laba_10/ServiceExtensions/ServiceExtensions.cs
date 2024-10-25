using laba_10.Interfaces;
using laba_10.Services;

namespace laba_10.ServiceExtensions
{
  public static class ServiceExtensions
  {
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
      services.AddScoped<IManager, ManagerService>();

      return services;
    }
  }
}
