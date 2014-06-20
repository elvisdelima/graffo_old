using System;
using System.Collections.Generic;
using DotNet.Highcharts;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Options;

namespace Kimera.Business
{
    public class HighchartsFactory
    {
        public HighchartsFactory()
        {
        }

        public Highcharts AmountOfCardsByListChart(List<Series> listas, DateTime category)
        {
            return new Highcharts("chart")
                .InitChart(new Chart { Type = ChartTypes.Column })
                .SetTitle(new Title { Text = "Quantidade de Cartões por Lista"})
                .SetYAxis(new YAxis
                {
                    Title = new YAxisTitle { Text = "Qtd." }
                })
                .SetXAxis(new XAxis
                {
                    Categories = new[] { category.ToShortDateString() }
                })
                .SetSeries(listas.ToArray());
        }


        public Highcharts AmountOfCardsFromTheListsByDateChart(List<Series> listas, DateTime categories)
        {
            //var dates = categories

            return new Highcharts("chart")
                .InitChart(new Chart { Type = ChartTypes.Column })
                .SetTitle(new Title { Text = "Quantidade de Cartões das Listas por Data" })
                .SetYAxis(new YAxis
                {
                    Title = new YAxisTitle { Text = "Qtd." }
                })
                /*.SetXAxis(new XAxis
                {
                    Categories = new[] { category.ToShortDateString() }
                })*/
                .SetSeries(listas.ToArray());
        }
    }
}