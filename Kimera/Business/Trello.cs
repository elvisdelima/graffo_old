using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Manatee.Trello;

namespace Kimera.Business
{
    public class Trello
    {
        public TrelloService Service { get; set; }
        public TrelloServiceConfiguration Configuration { get; set; }

        public Trello()
        {
            const string appKey = "67bd83087dc827f6821ab0ae5dd0c625";
            const string userToken = "8a0ff7249c98a8300dc627c9824b527e6c47deda80e820a563c21e9b12fc8b08";
            var authData = new TrelloAuthorization(appKey, userToken);
            
            Configuration = new TrelloConfiguration().GetConfiguration();
            Service = new TrelloService(Configuration, authData);
        }
    }
}

/*
    string appKey = "67bd83087dc827f6821ab0ae5dd0c625";
    string userToken = "8a0ff7249c98a8300dc627c9824b527e6c47deda80e820a563c21e9b12fc8b08";
    string boardId = "s7UpK8Ap";
    var authData = new TrelloAuthorization(appKey, userToken);
    var options = new TrelloConfiguration().GetConfiguration();
    var service = new TrelloService(options, authData);
    var board = service.Retrieve<Board>(boardId);
    var z = options.Serializer.Serialize(board);
*/