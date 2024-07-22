using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManagerProject.Models;


namespace TaskManagerProject.Controllers
{
    [Authorize(Policy = "AdminOnly")]
    [ApiController]
    [Route("api/[controller]")]
    public class ReportsController : ControllerBase
    {
        private readonly TaskManagementContext _context;
        public ReportsController(TaskManagementContext context)
        {
            _context = context;
        }
        [HttpGet("weekly")]
        public async Task<ActionResult<IEnumerable<TaskManagementSystem.Task>>> GetWeeklyReport()
        {
            var oneWeekAgo = DateTime.Now.AddDays(-7);
            var tasks = await _context.Tasks
                .Where(t => t.DueDate >= oneWeekAgo && t.IsCompleted)
                .ToListAsync();
            return tasks;
        }
        [HttpGet("monthly")]
        public async Task<ActionResult<IEnumerable<TaskManagementSystem.Task>>> GetMonthlyReport()
        {
            var oneMonthAgo = DateTime.Now.AddMonths(-1);
            var tasks = await _context.Tasks
                .Where(t => t.DueDate >= oneMonthAgo && t.IsCompleted)
                .ToListAsync();
            return tasks;
        }
    }
}
