using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibraryMaintainance
{
	class Student
	{
		private string _name;
		public string Name {
			get => _name;
			private set
			{
				Regex regex = new Regex(@"^[A-Za-z ]+$");
				if (regex.IsMatch(value))
				{
					_name = value;
				}
				else
				{
					Console.WriteLine("Its not valid! /t Please Try again!");
				}
			}
		}

		private int _studentID;
		public int StudentID
		{
			get => _studentID;
			set
			{
				Regex regex = new Regex(@"^[0-9]+$");
				if (regex.IsMatch(value.ToString()))
				{
					_studentID = value;
				}
				else
				{
					Console.WriteLine("Its not valid! /t Please Try again!");
				}
			}
		}

	}
}
