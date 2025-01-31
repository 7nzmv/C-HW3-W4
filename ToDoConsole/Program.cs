using Library;


class Program
{
    static TaskList taskList = new TaskList();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Добавить задачу");
            Console.WriteLine("2. Удалить задачу");
            Console.WriteLine("3. Отметить как выполненную");
            Console.WriteLine("4. Показать все задачи");
            Console.WriteLine("0. Выход");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    RemoveTask();
                    break;
                case "3":
                    CompleteTask();
                    break;
                case "4":
                    taskList.ShowAllTasks();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Неверный ввод, попробуйте снова.");
                    break;
            }
        }
    }


    static void AddTask()
    {
        Console.Write("Введите название задачи: ");
        string title = Console.ReadLine();
        Console.Write("Введите описание задачи: ");
        string description = Console.ReadLine();

        Library.Task task = new Library.Task(title, description);
        taskList.AddTask(task);
    }

    static void RemoveTask()
    {
        Console.Write("Введите название задачи для удаления: ");
        string title = Console.ReadLine();
        taskList.RemoveTask(title);

    }

    static void CompleteTask()
    {
        Console.Write("Введите название задачи, чтобы отметить её выполненной: ");
        string title = Console.ReadLine();
        taskList.MarkAsCompleted(title);

    }


}

