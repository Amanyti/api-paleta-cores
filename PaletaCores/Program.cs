var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ADICIONE ESTA CONFIGURAÇÃO DE CORS (logo após AddSwaggerGen)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()  // Permite qualquer origem (em produção, especifique suas URLs)
              .AllowAnyMethod()  // Permite todos os métodos HTTP (GET, POST, etc.)
              .AllowAnyHeader(); // Permite todos os cabeçalhos
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// ADICIONE ESTE MIDDLEWARE (antes de UseAuthorization e depois de UseRouting)
app.UseCors("AllowAll"); // Habilita a política CORS que configuramos acima

app.UseAuthorization();

app.MapControllers();

app.Run();