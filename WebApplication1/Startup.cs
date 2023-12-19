using FluentAssertions.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace WebApplication1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString
            ("defaultConnection")));
        }

            Services.AddSwaggerGen(Services=>
            {
                services.SwaggerDoc("v1"), new OpenApiInfo
            {
                Title = "WebApiAutores",
            })
    }
}
