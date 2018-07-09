using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMaintainance
{
	class Library
	{
		
		public List<Shelf> Shelves { get; set; }

		Library(List<Shelf> shelves)
		{
			Shelves = shelves;
		}

		public List<Student> Students { get; set; }
	}

	class Shelf
	{
		// Naming Convension: CoderLobby
		string Topic { get; set; }
		List<Book> Books { get; set; }

		Shelf(string topic, List<Book> books)
		{
			Topic = topic;
			var temp = from book in books
					   where book.Topic.ToLower() == Topic.ToLower()
					   select book;
			Books = temp.ToList();
		}
	}
}
