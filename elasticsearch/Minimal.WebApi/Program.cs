using Elastic.Clients.Elasticsearch;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

ElasticsearchClientSettings settings = new ElasticsearchClientSettings(new Uri("http://localhost:9200"));
settings.DefaultIndex("products");

ElasticsearchClient client = new ElasticsearchClient(settings);

client.IndexAsync("products", i => i.Index("products"));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/products/create", async (CreateProductDto request, CancellationToken cancellationToken) =>
{
    Product product = new()
    {
        Name = request.Name,
        Price = request.Price,
        Stock = request.Stock,
        Description = request.Description,
    };

    CreateRequest<Product> createRequest = new(product.Id.ToString())
    {
        Document = product
    };
    
    CreateResponse response = await client.CreateAsync(createRequest, cancellationToken);

    return Results.Ok(response.Id);
});

app.MapGet("/products/getall", async (CancellationToken cancellationToken) =>
{
    SearchResponse<Product> response = await client.SearchAsync<Product>("products", cancellationToken);
    return Results.Ok(response.Documents);
});

app.Run();


class Product
{
    public Product()
    {
        Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public string Description { get; set; } = default!;
}

record CreateProductDto(string Name, decimal Price, int Stock, string Description);