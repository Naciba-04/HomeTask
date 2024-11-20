using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Todos.Controllers
{
    public class TodoController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using (Ab108todosContext _context = new Ab108todosContext())
            {
                return View(await _context.Todos.ToListAsync());
            }

        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Todo data)
        {
            data.IsDone = false;
            using (Ab108todosContext context = new())
            {
                await context.Todos.AddAsync(data);
                await context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

    }
}
