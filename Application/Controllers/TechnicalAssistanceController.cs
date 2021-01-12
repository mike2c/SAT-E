using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Data.Data;
using Core.Entity;
using System.Security.Claims;
using Application.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace Application.Controllers
{
    [Authorize]
    public class TechnicalAssistanceController : TaskController
    {
        public TechnicalAssistanceController(SATContext context): base(context) { }

        public override IActionResult Index(string? Order, string? Search, int PageNumber = 1)
        {

            ViewBag.CurrentSearch = Search;

            //if (HttpContext.Request.Query.ContainsKey("Index"))
            //    searchString = HttpContext.Request.Query.Where(r => r.Key == "Index").First().Value;

            //if (HttpContext.Request.Query.ContainsKey("SearchString"))
            //    searchString = HttpContext.Request.Query.Where(r => r.Key == "SearchString").First().Value;

            //if (HttpContext.Request.Query.ContainsKey("AssignedTo"))
            //    assignedToId = Int32.Parse(HttpContext.Request.Query.Where(v => v.Key == "AssignedTo").First().Value);

            //if (HttpContext.Request.Query.ContainsKey("State"))
            //{
            //    Microsoft.Extensions.Primitives.StringValues value = HttpContext.Request.Query.Where(v => v.Key == "State").First().Value;
            //    if (!String.IsNullOrEmpty(value))
            //    {
            //        state = Int32.Parse(value);
            //    }
            //}

            IEnumerable<TechnicalAssistanceViewModel> data;
            if (!string.IsNullOrEmpty(Search))
            {
                data = context.TechnicalAssistance
                    .Where(t => t.TaskName.Contains(Search))
                    .Skip((PageNumber - 1) * PAGE_SIZE)
                    .Take(PAGE_SIZE)
                    .Include(t => t.ProblemType)
                    .Include(t => t.AssignedBy)
                    .Include(t => t.AssignedTo)
                    .Include(t => t.AttendedBy)
                    .OrderByDescending(t => t.TaskDate)
                    .AsEnumerable()
                    .Select(t => TaskToViewModel(t));
            }
            else
            {
                data = context.TechnicalAssistance
                    .Skip((PageNumber - 1) * PAGE_SIZE)
                    .Take(PAGE_SIZE)
                    .Include(t => t.ProblemType)
                    .Include(t => t.AssignedBy)
                    .Include(t => t.AssignedTo)
                    .Include(t => t.AttendedBy)
                    .OrderByDescending(t => t.TaskDate)
                    .AsEnumerable()
                    .Select(t => TaskToViewModel(t));
            }

            return View(data);
        }

        public IActionResult Create()
        {
            ViewBag.ProblemTypes = context.ProblemTypes.AsEnumerable();
            ViewBag.Users = context.Users.AsEnumerable();
            ViewBag.Sources = context.Source.AsEnumerable();
            return View();
        }

        [HttpPost]
        public IActionResult Create(TechnicalAssistanceViewModel data)
        {
            if (ModelState.IsValid)
            {
                Claim claim = HttpContext
                    .User
                    .Claims
                    .Where(c => c.Type == ClaimTypes.Sid)
                    .FirstOrDefault();
                
                User attendedBy = context.Users.Find(Int32.Parse(claim.Value));
                Source source = context.Source.Find(data.SourceId);

                TechnicalAssistance task = new TechnicalAssistance();

                task.Source = source;
                task.TaskName = data.TaskName;
                task.ProblemTypeId = data.ProblemTypeId;
                task.AttendedBy = attendedBy;
                task.State = data.State;
                task.TaskDate = DateTime.Now;
                task.StartDate = null;
                task.EndDate = null;
                task.TaskType = TaskType.AsistenciaTecnica;
                
                if(data. AssignedToUserId != null && data. AssignedToUserId > 0)
                {
                    task.AssignedTo = context.Users.Find(data. AssignedToUserId);
                    task.AssignedBy = attendedBy;
                }

                context.TechnicalAssistance.Add(task);
                context.SaveChanges();
                RedirectToAction("Index", "TechnicalAssistance");
            }


            ViewBag.Sources = context.Source.AsEnumerable();
            ViewBag.ProblemTypes = context.ProblemTypes.AsEnumerable();
            ViewBag.Users = context.Users.AsEnumerable();
            return View(data);
        }

        public IActionResult Delete(int taskId)
        {
            TechnicalAssistance task = context.TechnicalAssistance.Find(taskId);

            if(task.State == State.Deleted)
            {
                context.TechnicalAssistance.Remove(task);
            }
            else
            {
                task.State = State.Deleted;
                context.TechnicalAssistance.Update(task);
            }
            
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public override IActionResult Details(int Id)
        {
            TechnicalAssistance task = context
                .TechnicalAssistance
                .Where(t => t.TaskId == Id)
                .Include(t => t.ProblemType)
                .Include(t => t.AssignedBy)
                .Include(t => t.AssignedTo)
                .Include(t => t.AttendedBy)
                .FirstOrDefault();

            TechnicalAssistanceViewModel data = TaskToViewModel(task);          

            if(task.AssignedTo != null)
                ViewBag.AssignedToName = task.AssignedTo.Username;
                
            if(task.AssignedBy != null)
                ViewBag.AssignedByName = task.AssignedBy.Username;

            if(task.AttendedBy != null)
                ViewBag.AttendedByName = task.AttendedBy.Username;

            if(data.ProblemTypeId != null)
                ViewBag.ProblemName = context.ProblemTypes.Find(data.ProblemTypeId).ProblemName;

            return View(data);
        }

        private TechnicalAssistanceViewModel TaskToViewModel(TechnicalAssistance task)
        {
            TechnicalAssistanceViewModel viewModel = new TechnicalAssistanceViewModel();         

            if(task.AssignedBy != null)
                viewModel.AssignedByUserId = task.AssignedBy.UserId;

            if (task.AssignedTo != null)
                viewModel. AssignedToUserId = task.AssignedTo.UserId;

            if (task.AttendedBy != null)
                viewModel.AttendedByUserId = task.AttendedBy.UserId;

            if(task.Employee != null)
                viewModel.EmployeeId = task.Employee.EmployeeId;

            viewModel.EndDate = task.EndDate;
            viewModel.EstimatedTime = task.EstimatedTime;
            viewModel.ActualTime = task.ActualTime;
            viewModel.Priority = task.Priority;
            
            if (task.ProblemTypeId != null)
                viewModel.ProblemTypeId = task.ProblemTypeId;
            
            if (task.Source != null)
                viewModel.SourceId = task.Source.SourceId;

            viewModel.StartDate = task.StartDate;
            viewModel.State = task.State;
            viewModel.TaskDate = task.TaskDate;
            viewModel.TaskId = task.TaskId;
            viewModel.TaskName = task.TaskName;
            viewModel.TaskType = task.TaskType;

            return viewModel;
        }

    }    
}
