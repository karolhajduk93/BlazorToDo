using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Runtime.Serialization.Formatters;
using Newtonsoft.Json;

namespace BlazorToDoApp.Models
{
	public class ToDoListModel
	{
		[BsonId]
		public string Id { get; set; }

		public string UserId { get; set; }

		public string ListName { get; set; }

		public string Date { get; set; }

		public List<ToDoItemModel> ToDoItems { get; set; }

		public List<ToDoItemModel> CompletedItems { get; set; }

		public ToDoListModel()
		{
			Id = Guid.NewGuid().ToString(); 
			ListName = "My Day";
			Date = DateTime.Now.ToString("dd-MM-yyyy");
			ToDoItems = new List<ToDoItemModel>();
			CompletedItems = new List<ToDoItemModel>();
		}
	}
}
