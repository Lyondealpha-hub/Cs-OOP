using System;
using System.Globalization;
using System.Collections.Generic;

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
				Console.WriteLine("No To-Do items Found. Please add a To-Do item");
			}
			else
			{

			foreach (var item in todoItems)
			{
				Console.WriteLine($"\nList of items below \n {item}");
			}

		}
           
	}

}
