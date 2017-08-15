using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TDS171A_Diogo.Models
{
    public class Category
    {
        public long CategoryId { get; set; }
        public string CategorySlug { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}