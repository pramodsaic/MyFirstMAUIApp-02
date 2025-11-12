using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIApp.Model.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIApp.ViewModels
{
    public partial class LayoutsFlexViewModel : ObservableObject
    {
        [ObservableProperty]
        public string flexLayoutTitle = TitleLayoutsFlex.FlexLayoutTitle;
    }
}