using System;
using System.Globalization;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class TodoItem
{
	private int Uid { get; set; }
	public static int id = 0;
	public string Title { get; set; }
	public string Description { get; set; }

	//getter and setters for the Uid 
	public int get_setUid
	{
		get { return Uid; }
		set
		{
			if(value < 0)
			{
				Console.WriteLine("Invalid uid");
			}
			else
			{
				this.Uid = value;
			}
			
		}
	}
	public TodoItem(int uid, string atitle, string description)
	{
		get_setUid = uid;
		this.Title = atitle;
		this.Description = description;

		id++;
	}
     public override string ToString()
    {
        return $"Item {Uid}---> Title : {Title},  Description : {Description}";
    }


}
public class TodoManager
{
    private List<TodoItem> todoItems = new List<TodoItem>();

	//using an indexer
	public TodoItem this[int uid]
	{
		//Find and return the searched uid from the list 
		get {  return todoItems.Find(items => items.get_setUid == uid); }
		set
		{
			// if index already exist then replace the content of that id with the new content 
			int index = todoItems.FindIndex(items => items.get_setUid == uid);
			if(index >= 0)
			{
				todoItems[index] = value;
			}
			else
			{
				todoItems.Add(value);
			}
		}
	}


	public void AddTodoItem (TodoItem todo)
	{
		todoItems.Add(todo);
		
	}

	public void DeleteTodoItem(int uid)
	{
		todoItems.RemoveAll(items => items.get_setUid == uid);
	}

	public void ViewTodoList()
	{
		
		if(todoItems.Count == 0)
		{
			Console.WriteLine("\nNo To-Do items Found. Please add a To-Do item");
		}
		else
		{

			foreach (var item in todoItems)
			{

				Console.WriteLine("****************************************************************");
				Console.WriteLine($"\n {item}");
                Console.WriteLine("****************************************************************");
            }

		}   
	}

	public void SearchItem(int uid)
	{
		
		if(uid < 0)
		{
			Console.WriteLine("\nInvalid id. Item not Found...");
		}
		else
		{
            try
			{
                TodoItem item = todoItems[uid];
                Console.WriteLine($"Item Found is   {item}");
            }catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
        }
			
		
	}

	// there is a bug here, when updating the item is duplicated 

	public void EditTodoItem(int uid, string title, string desc)
	{
		// no need for this below cuz the indexer already checks and return an available item no need to check again
		//int index = todoItems.FindIndex(items => items.get_setUid == uid);
		try
		{
			TodoItem item = todoItems[uid];
			item.Title = title;
			item.Description = desc;
            todoItems.Insert(uid, item);
        }catch(Exception e)
		{
			Console.WriteLine(e.Message);
		}
		
	}


	~TodoManager()
	{
		Console.WriteLine("Thank you :)");
	}


}
