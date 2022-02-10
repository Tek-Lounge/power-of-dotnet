using News.Core;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/categories", () =>
{
    return new List<Category>(){
        new Category("general", "General"),
        new Category("business", "Business"),
        new Category("entertainment", "Entertainment"),
        new Category("health", "Health"),
        new Category("science", "Science"),
        new Category("sports", "Sports"),
        new Category("technology", "Technology"),
    };
});

app.MapGet("/news", async (string categories) => {
    var client = new NewsClient();
    var news = await client.GetNews(string.Join(",", categories));
    return news;
});

app.Run();
