using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotNet.Highcharts;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Options;
using Manatee.Trello;

namespace Kimera.Business
{
    public class ChartFactory
    {
        private readonly ChartDataSource _chartDataSource;
        private readonly HighchartsFactory _highchartsFactory;
        private Highcharts Chart { get; set; }

        public Highcharts GetChart()
        {
            return Chart;
        }

        public ChartFactory(ChartType chartType)
        {
            Chart = new Highcharts(chartType.ToString());

            var trello = new Trello();
            const string boardId = "s7UpK8Ap";

            var chartDataSource = new ChartDataSource();
            var highchartsFactory = new HighchartsFactory();

            switch (chartType)
            {
                case ChartType.AmountOfCardsByList:
                {
                    var result = chartDataSource.AmountOfCardsByListSeries(trello, boardId);
                    Chart = highchartsFactory.AmountOfCardsByListChart(result.Series, result.Date);
                    break;
                }
                case ChartType.AmountOfCardsFromTheListsByDate:
                {
                    var result = chartDataSource.AmountOfCardsFromTheListsByDateSeries(trello, boardId);
                    Chart = highchartsFactory.AmountOfCardsFromTheListsByDateChart(result.Series, result.Categories);
                    break;
                }
 
            }
        }
    }
}