using System.Collections.Generic;
using System.Linq;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Persistence;

namespace API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ExpensesController : ControllerBase
	{
		private readonly DataContext context;

		public ExpensesController(DataContext context)
		{
			this.context = context;
		}

		/// <summary>
		///  GET api/expenses
		/// </summary>
		/// <returns>a list of expenses</returns>
		[HttpGet]
		public ActionResult<List<Expense>> Get()
		{
			return this.context.Expenses.ToList();
		}

		/// <summary>
		/// POST api/expense
		///</summary>
		///<param name="request">JSON reqest containing expense fields</param>
		///<returns>a new expense</returns>
		[HttpPost]
		public ActionResult<Expense> Create([FromBody]Expense request)
		{
			var expense = new Expense
			{
				ID = request.ID,
				Category = request.Category,
				Amount = request.Amount,
				Date = request.Date
			};

			context.Expenses.Add(expense); //does seed data have to be manually deleted?
			var success = context.SaveChanges() > 0;

			if (success){
				return expense;
			}

			throw new System.Exception("Error creating post");
		}
	}
}