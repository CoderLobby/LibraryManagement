using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibraryMaintainance
{
	class Book
	{
		public int Max_Loan_Period { get; set; }
		public string Author { get; private set; }

		public string Title { get; private set; }

		private int _YOP;
		public int YOP
		{
			get =>_YOP;
			private set
			{
				Regex regex = new Regex(@"^[0-9]{4}$");
				if (regex.IsMatch(value.ToString()))
				{
					_YOP = value;
				}
				else
				{
					Console.WriteLine("Error!");
				}
			}
		}

		private bool Issued { get; set; }

		private Student IssuedBy { get; set; }

		public Book(int max_loan_period = 10)
		{
			Max_Loan_Period = max_loan_period;
		}

		// returns the status
		public bool Issue(Student student, int days = 7)
		{
			if (days > Max_Loan_Period)
			{
				Console.WriteLine("The book cant be issued for more than {0} days.", Max_Loan_Period);
				return false;
			}
			else
			{
				if (Issued)
				{
					Console.WriteLine(value: $"Book is already issued by {IssuedBy.Name}");
					return false;
				}
				else
				{
					Issued = true;
					IssuedBy = student;
					Console.WriteLine("Book is now issued to you!");
					return true;
				}
			}
		}

		public bool Return(Student student)
		{
			//will be changed later
			return true;
		}

		private bool IsLate()
		{
			//will be changed later
			return true;
		}


	}
}
