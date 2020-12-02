using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Homework8_AssignmentTracker.Models;

namespace Homework8_AssignmentTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private DBHomework8Context context;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            
        }
        private static List<Assignment> list;
        public IActionResult Index()
        {
            context = new DBHomework8Context();
            List<Tag> taglist = context.Tags.ToList();
            ViewBag.TagList = taglist;
            return View();
        }

        [HttpPost]
        public IActionResult TrackIt(Assignment assign)
        {
            context = new DBHomework8Context();
            if (!ModelState.IsValid)
            {
                ViewBag.Message = "Please enter valid Values";
                return RedirectToAction("Index");
            }

           Assignment checkAssign = context.Assignments.FirstOrDefault(item => item.AssignmentPriority == assign.AssignmentPriority && item.Course.Equals(assign.Course) && item.DueDate == assign.DueDate && item.AssignmentTitle.Equals(assign.AssignmentTitle) && item.AssignmentNotes.Equals(assign.AssignmentNotes));
            if (checkAssign != null)
            {
                ViewBag.Message = "This data already exists!";
                return View("Index");
            }
            assign.IsCompleted = 0;
            context.Assignments.Add(assign);
            context.SaveChanges();
            ViewBag.Message = "Tracking Successful!";
            return View("Index");
        }


        [HttpGet]
        public IActionResult TaskListing(string SearchString)
        {
            context = new DBHomework8Context();
            if (list == null)
            {
                list = context.Assignments.Where(item => item.IsCompleted == 0).ToList();
            }

            return View(list);
        }

        [HttpPost]
        public IActionResult sortbypriority()
        {
            context = new DBHomework8Context();
            List<Assignment> assignlist = context.Assignments.Where(item => item.IsCompleted == 0).ToList();
            list = assignlist.OrderBy(assign => assign.AssignmentPriority).ToList();
            return RedirectToAction("TaskListing");
        }

        [HttpPost]
        public IActionResult sortbyduedate()
        {
            context = new DBHomework8Context();
            List<Assignment> assignlist = context.Assignments.Where(item => item.IsCompleted == 0).ToList();
            list = assignlist.OrderBy(assign => assign.DueDate).ToList();
            return RedirectToAction("TaskListing");
        }

        
        public  IActionResult sortByCourse(string value)
        {
            context = new DBHomework8Context();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("CS461", 1);
            dict.Add("CS465", 2);
            dict.Add("ANTH370", 3);
            dict.Add("MUS102", 4);
            List<Assignment> assignList = new List<Assignment>();
            if (dict[value] == 1)
                assignList = context.Assignments.Where(item => item.Course == Courses.CS461 && item.IsCompleted == 0).ToList();
            if (dict[value] == 2)
                assignList = context.Assignments.Where(item => item.Course == Courses.CS465 && item.IsCompleted == 0).ToList();
            if (dict[value] == 3)
                assignList = context.Assignments.Where(item => item.Course == Courses.ANTH370 && item.IsCompleted == 0).ToList();
            if (dict[value] == 4)
                assignList = context.Assignments.Where(item => item.Course == Courses.MUS102 && item.IsCompleted == 0).ToList();
            list = assignList;
            return RedirectToAction("TaskListing");
        }

        public IActionResult markAsCompleted(int id)
        {
            context = new DBHomework8Context();
            context.Assignments.FirstOrDefault(item => item.AssignmentId == id).IsCompleted = 1;
            context.SaveChanges();
            list = null;
            return RedirectToAction("TaskListing");
            
        }

        public IActionResult AllTaskListing()
        {
            context = new DBHomework8Context();
            list = context.Assignments.ToList();
            return View(list);
        }

        public IActionResult CurrentTaskListing()
        {
            context = new DBHomework8Context();
            list = context.Assignments.Where(item => item.IsCompleted == 0).ToList();
            return RedirectToAction("TaskListing");
        }

        public IActionResult PassedTaskListing()
        {
            context = new DBHomework8Context();
            list = context.Assignments.Where(item => item.IsCompleted == 1).ToList();
            return View(list);
        }


        public IActionResult sortByTags(string SearchString)
        {
            context = new DBHomework8Context();
            List<Assignment> assign = context.Assignments.Where(item => item.AssignmentTags.IndexOf(SearchString) != -1).ToList();
            list = assign;
            return RedirectToAction("TaskListing");
        }

        public IActionResult AddTag(string txtAddTag)
        {
            context = new DBHomework8Context();
            Tag check = context.Tags.FirstOrDefault(item => item.TagName.Equals(txtAddTag));

            if (check != null)
            {
                ViewBag.Message = "Tag already exist. Please directly type it in the tag field";
                return View("Index");
            }
            Tag tag = new Tag()
            {
                TagName = txtAddTag
            };
            context.Tags.Add(tag);
            context.SaveChanges();
            List<Tag> taglist = context.Tags.ToList();
            ViewBag.TagList = taglist;
            return View("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
