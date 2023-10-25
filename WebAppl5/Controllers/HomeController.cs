using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;

namespace WebApp2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult System()
        {
            ViewBag.Message = "Overview";
            return View();
        }

        public ActionResult Database()
        {
            ViewBag.Message = "Database Setup";
            return View();
        }

        public ActionResult Docker()
        {
            return View();
        }

        public ActionResult Kubernetes()
        {
            return View();
        }

        public ActionResult SystemInfo()
        {
            ViewBag.Title = "System";
            ViewBag.Message = "Welcome to the System Info page.";

            // Retrieve system information
            string frameworkDescription = RuntimeInformation.FrameworkDescription;
            string osDescription = RuntimeInformation.OSDescription;
            int processorCount = Environment.ProcessorCount;
            string dotnetRunningInContainer = Environment.GetEnvironmentVariable("DOTNET_RUNNING_IN_CONTAINER");

            ViewBag.FrameworkDescription = frameworkDescription;
            ViewBag.OSDescription = osDescription;
            ViewBag.ProcessorCount = processorCount;
            ViewBag.DotnetRunningInContainer = dotnetRunningInContainer;

            return View();
        }
    }
}