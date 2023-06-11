using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using todoShared;

namespace HUE06Web.Controllers
{
    public class TodoesController : Controller
    {
        private readonly TodoContext _context;

        public TodoesController(TodoContext context)
        {
            _context = context;
        }

        // GET: Todoes
        public async Task<IActionResult> Index()
        {
            var todoContext = _context.Todos.Include(t => t.PrioritätNavigation).Include(t => t.StatusNavigation);
            return View(await todoContext.ToListAsync());
        }

        // GET: Todoes/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.Todos == null)
            {
                return NotFound();
            }

            var todo = await _context.Todos
                .Include(t => t.PrioritätNavigation)
                .Include(t => t.StatusNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (todo == null)
            {
                return NotFound();
            }

            return View(todo);
        }

        // GET: Todoes/Create
        public IActionResult Create()
        {
            ViewData["Priorität"] = new SelectList(_context.Prioritäts, "Id", "Id");
            ViewData["Status"] = new SelectList(_context.Statuses, "Id", "Id");
            return View();
        }

        // POST: Todoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Kurzbeschreibung,Beschreibung,ErstelltAm,Fälligkeitsdatum,Priorität,Status,Id")] Todo todo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(todo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Priorität"] = new SelectList(_context.Prioritäts, "Id", "Id", todo.Priorität);
            ViewData["Status"] = new SelectList(_context.Statuses, "Id", "Id", todo.Status);
            return View(todo);
        }

        // GET: Todoes/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.Todos == null)
            {
                return NotFound();
            }

            var todo = await _context.Todos.FindAsync(id);
            if (todo == null)
            {
                return NotFound();
            }
            ViewData["Priorität"] = new SelectList(_context.Prioritäts, "Id", "Id", todo.Priorität);
            ViewData["Status"] = new SelectList(_context.Statuses, "Id", "Id", todo.Status);
            return View(todo);
        }

        // POST: Todoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Kurzbeschreibung,Beschreibung,ErstelltAm,Fälligkeitsdatum,Priorität,Status,Id")] Todo todo)
        {
            if (id != todo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(todo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TodoExists(todo.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Priorität"] = new SelectList(_context.Prioritäts, "Id", "Id", todo.Priorität);
            ViewData["Status"] = new SelectList(_context.Statuses, "Id", "Id", todo.Status);
            return View(todo);
        }

        // GET: Todoes/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.Todos == null)
            {
                return NotFound();
            }

            var todo = await _context.Todos
                .Include(t => t.PrioritätNavigation)
                .Include(t => t.StatusNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (todo == null)
            {
                return NotFound();
            }

            return View(todo);
        }

        // POST: Todoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.Todos == null)
            {
                return Problem("Entity set 'TodoContext.Todos'  is null.");
            }
            var todo = await _context.Todos.FindAsync(id);
            if (todo != null)
            {
                _context.Todos.Remove(todo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TodoExists(long id)
        {
          return (_context.Todos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
