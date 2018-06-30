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
		// per day
		public decimal LatePenalty { get; set; }

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

		private DateTime IssuedOn { get; set; }

		private bool Issued { get; set; }

		private Student IssuedBy { get; set; }
		public string Topic { get; set; }

		public Book(string title,
			int yop, 
			string topic,
			string author = "Anonymus", 
			int max_loan_period = 10, 
			decimal latePenalty = 1.0m)
		{
			Title = title;
			YOP = yop;
			Author = author;
			Topic = topic.Trim();
			LatePenalty = latePenalty;
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
					IssuedOn = DateTime.Now;
					Console.WriteLine("Book is now issued to you!");
					return true;
				}
			}
		}

		public bool Return(Student student)
		{
			if (student.StudentID == IssuedBy.StudentID)
			{
				if (IsLate())
				{
					// TODO: check if works;
					int days = int.Parse((DateTime.Now - IssuedOn).TotalDays.ToString()) - Max_Loan_Period;
					decimal Penalty = ApplyPenalty(days);
					Console.WriteLine($"The late penalty of {Penalty:C} is applied and please pay your charges.");
					Console.WriteLine("Please enter your std id and the amount will be deduucted from your library card: ");
					// Do something;
					Console.ReadLine();
					Issued = false;
					IssuedBy = null;
					return true;
				}
				else
				{
					Issued = false;
					IssuedBy = null;
					Console.WriteLine("The book has been returned");
					return true;
				}
			}
			else
			{
				Console.WriteLine("You didn't borrow this book! So you can not return it.");
				return false;
			}

		}

		private decimal ApplyPenalty(int days)
		{
			return days * LatePenalty;
		}

		private bool IsLate()
		{
			if ((DateTime.Now - IssuedOn).TotalDays > Max_Loan_Period)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


	}
}
