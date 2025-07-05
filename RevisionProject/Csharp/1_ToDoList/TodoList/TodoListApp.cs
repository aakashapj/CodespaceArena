Console.WriteLine("Hello");
List<string> todoList = new();

bool shallExit = false;

while (!shallExit)
{
    Console.WriteLine("What do you want to do ?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    var userInput = Console.ReadLine();

    switch (userInput)
    {
        case "A":
        case "a":
            AddToTodo();
            break;

        case "E":
        case "e":
            shallExit = true;
            break;

        case "S":
        case "s":
            ShowAllTodo();
            break;

        case "R":
        case "r":
            if (ShowAllTodo())
            {
                RemoveToDo();
            }
            break;
    }

    Console.WriteLine();

}

bool ShowAllTodo()
{
    if (todoList.Count > 0)
    {
        var indexCount = 1;
        foreach (var todo in todoList)
        {
            ShowMessage($"{indexCount}. {todo}");
            indexCount++;
        }
        return true;
    }

    ShowMessage("No TODOs have been added yet.");
    return false;
}

void AddToTodo()
{
    bool shallExitFromMethod = false;

    while (!shallExitFromMethod)
    {
        Console.WriteLine("Enter the TODO description: ");
        var todoDescription = Console.ReadLine();

        if (todoDescription == null)
        {
            ShowMessage("The description cannot be empty.");
        }
        else if (!todoList.Contains(todoDescription))
        {
            todoList.Add(todoDescription);
            ShowMessage($"TODO sucessfully added: {todoDescription}");
            shallExitFromMethod = true;
        }
        else
        {
            ShowMessage("The description must be unique.");
        }
    }
}


void RemoveToDo()
{
    ShowMessage("Select the index of the TODO you want to remove: ");
    bool isParsed = int.TryParse(Console.ReadLine(), out int parsedInput);
    var index = parsedInput - 1;

    if (isParsed && index < todoList.Count)
    {
        var todoDescription = todoList[index];
        todoList.RemoveAt(index);
        ShowMessage($"TODO removed: {todoDescription}");
    }
    else
    {
        ShowMessage("The given index is empty or not valid .");
    }
}

void ShowMessage(string message)
{
    Console.WriteLine(message);
}