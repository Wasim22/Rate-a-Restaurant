﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restuarants.Models
{
    public class Restuarant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cuisine { get; set; }
        public int Rating { get; set; }
        public string Img { get; set; }
    }
}