using System.Text.Json;
using System.Text.Json.Serialization;

// Get data
var products = JsonSerializer.Deserialize<List<Product>>(File.ReadAllText("./Data/products.json"));

var builder = WebApplication.CreateBuilder(args);

// Swagger Config
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "Contoso Product Search", Version = "v1", Description = "Search through Contoso's wide range of outdoor and recreational products." });
});

// For certain scenarios to work with OpenAI, CORS needs to be enabled per documentation here: https://beta.openai.com/docs/developer-quickstart/your-first-api-request
builder.Services.AddCors(options =>
{
    options.AddPolicy("OpenAI", policy =>
    {
        policy.WithOrigins("https://chat.openai.com");
        policy.AllowAnyHeader();
        policy.AllowAnyMethod();
    });
});

var app = builder.Build();

// Use CORS
app.UseCors("OpenAI");

// Static files here are being used only to serve the logo.png and manifest files
// This can be served from anywhere (CDN, blob storage, etc.) and if so, this can be removed.
app.UseStaticFiles();

// This ensures the OpenAPI definition is served for the plugin
app.UseSwagger();

if (app.Environment.IsDevelopment())
{
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/products", (string? query = null) =>
{
    if (query is not null)
    {
        return products?.Where(p => p.Name?.Contains(query, StringComparison.OrdinalIgnoreCase) == true ||
            p.Description?.Contains(query, StringComparison.OrdinalIgnoreCase) == true ||
            p.Category?.Contains(query, StringComparison.OrdinalIgnoreCase) == true);
    }

    return products;
})
.WithName("GetProducts")
.WithDescription("Get a list of products")
.WithOpenApi();

app.Run();

public class Product
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    [JsonPropertyName("category")]
    public string? Category { get; set; }
    [JsonPropertyName("size")]
    public string? Size { get; set; }
    [JsonPropertyName("price")]
    public float Price { get; set; }
}