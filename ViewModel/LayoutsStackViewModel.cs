using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIApp.Models.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIApp.ViewModels
{
    public partial class LayoutsStackViewModel : ObservableObject
    {
        [ObservableProperty]
        public string stackLayoutTitle = TitleLayoutsStack.StackLayoutTitle;

    }
}



