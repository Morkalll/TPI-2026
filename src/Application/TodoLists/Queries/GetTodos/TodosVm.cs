using TPI_2026.Application.Common.Models;

namespace TPI_2026.Application.TodoLists.Queries.GetTodos;

public class TodosVm
{
    public IReadOnlyCollection<LookupDto> PriorityLevels { get; init; } = [];

    public IReadOnlyCollection<ColourDto> Colours { get; init; } = [];

    public IReadOnlyCollection<TodoListDto> Lists { get; init; } = [];
}

public class ColourDto
{
    public string Code { get; init; } = string.Empty;

    public string Name { get; init; } = string.Empty;
}
