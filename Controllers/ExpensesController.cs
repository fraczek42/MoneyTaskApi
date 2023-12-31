﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoneyTaskApi;
using MoneyTaskApi.Model;
using System.Threading.Tasks;

namespace MoneyTaskApi.Controllers
{
    [ApiController]
    [Route("/expenses/")]
    public class ExpensesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ExpensesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("getExpenses")]
        public async Task<IActionResult> GetExpenses()
        {
            var expenses = await _context.ExpensesUser
                .Select(e => new
                {
                    Id = e.Id,
                    Description = e.Description,
                    Amount = e.Amount,
                    ExpenseDate = e.ExpenseDate
                })
                .ToListAsync();

            return Ok(expenses);
        }



        [HttpGet("isAlive")]
        public IActionResult IsAlive()
        {
            return Ok("API is alive and running");
        }
    }
}

