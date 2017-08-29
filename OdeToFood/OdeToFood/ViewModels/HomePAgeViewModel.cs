using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood.Entities;

namespace OdeToFood.ViewModels
{
    public class HomePAgeViewModel
    {
        public string CurrentMessage { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }

    }
}
