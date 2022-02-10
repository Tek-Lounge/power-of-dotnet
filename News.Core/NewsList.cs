using System.Text.Json.Serialization;

namespace News.Core;

public record NewsList(
    [property: JsonPropertyName("pagination")] Pagination Pagination,
    [property: JsonPropertyName("data")] List<News> Data);

public record Pagination(
    [property: JsonPropertyName("limit")] int Limit,
    [property: JsonPropertyName("offset")] int Offset,
    [property: JsonPropertyName("count")] int Count,
    [property: JsonPropertyName("total")] int Total);
