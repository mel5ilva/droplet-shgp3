using SHGP.Controllers;
using SHGP.Repository;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.


builder.Services.AddScoped<IUserRepository>(factory =>
{
    var connectionString = builder.Configuration.GetSection("DatabaseSettings").GetValue<string>("ConnectionString");
    return new UserRepository(connectionString);
});
builder.Services.AddScoped<IConsultaRepository>(factory =>
{
    var connectionString = builder.Configuration.GetSection("DatabaseSettings").GetValue<string>("ConnectionString");
    return new ConsultaRepository(connectionString);
});
builder.Services.AddScoped<IAgendamentoRepository>(factory =>
{
    var connectionString = builder.Configuration.GetSection("DatabaseSettings").GetValue<string>("ConnectionString");
    return new AgendamentoRepository(connectionString);
});
builder.Services.AddScoped<IAgendaRepository>(factory =>
{
    var connectionString = builder.Configuration.GetSection("DatabaseSettings").GetValue<string>("ConnectionString");
    return new AgendaRepository(connectionString);
});
builder.Services.AddScoped<ICartaoRepository>(factory =>
{
    var connectionString = builder.Configuration.GetSection("DatabaseSettings").GetValue<string>("ConnectionString");
    return new CartaoRepository(connectionString);
});
builder.Services.AddScoped<IEspecialidadeRepository>(factory =>
{
    var connectionString = builder.Configuration.GetSection("DatabaseSettings").GetValue<string>("ConnectionString");
    return new EspecialidadeRepository(connectionString);
});
builder.Services.AddScoped<IExamesRepository>(factory =>
{
    var connectionString = builder.Configuration.GetSection("DatabaseSettings").GetValue<string>("ConnectionString");
    return new ExamesRepository(connectionString);
});
builder.Services.AddScoped<IFicha_MedicaRepository>(factory =>
{
    var connectionString = builder.Configuration.GetSection("DatabaseSettings").GetValue<string>("ConnectionString");
    return new Ficha_MedicaRepository(connectionString);
});

builder.Services.AddScoped<IMed_EspRepository>(factory =>
{
    var connectionString = builder.Configuration.GetSection("DatabaseSettings").GetValue<string>("ConnectionString");
    return new Med_EspRepository(connectionString);
});
builder.Services.AddScoped<IMedicosRepository>(factory =>
{
    var connectionString = builder.Configuration.GetSection("DatabaseSettings").GetValue<string>("ConnectionString");
    return new MedicosRepository(connectionString);
});
builder.Services.AddScoped<IPacienteRepository>(factory =>
{
    var connectionString = builder.Configuration.GetSection("DatabaseSettings").GetValue<string>("ConnectionString");
    return new PacienteRepository(connectionString);
});
builder.Services.AddScoped<IPagamentosRepository>(factory =>
{
    var connectionString = builder.Configuration.GetSection("DatabaseSettings").GetValue<string>("ConnectionString");
    return new PagamentosRepository(connectionString);
});
builder.Services.AddScoped<IReceitasMedicasRepository>(factory =>
{
    var connectionString = builder.Configuration.GetSection("DatabaseSettings").GetValue<string>("ConnectionString");
    return new ReceitasMedicasRepository(connectionString);
});
builder.Services.AddScoped<IResul_ExamesRepository>(factory =>
{
    var connectionString = builder.Configuration.GetSection("DatabaseSettings").GetValue<string>("ConnectionString");
    return new Resul_ExamesRepository(connectionString);
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();

var app = builder.Build();



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
