namespace Library;

public class TaskList
{
     List<Task> tasks = new();

    public void AddTask(Task task)
    {
        tasks.Add(task);
        Console.WriteLine($"Задача {task.GetTitle()} добавлена");
    }

    public void RemoveTask(string title)
    {
        bool found = false;
        foreach (var task in tasks)
        {
            if (task.GetTitle() == title)
            {
                tasks.Remove(task);
                Console.WriteLine($"Задача {title} удалена");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Задача не найдена");
        }
    }

    public void MarkAsCompleted(string title)
    {
        bool found = false;
        foreach (var task in tasks)
        {
            if (task.GetTitle() == title)
            {
                task.MarkAsCompleted();
                Console.WriteLine($"Задача {title} отмечена как выполненная");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Задача не найдена.");
        }
    }

    public void ShowAllTasks()
    {
        Console.WriteLine("Список всех задач :");
        if (tasks.Count == 0)
        {
            Console.WriteLine("Нет задач");
        }
        else
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
    }
}
