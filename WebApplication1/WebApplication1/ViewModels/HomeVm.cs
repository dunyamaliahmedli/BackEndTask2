﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class HomeVm
    {
        public List<Category> Categories { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<Product> Products { get; set; }
    }
}
