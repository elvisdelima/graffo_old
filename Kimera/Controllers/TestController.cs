using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Kimera.Business;
using Kimera.Models;
using Kimera.Repositories;
using Manatee.Trello;
using RestSharp;

namespace Kimera.Controllers
{
    public partial class TestController : Controller
    {
        public virtual ActionResult Index()
        {
            //var dataOrganization = new Models.Data();
            var dataBoards = new Models.Data();
            var dataLists = new Models.Data();
            var dataCards = new Models.Data();
            
            var trello = new Trello();
            var ctx = new AppContext();
            var repo = new Repository<Models.Data>(ctx);
            var board = trello.Service.Retrieve<Board>("s7UpK8Ap");

            var Date = DateTime.Now;
            /*
            var organization = trello.Service.Retrieve<Organization>("fortes");
            var jsonOrganization = trello.Configuration.Serializer.Serialize(organization);

            dataOrganization.Date = DateTime.Now;
            dataOrganization.Json = jsonOrganization;
            dataOrganization.DataType = TrelloDataType.Organization;

            repo.Add(dataOrganization);
            repo.Save();

             
            foreach (var board in organization.Boards)
            {*/
                var jsonBoard = trello.Configuration.Serializer.Serialize(board);

                dataBoards.Date = Date;
                dataBoards.Json = jsonBoard;
                dataBoards.DataType = TrelloDataType.Board;
                //dataBoards.DataParentId = dataOrganization.Id;
                
                repo.Add(dataBoards);
                repo.Save();
                
                foreach (var list in board.Lists)
                {
                    var jsonList = trello.Configuration.Serializer.Serialize(list);

                    dataLists.Date = Date;
                    dataLists.Json = jsonList;
                    dataLists.DataType = TrelloDataType.List;
                    dataLists.DataParentId = dataBoards.Id;

                    repo.Add(dataLists);
                    repo.Save();

                    foreach (var card in list.Cards)
                    {
                        var jsonCard = trello.Configuration.Serializer.Serialize(card);

                        dataCards.Date = Date;
                        dataCards.Json = jsonCard;
                        dataCards.DataType = TrelloDataType.Card;
                        dataCards.DataParentId = dataLists.Id;

                        repo.Add(dataCards);
                        repo.Save();
                    }
                }
            //}
            return View();
        }
    }
}
