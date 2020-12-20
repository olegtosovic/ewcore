﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Dbo;
using Orko.AspNetCore.Models;
using Orko.EntityWorks;
using Orko.EntityWorks.Generator;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using System.Transactions;

namespace Orko.AspNetCore.Controllers
{
	/// <summary>
	/// EntityWorks test controller.
	/// </summary>
	public class TestController : Controller
	{
		#region Constructrors
		/// <summary>
		/// Creates instance of test controller.
		/// </summary>
		public TestController()
		{

		}
		#endregion

		#region Entity mapping actions
		/// <summary>
		/// Database read test.
		/// </summary>
		//[HttpGet("/test-orko-save")]
		//public async Task<IActionResult> TestDbOrko1()
		//{
		//	// Use transaction that wont commit.
		//	using (TransactionScope transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
		//	{
		//		// SELECT + UPDATE + SAVE.
		//		var drzava = await Drzava.GetByPrimaryKeyAsync("HR");
		//		drzava.DrzavaNaziv = drzava.DrzavaNaziv + "_s";
		//		await drzava.SaveAsync();

		//		// CREATE + SAVE.
		//		var drzava2 = new Drzava();
		//		drzava2.DrzavaDrzava = "XX";
		//		drzava2.DrzavaKod = "KOD";
		//		drzava2.DrzavaTroslovnaKratica = "TRK";
		//		drzava2.DrzavaValuta = "HRK";
		//		drzava2.DrzavaNaziv = "Testna država";
		//		await drzava2.SaveAsync();				

		//		// Convert data to json.
		//		var jsonResult = JsonSerializer.Serialize(drzava2, null);

		//		// Display json data.
		//		return Content(jsonResult, "application/json");
		//	}
		//}

		/// <summary>
		/// Database read test.
		/// </summary>
		//[HttpGet("/test-context")]
		//public async Task<IActionResult> TestDbOrko()
		//{
		//	// Get data.
		//	var result = "";

		//	// Convert data to json.
		//	var jsonResult = JsonSerializer.Serialize(result, null);

		//	// Display json data.
		//	return Content(jsonResult, "application/json");
		//}

		/// <summary>
		/// Database read test.
		/// </summary>
		[HttpGet("/test-orko")]
		public async Task<IActionResult> TestEntityContext()
		{
			// Use specific query context, instead of ambient.
			//using (var context = new QueryContext("Orko"))
			//{
			// Simple query.
			var query = new Query();

			// Select.
			query.Select("Drzava.DrzavaDrzava", "TwoLetterCode");
			query.Select("Drzava.DrzavaTroslovnaKratica", "ThreeLetterCode");
			query.Select("Drzava.DrzavaKod", "Code");
			query.Select("DrzavaNaziv", "Name");
			query.From("Base.Drzava");

			// Join language table.
			query.Join("Base.Drzava_jezik AS jezik",
				new QueryCondition("jezik.DrzavaDrzava", QueryOp.Equal, "Drzava.DrzavaDrzava"),
				new QueryCondition("jezik.DrzavaJezik", QueryOp.Equal, Query.Quote("HR")));

			// Get data.
			var result = await query.GetObjectCollectionAsync<Country>();

			// Convert data to json.
			var jsonResult = JsonSerializer.Serialize(result, null);

			// Display json data.
			return Content(jsonResult, "application/json");
			//}
		}

		// Database read test.
		[HttpGet("/test-northwind")]
		public async Task<IActionResult> TestDbNorthwind1()
		{
			// Use northwind.
			using (var context = new QueryContext("Northwind"))
			{
				// Get data.
				var result = await OrderDetails.GetByAnyAsync();

				// Convert data to json.
				var jsonResult = JsonSerializer.Serialize<IEnumerable<OrderDetails>>(result, null);

				// Display json data.
				return Content(jsonResult, "application/json");
			}
		}
		#endregion

		#region Entity generator test actions
		/// <summary>
		/// Database generator test.
		/// </summary>
		[HttpGet("/generate")]
		public async Task<IActionResult> TestEntityWorksGenerator()
		{
			// Get generator instance. Could be done via constructor injection but it not important.
			var entityWorksGenerator = this.HttpContext.RequestServices.GetService<EntityWorksGenerator>();

			// Generate domain and logic classes.
			await entityWorksGenerator.GenerateAllAsync();

			// Return OK.
			return Content("OK");
		}
		#endregion
	}
}
