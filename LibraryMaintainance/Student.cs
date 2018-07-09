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
		// NOTE: Apply a loop check before sending in data.
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
					_name = "DEFAULT";
					Console.WriteLine("Its not valid! /t Please Try again!");
				}
			}
		}
		// NOTE: Apply a loop check before sending in data.
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

		public Student(string name, int studentID)
		{
			Name = name;
			StudentID = studentID;
		}
	}
}
