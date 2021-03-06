﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kimera.Business;
using Kimera.Models;
using Kimera.Repositories;
using Manatee.Trello;
using Restfulie.Server.Results;

namespace Kimera.Controllers
{
    public partial class TrelloController : Controller
    {
        private AppContext ctx;
        public Repository<Models.Data> repo { get; set; }

        public ActionResult Imports()
        {
            ctx = new AppContext();
            repo = new Repository<Models.Data>(ctx);

            var datas = repo.Query;

            return View(datas.AsEnumerable()); //new OK();
        }

        public void Import()
        {
            ctx = new AppContext();
            repo = new Repository<Models.Data>(ctx);
            
            
            var dataBoards = new Models.Data();
            var dataLists = new Models.Data();
            var dataCards = new Models.Data();

            var trello = new Trello();
            var board = trello.Service.Retrieve<Board>("s7UpK8Ap");

            var Date = DateTime.Now;
            var jsonBoard = trello.Configuration.Serializer.Serialize(board);

            dataBoards.Date = Date;
            dataBoards.Json = jsonBoard;
            dataBoards.DataType = TrelloDataType.Board;
            dataBoards.TrelloId = board.Id;
         
            repo.Add(dataBoards);
            repo.Save();

            foreach (var list in board.Lists)
            {
                var jsonList = trello.Configuration.Serializer.Serialize(list);

                dataLists.Date = Date;
                dataLists.Json = jsonList;
                dataLists.DataType = TrelloDataType.List;
                dataLists.DataParentId = dataBoards.Id;
                dataLists.TrelloId = list.Id;

                repo.Add(dataLists);
                repo.Save();

                foreach (var card in list.Cards)
                {
                    var jsonCard = trello.Configuration.Serializer.Serialize(card);

                    dataCards.Date = Date;
                    dataCards.Json = jsonCard;
                    dataCards.DataType = TrelloDataType.Card;
                    dataCards.DataParentId = dataLists.Id;
                    dataCards.TrelloId = card.Id;

                    repo.Add(dataCards);
                    repo.Save();
                }
            }
         
        }

    }
}
