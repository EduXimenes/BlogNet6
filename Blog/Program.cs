using Blog.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMvc();
builder.Services.AddDbContext<BlogDataContext>();


var app = builder.Build();

app.MapControllers();

app.Run();
