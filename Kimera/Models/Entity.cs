using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kimera.Models.Interfaces;

namespace Kimera.Models
{
    public abstract class Entity : IEntity
    {
        public int Id { get; set; }
    }
}