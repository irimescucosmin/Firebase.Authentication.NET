using Firebase.Auth;
using Firebase.Auth.Providers;
using FirebaseAUTH.Interfaces;
using FirebaseAUTH.Services;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton(new FirebaseAuthClient(new FirebaseAuthConfig
{
    ApiKey = builder.Configuration.GetSection("Firebase:ApiKey").Value,
    AuthDomain = builder.Configuration.GetSection("Firebase:AuthDomain").Value,
    Providers =
    [
        // Add authentication type defined on firebase console
        new EmailProvider()
    ]
}));

// Register Authentication Service
builder.Services.AddSingleton<IAuthService, AuthService>();

// Add an authentication schema
builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
}).AddCookie();

var app = builder.Build();

app.MapControllers();
app.UseAuthentication();
app.UseAuthorization();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.Run();