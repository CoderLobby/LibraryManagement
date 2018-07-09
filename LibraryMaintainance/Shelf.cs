using System.Collections.Generic;
using System.Linq;

namespace LibraryMaintainance
{
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
