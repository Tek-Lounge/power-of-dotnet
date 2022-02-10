using News.Core;
using Spectre.Console;

var categories = AnsiConsole.Prompt(
    new MultiSelectionPrompt<string>()
        .Title("News Categories:")
        .AddChoices(new[] {
            "general", "business", "entertainment",
            "health", "science", "sports", "technology"
        }));

var news = await new NewsClient().GetNews(string.Join(",", categories));

news?.Data?.ForEach(item =>
{
    AnsiConsole.MarkupLine($"[bold]{item.Title.EscapeMarkup()}[/]");
    // AnsiConsole.MarkupLine($"[dim]{item.Description.EscapeMarkup()}[/]");
    AnsiConsole.MarkupLine($"[dim]{item.Source} | {item.Category} | {item.PublishedAt}[/]");
    AnsiConsole.MarkupLine($"[blue underline]{item.URL}[/]");
    AnsiConsole.WriteLine();
    // AnsiConsole.Write(new Rule());
});
