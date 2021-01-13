using Application.ViewModel;
using Core.Entity;
using Data.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Application.Controllers
{
    public class EmployeesController : Controller
    {
        public readonly int PAGE_SIZE = 10;

        private SATContext context;
        public EmployeesController(SATContext context)
        {
            this.context = context;
        }

        // GET: EmployeeController
        public ActionResult Index(string? Search, int PageNumber = 1)
        {

            IEnumerable<EmployeeViewModel> data = context.Employees
                .Where(e => e.FirstName.Contains(Search) || e.LastName.Contains(Search))
                .Skip(PAGE_SIZE * (PageNumber - 1))
                .Take(PAGE_SIZE)
                .Include(e => e.Branch)
                .Include(e => e.Department)
                .AsEnumerable()
                .Select(e => EmployeeToViewModel(e));

            return View(data);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public EmployeeViewModel EmployeeToViewModel(Employee entity)
        {
            EmployeeViewModel model = new EmployeeViewModel();

            model.EmployeeId = entity.EmployeeId;
            model.BranchId = entity.Branch.BranchId;
            model.CelPhone = entity.CelPhone;
            model.DepartmentId = entity.Department.DepartmentId;
            model.Email = entity.Email;
            model.FirstName = entity.FirstName;
            model.Gender = entity.Gender;
            model.IsActive = entity.IsActive;
            model.LastName = entity.LastName;
            model.Phone = entity.Phone;
            model.PhoneExtension = entity.PhoneExtension;

            return model;
        }
    }
}
