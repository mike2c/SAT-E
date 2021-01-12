using Core.Entity;
using Data.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application.Controllers
{
    public abstract class TaskController : Controller
    {        
        public static int PAGE_SIZE = 10;

        //protected IMemoryCache cache;

        protected SATContext context;
        public TaskController(SATContext context)
        {
            this.context = context;
        }

        [Authorize]
        [HttpPost]
        public IActionResult ChangeTaskState(int taskId, State State, float ? EstimatedTime)
        {
            Task task = context.Tasks.Find(taskId);

            switch (State)
            {
                case State.Iniciada:
                    task.State = State.Iniciada;
                    task.StartDate = DateTime.Now;

                    if(EstimatedTime != null)
                        task.EstimatedTime = (float)EstimatedTime;

                    break;
                case State.Finalizada:

                    task.EndDate = DateTime.Now;
                    TimeSpan diff = (task.EndDate - task.StartDate).Value;
                    task.State = State.Finalizada;
                    task.ActualTime = diff.Hours;
                    break;
                case State.Detenida:
                    task.State = State.Detenida;
                    break;
                case State.Cancelada:
                    task.State = State.Cancelada;
                    break;
            }

            context.Update(task);
            context.SaveChanges();
            return RedirectToAction("Details", new { Id = taskId});
        }

        [Authorize]
        [HttpPost]
        public IActionResult StartTask(int taskId, float EstimatedTime)
        {
            Task task = context.Tasks.Find(taskId);
            task.State = State.Iniciada;
            task.EstimatedTime = EstimatedTime;
            task.StartDate = DateTime.Now;
            context.Update(task);
            context.SaveChanges();

            return RedirectToAction("Details", new { Id = task.TaskId });
        }

        [Authorize]
        [HttpPost]
        public IActionResult FinalizeTask(int taskId)
        {
            Task task = context.Tasks.Find(taskId);
            task.EndDate = DateTime.Now;
            TimeSpan diff = (task.EndDate - task.StartDate).Value;
            task.ActualTime = diff.Hours;
            context.SaveChanges();

            return RedirectToAction("Details");
        }

        public abstract IActionResult Index(string ? Order, string ? Search, int PageNumber = 1);
        public abstract IActionResult Details(int taskId);
    }
}
