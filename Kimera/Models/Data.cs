using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kimera.Business;
using Kimera.Models.Interfaces;

namespace Kimera.Models
{
    public class Data : Entity
    {
        public DateTime Date { get; set; }
        public TrelloDataType DataType { get; set; }
        public String Json { get; set; }
        public int DataParentId { get; set; }
    }
}   