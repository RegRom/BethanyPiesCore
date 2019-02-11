using BethanyPies.Models;
using System.Collections.Generic;

namespace BethanyPies.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Pie> Pies { get; set; }
    }
}
