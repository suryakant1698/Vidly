using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movies movie { get; set; }
        public List<Customers> Customers { get; set; }
    }
}