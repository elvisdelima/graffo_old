using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DotNet.Highcharts;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Helpers;
using DotNet.Highcharts.Options;
using Kimera.Business;
using Manatee.Trello;

namespace Kimera.Controllers
{
    public partial class HomeController : Controller
    {
        public virtual ActionResult Index()
        {
            var chart = new ChartFactory(ChartType.AmountOfCardsFromTheListsByDate).GetChart();
   
            return View(chart);
        }
    }
}
