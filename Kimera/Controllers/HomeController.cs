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
            
            var trello = new Trello();
            const string boardId = "s7UpK8Ap";

            var board = trello.Service.Retrieve<Board>(boardId);
            
            var listas = new List<Series>();
            foreach (var list in board.Lists)
            {
                listas.Add(new Series { Name = list.Name, Data = new DotNet.Highcharts.Helpers.Data(new object[] { list.Cards.Count() }) });
            }
            
            /*
            var listas = new List<Series>();
            listas.Add(new Series { Name = "testes 1", Data = new DotNet.Highcharts.Helpers.Data(new object[] { 7 }) });
            listas.Add(new Series { Name = "testes 2", Data = new DotNet.Highcharts.Helpers.Data(new object[] { 4 }) });
            listas.Add(new Series { Name = "testes 3", Data = new DotNet.Highcharts.Helpers.Data(new object[] { 10 }) });
            listas.Add(new Series { Name = "testes 4", Data = new DotNet.Highcharts.Helpers.Data(new object[] { 9 }) });
            listas.Add(new Series { Name = "testes 5", Data = new DotNet.Highcharts.Helpers.Data(new object[] { 8 }) });
            listas.Add(new Series { Name = "testes 6", Data = new DotNet.Highcharts.Helpers.Data(new object[] { 15 }) });
            listas.Add(new Series { Name = "testes 7", Data = new DotNet.Highcharts.Helpers.Data(new object[] { 10 }) });
            listas.Add(new Series { Name = "testes 8", Data = new DotNet.Highcharts.Helpers.Data(new object[] { 4 }) });
            */

            var chart = new Highcharts("chart")
                .InitChart(new Chart { Type = ChartTypes.Column })
                .SetTitle(new Title { Text = "Quantidade de Cartões por Lista"})
                .SetYAxis(new YAxis
                {
                    Title = new YAxisTitle { Text = "Qtd." }
                })
                .SetXAxis(new XAxis
                {
                    Categories = new[] { DateTime.Now.ToShortDateString() }
                })
                .SetSeries(listas.ToArray());

            return View(chart);
        }


        //Todas as colunas do quadro Nash
        //https://api.trello.com/1/boards/s7UpK8Ap?lists=open&list_fields=name&fields=name,desc&key=67bd83087dc827f6821ab0ae5dd0c625&token=8a0ff7249c98a8300dc627c9824b527e6c47deda80e820a563c21e9b12fc8b08

        //Todos os cartões de uma coluna
        //https://api.trello.com/1/lists/52f225f4991a23ff20150af1?fields=name&cards=open&card_fields=name&key=67bd83087dc827f6821ab0ae5dd0c625&token=8a0ff7249c98a8300dc627c9824b527e6c47deda80e820a563c21e9b12fc8b08


    }
}
