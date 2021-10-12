public class Startup
{
    public Startup(IConfiguration configuration, IWebHostEnvironment env)
    {
        Environment = env;
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }
    public IWebHostEnvironment Environment { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        if (Environment.IsDevelopment())
        {
            services.AddDbContext<fooddeliveryfoodieContext>(options =>
            options.UseSqlite(
                Configuration.GetConnectionString("fooddeliveryfoodieContext")));
        }
        else
        {
            services.AddDbContext<fooddelevery.foodieContext>(options =>
            options.UseSqlServer(
                Configuration.GetConnectionString("fooddeliveryfoodieContext")));
        }

        services.fooddelivery();
    }

    public void Configure(IApplicationBuilder app)
    {
        if (Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapRazorPages();
        });
    }
}