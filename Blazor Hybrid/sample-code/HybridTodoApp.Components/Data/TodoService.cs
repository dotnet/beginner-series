namespace HybridTodoApp.Data;

using System.Text.Json;

public class TodoService
{
    string file = string.Empty;
    public TodoService()
    {
        file = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "items.json");
    }
    public void SaveItems(IEnumerable<TodoItem> items)
    {
        File.WriteAllText(file, JsonSerializer.Serialize(items));
    }

    public IEnumerable<TodoItem> LoadItems()
    {
        if (!File.Exists(file))
            return Enumerable.Empty<TodoItem>();

        var itemJson = File.ReadAllText(file);
        return JsonSerializer.Deserialize<IEnumerable<TodoItem>>(itemJson) ?? Enumerable.Empty<TodoItem>(); ;
    }
}