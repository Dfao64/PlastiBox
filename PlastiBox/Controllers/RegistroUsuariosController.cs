using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PlastiBox.Models;

namespace PlastiBox.Controllers
{
    public class RegistroUsuariosController : Controller
    {
        private readonly PlastiContext _context;

        public RegistroUsuariosController(PlastiContext context)
        {
            _context = context;
        }

        // GET: RegistroUsuarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.RegistroUsuarios.ToListAsync());
        }

        // GET: RegistroUsuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registroUsuario = await _context.RegistroUsuarios
                .FirstOrDefaultAsync(m => m.IdUsuario == id);
            if (registroUsuario == null)
            {
                return NotFound();
            }

            return View(registroUsuario);
        }

        // GET: RegistroUsuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RegistroUsuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdUsuario,Nombre,Apellido,Telefono,Correo,Contrasena")] RegistroUsuario registroUsuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registroUsuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(registroUsuario);
        }

        // GET: RegistroUsuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registroUsuario = await _context.RegistroUsuarios.FindAsync(id);
            if (registroUsuario == null)
            {
                return NotFound();
            }
            return View(registroUsuario);
        }

        // POST: RegistroUsuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdUsuario,Nombre,Apellido,Telefono,Correo,Contrasena")] RegistroUsuario registroUsuario)
        {
            if (id != registroUsuario.IdUsuario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registroUsuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegistroUsuarioExists(registroUsuario.IdUsuario))
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
            return View(registroUsuario);
        }

        // GET: RegistroUsuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registroUsuario = await _context.RegistroUsuarios
                .FirstOrDefaultAsync(m => m.IdUsuario == id);
            if (registroUsuario == null)
            {
                return NotFound();
            }

            return View(registroUsuario);
        }

        // POST: RegistroUsuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var registroUsuario = await _context.RegistroUsuarios.FindAsync(id);
            if (registroUsuario != null)
            {
                _context.RegistroUsuarios.Remove(registroUsuario);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegistroUsuarioExists(int id)
        {
            return _context.RegistroUsuarios.Any(e => e.IdUsuario == id);
        }
    }
}
