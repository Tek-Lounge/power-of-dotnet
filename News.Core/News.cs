using System.Text.Json.Serialization;

namespace News.Core;

public record News(
    [property: JsonPropertyName("author")] string Author,
    [property: JsonPropertyName("title")] string Title,
    [property: JsonPropertyName("description")] string Description,
    [property: JsonPropertyName("url")] string URL,
    [property: JsonPropertyName("source")] string Source,
    [property: JsonPropertyName("image")] string Image,
    [property: JsonPropertyName("category")] string Category,
    [property: JsonPropertyName("language")] string Language,
    [property: JsonPropertyName("country")] string Country,
    [property: JsonPropertyName("published_at")] DateTime PublishedAt);