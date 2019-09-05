using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCLab1_AddingAController.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "Neo...the Matrix has you...";
        }
    }
}