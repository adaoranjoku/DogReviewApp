using DogReviewApp.Data;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

public void DatabaseConfigure(IServiceCollection services)
{
    services.AddDbContext<ApplicationDbContext>(b =>
    {
        b.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
    });



    services.AddHangfire(x => x.UseSqlServerStorage(Configuration.GetConnectionString("DefaultConnection")));



    services.AddHangfireServer();


    services.AddIdentityCore<ApplicationUser>(options => { });
    new IdentityBuilder(typeof(ApplicationUser), typeof(ApplicationRole), services)
        .AddRoleManager<RoleManager<ApplicationRole>>().AddUserManager<UserManager<ApplicationUser>>()
        .AddSignInManager<SignInManager<ApplicationUser>>()
        .AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

}
