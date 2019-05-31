namespace RCL.Spike.Editor
{
    using Microsoft.Extensions.DependencyInjection;

    public static class Extensions
    {
        public static void AddEditor(this IServiceCollection services)
        {
            services.ConfigureOptions(typeof(ConfigureOptions));
        }
    }
}
