using API.Configs;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddUnitOfWork();
builder.Services.AddAuthorize();
builder.Services.AddAuthenticate();
builder.Services.AddSwaggerConfig();
builder.Services.AddDatabase();
builder.Services.AddServices();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
