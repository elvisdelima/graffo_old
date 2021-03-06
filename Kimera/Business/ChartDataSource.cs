﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Castle.Core;
using DotNet.Highcharts.Options;
using Kimera.Models;
using Kimera.Repositories;
using Manatee.Json;
using Manatee.Trello;
using Manatee.Trello.Json;
using Manatee.Trello.Rest;
using Newtonsoft.Json.Linq;

namespace Kimera.Business
{
    class InnerResponse<T> : IRestResponse<T>
    {
        public string Content { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public T Data { get; set; }
    }

    public class ChartDataResult
    {
        public List<Series> Series;
        public DateTime Date;
        public List<String> Categories;
    }

    public class ChartDataSource
    {
        private AppContext Context { get; set; }
        private Repository<Models.Data> DataRepository { get; set; }
        
        public ChartDataSource()
        {
            Context = new AppContext();
            DataRepository = new Repository<Models.Data>(Context);
        }

        public int? BoardId(string boardId)
        {
            var boards = DataRepository.Query.Where(d => d.DataType == TrelloDataType.Board).AsEnumerable();

            foreach (var b in boards)
            {
                dynamic dynamicBoard = JObject.Parse(b.Json);

                if (dynamicBoard.Id == boardId)
                    return b.Id;
            }

            return null;

        }

        public ChartDataResult AmountOfCardsByListSeries(Trello trello, String boardId)
        {
            var series = new List<Series>();
            var id = DataRepository.Query.Where(d => d.DataType == TrelloDataType.Board).Max(d => d.Id);
            var date = DataRepository.Find(id).Date;

            var lists = DataRepository.Query.Where(d => d.DataType == TrelloDataType.List && d.DataParentId == id);

            foreach (var jsonList in lists)
            {
                dynamic list = JObject.Parse(jsonList.Json);
                var cards = DataRepository.Query.Where(d => d.DataType == TrelloDataType.Card && d.DataParentId == jsonList.Id);

                var data = new object[] { cards.Count() };

                var serie = new Series
                {
                    Name = list.Name,
                    Data = new DotNet.Highcharts.Helpers.Data(data)
                };

                series.Add(serie);
            }

            return new ChartDataResult
            {
                Series = series,
                Date = date
            };
        }

        public ChartDataResult AmountOfCardsFromTheListsByDateSeries(Trello trello, string boardId)
        {
            var series = new List<Series>();
            var importacoes = DataRepository.Query.Where(d => d.DataType == TrelloDataType.Board);

            var categories = importacoes.ToList().Select(i => i.Date.ToShortDateString());

            //TODO: Imverter, se basear primeiro nas listas e depois nas importacoes

            var lists = DataRepository.Query.Where(d => d.DataType == TrelloDataType.List);
                                                       // && importacoes.Select(i => i.Id).Contains(d.DataParentId));

            var listsSeries = new List<Series>();

            var listasJaImportadas = new List<String>(); 

            foreach (var dataList in lists)
            {
                dynamic list = JObject.Parse(dataList.Json);
                
                var quantidades = new List<object>();
                
                foreach (var importacao in importacoes)
                {
                    var listaNessaImportacao =
                        DataRepository.Query.FirstOrDefault(d => d.DataType == TrelloDataType.List && d.DataParentId == importacao.Id && d.TrelloId == dataList.TrelloId);

                    var cards = DataRepository.Query.Where(d => d.DataType == TrelloDataType.Card && d.DataParentId == listaNessaImportacao.Id);
                    
                    quantidades.Add(cards.Count());
                }

                var id = dataList.TrelloId;

                if (listasJaImportadas.Contains(id)) continue;

                listasJaImportadas.Add(id);
                
                listsSeries.Add(new Series{
                    Name = list.Name,
                    Data = new DotNet.Highcharts.Helpers.Data(quantidades.ToArray()),
                });
            }

            var dataResult = new ChartDataResult
            {
                Series = listsSeries,
                Date = DateTime.Now,
                Categories = categories.ToList()
            };
            
            return dataResult;


            /*
                    public static string[] Categories = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
                    public static object[] BerlinData = new object[] { -0.9, 0.6, 3.5, 8.4, 13.5, 17.0, 18.6, 17.9, 14.3, 9.0, 3.9, 1.0 };
                    public static object[] LondonData = new object[] { 3.9, 4.2, 5.7, 8.5, 11.9, 15.2, 17.0, 16.6, 14.2, 10.3, 6.6, 4.8 };
                    public static object[] NewYorkData = new object[] { -0.2, 0.8, 5.7, 11.3, 17.0, 22.0, 24.8, 24.1, 20.1, 14.1, 8.6, 2.5 };
                    public static object[] TokioData = new object[] { 7.0, 6.9, 9.5, 14.5, 18.2, 21.5, 25.2, 26.5, 23.3, 18.3, 13.9, 9.6 };

        
                .SetSeries(new[]
                    {
                        new Series { Name = "Tokyo", Data = new Data(ChartsData.TokioData) },
                        new Series { Name = "New York", Data = new Data(ChartsData.NewYorkData) },
                        new Series { Name = "Berlin", Data = new Data(ChartsData.BerlinData) },
                        new Series { Name = "London", Data = new Data(ChartsData.LondonData) }
                    }
                */

        }
    }
}