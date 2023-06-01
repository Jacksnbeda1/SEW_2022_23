using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HUE06Shared;

namespace HUE06Web.Controllers
{
    public class TodoListesController : Controller
    {
        private readonly Hue06Context _context;

        public TodoListesController(Hue06Context context)
        {
            _context = context;
        }

        // GET: TodoListes
        public async Task<IActionResult> Index()
        {
              return _context.TodoListes != null ? 
                          View(await _context.TodoListes.ToListAsync()) :
                          Problem("Entity set 'Hue06Context.TodoListes'  is null.");
        }

        // GET: TodoListes/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.TodoListes == null)
            {
                return NotFound();
            }

            var todoListe = await _context.TodoListes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (todoListe == null)
            {
                return NotFound();
            }

            return View(todoListe);
        }

        // GET: TodoListes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TodoListes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Kurzbeschreibung,Beschreibung,ErstelltAm,Fälligkeitsdatum,Priorität,Status,Id")] TodoListe todoListe)
        {
            if (ModelState.IsValid)
            {
                _context.Add(todoListe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(todoListe);
        }

        // GET: TodoListes/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.TodoListes == null)
            {
                return NotFound();
            }

            var todoListe = await _context.TodoListes.FindAsync(id);
            if (todoListe == null)
            {
                return NotFound();
            }
            return View(todoListe);
        }

        // POST: TodoListes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Kurzbeschreibung,Beschreibung,ErstelltAm,Fälligkeitsdatum,Priorität,Status,Id")] TodoListe todoListe)
        {
            if (id != todoListe.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(todoListe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TodoListeExists(todoListe.Id))
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
            return View(todoListe);
        }

        // GET: TodoListes/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.TodoListes == null)
            {
                return NotFound();
            }

            var todoListe = await _context.TodoListes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (todoListe == null)
            {
                return NotFound();
            }

            return View(todoListe);
        }

        // POST: TodoListes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.TodoListes == null)
            {
                return Problem("Entity set 'Hue06Context.TodoListes'  is null.");
            }
            var todoListe = await _context.TodoListes.FindAsync(id);
            if (todoListe != null)
            {
                _context.TodoListes.Remove(todoListe);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TodoListeExists(long id)
        {
          return (_context.TodoListes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
