using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tabbed_Peod
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class September : ContentPage
    {
        public September()
        {
            InitializeComponent();
        }

        private async  void September1_Clicked(object sender, EventArgs e)
        {
            Uri url = new Uri("https://www.valitsus.ee/ru/den-soprotivleniya-22-sentyabrya");
            await Browser.OpenAsync(url);
        }
    }
}