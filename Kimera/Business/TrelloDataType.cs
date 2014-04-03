using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kimera.Business
{
    public enum TrelloDataType
    {
        Organization = 0,
        Boards,
        Lists,
        Cards,
        CardMembers,
        CheckLists,
        CheckItems
    }
}