using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SalaryBook.Entities;

namespace SalaryBook.Controllers
{
    public class SalaryTypController : Controller
    {
        private readonly MyDbContext _context;

        public SalaryTypController(MyDbContext context)
        {
            _context = context;
        }

        // GET: SalaryTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.salaryTypes.ToListAsync());
        }

        // GET: SalaryTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salaryType = await _context.salaryTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (salaryType == null)
            {
                return NotFound();
            }

            return View(salaryType);
        }

        // GET: SalaryTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SalaryTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TypeCode,TypeName,TypeDec,Id,IsDelete,Remark,AddUser,AddTime,EditUser,EditTime")] SalaryType salaryType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(salaryType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(salaryType);
        }

        // GET: SalaryTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salaryType = await _context.salaryTypes.FindAsync(id);
            if (salaryType == null)
            {
                return NotFound();
            }
            return View(salaryType);
        }

        // POST: SalaryTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TypeCode,TypeName,TypeDec,Id,IsDelete,Remark,AddUser,AddTime,EditUser,EditTime")] SalaryType salaryType)
        {
            if (id != salaryType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(salaryType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SalaryTypeExists(salaryType.Id))
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
            return View(salaryType);
        }

        // GET: SalaryTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salaryType = await _context.salaryTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (salaryType == null)
            {
                return NotFound();
            }

            return View(salaryType);
        }

        // POST: SalaryTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var salaryType = await _context.salaryTypes.FindAsync(id);
            _context.salaryTypes.Remove(salaryType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SalaryTypeExists(int id)
        {
            return _context.salaryTypes.Any(e => e.Id == id);
        }
    }
}
