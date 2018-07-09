using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LibraryMaintainance
{
	class Library
	{
		
		public List<Shelf> Shelves { get; set; }

		Library(List<Shelf> shelves, List<Student> students)
		{
			Shelves = shelves;
			Students = students;
		}

		public List<Student> Students { get; set; }

		public Library Load()
		{
			string path = System.AppDomain.CurrentDomain.BaseDirectory + "library_store.json";
		}

		public void Save()
		{

		}
	}
}
