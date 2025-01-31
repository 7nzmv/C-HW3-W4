namespace Library;

public class Task
{
    private string _title;
    private string _description;
    private bool _isCompleted;

    public Task(string title, string description)
    {
        _title = title;
        _description = description;
        _isCompleted = false;
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string newTitle)
    {
        if (!string.IsNullOrWhiteSpace(newTitle))
        {
            _title = newTitle;
        }
        else
        {
            Console.WriteLine("Название задачи не может быть пустым");
        }
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string newDescription)
    {
        if (!string.IsNullOrWhiteSpace(newDescription))
        {
            _description = newDescription;
        }
        else
        {
            Console.WriteLine("Описание задачи не может быть пустым");
        }
    }

    public bool IsCompleted()
    {
        return _isCompleted;
    }

    public void MarkAsCompleted()
    {
        _isCompleted = true;
    }

   public override string ToString()
{
    string status;
    if (_isCompleted)
    {
        status = "Выполнена";
    }
    else
    {
        status = "Не выполнена";
    }
    
    return $"{_title} - {_description} - ( {status} )";
}
}
