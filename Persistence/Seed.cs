using System;
using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Persistence
{
	public class Seed
	{
		public static void SeedData(DataContext context)
		{
			if (!context.Expenses.Any())
			{
				var Expenses = new List<Expense>
				{
					new Expense {
						Category = "Entertainment", 
						Amount = 25.32m, 
						Date = DateTime.Now
					},
					new Expense {
						Category = "Food", 
						Amount = 78.65m, 
						Date = DateTime.Now
					},
					new Expense {
						Category = "Bills", 
						Amount = 152.26m, 
						Date = DateTime.Now
					}
				};

				context.Expenses.AddRange(Expenses);
				context.SaveChanges();
			}
		}
	}
}