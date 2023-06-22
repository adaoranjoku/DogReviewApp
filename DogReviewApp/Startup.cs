//using DogReviewApp.Data;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;

//namespace DogReviewApp
//{
//    public class Startup
//    {
//        public IConfiguration Configuration { get; set; }
//        public Startup(IConfiguration configuration)
//        {
//            Configuration = configuration;
//        }
//        public void ConfigureServices(IServiceCollection services)
//        {
//            services.AddControllers();
//            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//            services.AddEndpointsApiExplorer();
//            services.AddSwaggerGen();
            

//        }
//        public void DatabaseConfigure(IServiceCollection services)
//        {
//            services.AddDbContext<ApplicationDbContext>(options =>
//            {
//                options.UseSqlServer(services.Configuration.GetConnectionString("DefaultConnection"));
//            });
//        }
//    }
//}
