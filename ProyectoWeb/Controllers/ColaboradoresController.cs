using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoWeb.Models;

namespace ProyectoWeb.Controllers
{
    public class ColaboradoresController : Controller
    {
        private readonly ProyectoWebContext _context;

        public ColaboradoresController(ProyectoWebContext context)
        {
            _context = context;
        }

        // GET: Colaboradors
        public async Task<IActionResult> Index()
        {
              return _context.Colaborador != null ? 
                          View(await _context.Colaborador.ToListAsync()) :
                          Problem("Entity set 'ProyectoWebContext.Colaborador'  is null.");
        }

        // GET: Colaboradors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Colaborador == null)
            {
                return NotFound();
            }

            var colaborador = await _context.Colaborador
                .FirstOrDefaultAsync(m => m.Id == id);
            if (colaborador == null)
            {
                return NotFound();
            }

            return View(colaborador);
        }

        // GET: Colaboradors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Colaboradors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Cedula_colaborador,Nombre_colaborador,Apellidos_colaborador,Correo_colaborador,Contrasena_colaborador,Telefono_colaborador,Direccion_colaborador,Salario_colaborador")] Colaborador colaborador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(colaborador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(colaborador);
        }

        // GET: Colaboradors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Colaborador == null)
            {
                return NotFound();
            }

            var colaborador = await _context.Colaborador.FindAsync(id);
            if (colaborador == null)
            {
                return NotFound();
            }
            return View(colaborador);
        }

        // POST: Colaboradors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Cedula_colaborador,Nombre_colaborador,Apellidos_colaborador,Correo_colaborador,Contrasena_colaborador,Telefono_colaborador,Direccion_colaborador,Salario_colaborador")] Colaborador colaborador)
        {
            if (id != colaborador.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(colaborador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ColaboradorExists(colaborador.Id))
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
            return View(colaborador);
        }

        // GET: Colaboradors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Colaborador == null)
            {
                return NotFound();
            }

            var colaborador = await _context.Colaborador
                .FirstOrDefaultAsync(m => m.Id == id);
            if (colaborador == null)
            {
                return NotFound();
            }

            return View(colaborador);
        }

        // POST: Colaboradors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Colaborador == null)
            {
                return Problem("Entity set 'ProyectoWebContext.Colaborador'  is null.");
            }
            var colaborador = await _context.Colaborador.FindAsync(id);
            if (colaborador != null)
            {
                _context.Colaborador.Remove(colaborador);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ColaboradorExists(int id)
        {
          return (_context.Colaborador?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
