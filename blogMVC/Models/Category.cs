using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace blogMVC.Models
{
    public class Category
    {
        public int Id { get; set; } 
        public string CategoryName { get; set; }
        
        public List<Blog>Bloglar { get; set; }
    }
}