using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kimera.Business
{
    public enum TrelloDataType
    {
        Organization = 0,
        Board,
        List,
        Card,
        CardMember,
        CheckList,
        CheckItem
    }
}