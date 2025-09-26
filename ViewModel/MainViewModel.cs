using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MyFirstMAUIApp.Model;
using MyFirstMAUIApp.View;

namespace MyFirstMAUIApp.ViewModel
{
    internal class MainViewModel
    {
        public TitleMain TitleMain { get; set; }
        public ICommand OnLayoutsClickedCommand { get; set; }

        public MainViewModel()
        {
            TitleMain = new TitleMain();
            OnLayoutsClickedCommand = new Command(async () => await OnLayoutsClickedAsync());
        }

        private async Task OnLayoutsClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new LayoutsPage());
        }
    }
}
