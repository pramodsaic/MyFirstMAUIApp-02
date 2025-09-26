using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstMAUIApp.Model;

namespace MyFirstMAUIApp.ViewModel
{
    internal class LayoutsViewModel
    {
        public TitleLayout TitleLayout { get; set; }

        public LayoutsViewModel()
        {
            TitleLayout = new TitleLayout();
        }
    }
}
