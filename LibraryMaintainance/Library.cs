using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMaintainance
{
	partial class Library
	{
		public Library(List<Shelf> shelves)
		{
			Shelves = shelves;
		}

		public List<Shelf> Shelves { get; set; }
		
	}
}
