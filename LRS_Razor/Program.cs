using LRS_Razor;
using LRS_Razor.Data;
using LRS_Razor.Helpers;
using LRS_Razor.IService;
using LRS_Razor.Service;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;
using Microsoft.DotNet.Scaffolding.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllers();
var provider = builder.Services.BuildServiceProvider();
var configuration = provider.GetRequiredService<IConfiguration>();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", builder =>
    {
        builder
            .AllowAnyOrigin() // For any origin, or you can restrict it to specific origins.
            .AllowAnyMethod() // Allow any HTTP methods (e.g., GET, POST, PUT, etc.).
            .AllowAnyHeader(); // Allow any HTTP headers.

        // You can also configure specific origins like this:
        // builder.WithOrigins("https://example.com", "https://another.com");
    });
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddVersionedApiExplorer(c => {
    c.GroupNameFormat = "'v'VVV";
    c.SubstituteApiVersionInUrl = true;
    c.AssumeDefaultVersionWhenUnspecified = true;
    c.DefaultApiVersion = new ApiVersion(1, 0);
});
builder.Services.AddApiVersioning(c => {
    c.ReportApiVersions = true;
    c.AssumeDefaultVersionWhenUnspecified = true;
    c.DefaultApiVersion = new ApiVersion(1, 0);
});
builder.Services.AddSwaggerGen(c => {
    c.EnableAnnotations();
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "This is title",
        Version = "v1",
        Description = "This is Description"
    }) ;
    c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "basic",
        In = ParameterLocation.Header,
        Description = "Basic Auth Header"
    }) ;
    c.AddSecurityRequirement(new OpenApiSecurityRequirement {
        {
        new OpenApiSecurityScheme {
            Reference = new OpenApiReference
            {
                Type = ReferenceType.SecurityScheme,
                Id = "basic"
            }
        },
        new string [] { }
        }
    }) ;
});
builder.Services.AddAuthentication("BasicAuthentication")
    .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddControllers();
builder.Services.AddRouting();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseSwagger();
    app.UseSwaggerUI(
        c => { c.SwaggerEndpoint("Swagger/v1/swagger.json", "TestService"); }

        );
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseCors("CorsPolicy");

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
var httpContextAccessor = app.Services.GetRequiredService<IHttpContextAccessor>();
ConfigurationHelper.Initialize(configuration, httpContextAccessor);

app.MapRazorPages();

app.Run();

