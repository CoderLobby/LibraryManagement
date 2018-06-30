using System.Collections.Generic;

namespace LibraryMaintainance
{
	partial class Library
	{
		public class Shelf: List<Book>
		{
			public string Topic { get; set; }
			public int BookCount { get; set; }


			public Shelf(string topic, int bookCount)
			{
				Topic = topic.Trim();
				BookCount = bookCount;
			}

			public new bool Contains(Book book) => Topic == book.Topic;
		}
	}
}
