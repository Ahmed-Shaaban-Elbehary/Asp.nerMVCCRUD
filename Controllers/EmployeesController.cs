using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Asp.nerMVCCRUD.Models;

namespace Asp.nerMVCCRUD.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly DbContainer _context;

        public EmployeesController(DbContainer context)
        {
            _context = context;
        }

        // GET: Employees
        public async Task<IActionResult> Index()
        {
            return View(await _context.Employees.ToListAsync());
        }


        // GET: Employees/Create
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
            {
                return View(new Employee());
            }
            else
            {
                if (EmployeeExists(id))
                {
                    return View(_context.Employees.Find(id));
                }
                else
                {
                    return View("The Employee Id Not Found !");
                }

            }
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("Id,FullName,Emp_Code,Postion,OfficeLocation")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                if (employee.Id == 0)
                {
                    _context.Add(employee);
                }
                else
                {
                    _context.Update(employee);
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            Employee employee = await _context.Employees.FindAsync(id);

            _context.Remove(employee);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.Id == id);
        }
    }
}
