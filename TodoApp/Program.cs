using System;

public class Program
{
    public static void Main(string[] args)
    {

        TodoManager todos = new TodoManager();


        while (true)
        {
            Console.WriteLine("\n\nHey there!, Welcome to C# OOP TodoApp project ");
            Console.WriteLine("\n To-Do List Application");
            Console.WriteLine("1. Add a To-Do Item");
            Console.WriteLine("2. Delete To-Do List item of index ");
            Console.WriteLine("3. View To-Do List ");
            Console.WriteLine("4. Search a To-Do Item");
            Console.WriteLine("5. Update a To-Do Item");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter a Title : ");
                    string title = Console.ReadLine();
                    Console.WriteLine("Enter your description  ");
                    string description = Console.ReadLine();

                    TodoItem todoItem = new TodoItem(TodoItem.id, title, description);
                    todos.AddTodoItem(todoItem);
                    Console.WriteLine("Item added to the To-Do list.");
                    break;

                case "2":
                    Console.Write("Enter the index : ");
                    int index = Convert.ToInt32(Console.ReadLine());
                    todos.DeleteTodoItem(index);
                    Console.WriteLine("Item removed from the To-Do list.");
                    break ;

                case "3":
                    todos.ViewTodoList();
                    break;
                case "4":
                    Console.Write("Enter the index : ");
                    int inde = Convert.ToInt32(Console.ReadLine());
                    
                    todos.SearchItem(inde);
                    
                    break ;

                case "5":
                     Console.Write("Enter the index to Update item: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                     Console.Write("Enter a Title : ");
                    string title1 = Console.ReadLine();
                    Console.WriteLine("Enter your description  ");
                    string description1 = Console.ReadLine();

                    todos.EditTodoItem(id, title1, description1);
                    break;


                case "6":
                    Environment.Exit(0);
                    break;
            }
        }


        
      
    }
}
