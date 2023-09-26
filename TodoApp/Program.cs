﻿using System;

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
            Console.WriteLine("4. Exit");
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

                case "3":
                    todos.ViewTodoList();
                    break;

                case "4":
                    Environment.Exit(0);
                    break;
            }
        }


        
      
    }
}