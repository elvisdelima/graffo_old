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
        public virtual DateTime Date { get; set; }
        public virtual TrelloDataType DataType { get; set; }
        public virtual String Json { get; set; }
        public virtual int DataParentId { get; set; }
        public virtual string TrelloId { get; set; }
    }
}   