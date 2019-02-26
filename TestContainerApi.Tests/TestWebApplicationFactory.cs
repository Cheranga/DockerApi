using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;

namespace TestContainerApi.Tests
{
    public class TestWebApplicationFactory : WebApplicationFactory<Startup>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            //
            // Setup the tests related implementations
            //
            //builder.ConfigureTestServices(services => { services.AddSingleton<ICustomerRepository, TestCustomerRepository>(); });
        }
    }
}
