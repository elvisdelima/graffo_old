using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Manatee.Trello;
using Manatee.Trello.ManateeJson;
using Manatee.Trello.RestSharp;

namespace Kimera.Business
{
    public class TrelloConfiguration
    {
        public TrelloServiceConfiguration GetConfiguration()
        {
            var options = new TrelloServiceConfiguration();
            var serializer = new ManateeSerializer();
            options.Serializer = serializer;
            options.Deserializer = serializer;
            options.RestClientProvider = new RestSharpClientProvider(options);
            return options;
        }
    }
}