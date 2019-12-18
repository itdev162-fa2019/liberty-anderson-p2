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

		// GET api/posts
		[HttpGet]
		public ActionResult<List<Expense>> Get()
		{
			return this.context.Expenses.ToList();
		}
	}
}