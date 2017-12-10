using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spring.Mvc3QuickStart.Models
{
    public class Articles
    {
        public string Category { get; set;}
        public string Description { get; set; }
        public Guid Id { get; set; }
    }
}