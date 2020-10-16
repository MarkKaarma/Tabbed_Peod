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
    public partial class Veebruar : ContentPage
    {
        public Veebruar()
        {
            InitializeComponent();
        }

        private async void February_Clicked(object sender, EventArgs e)
        {
            Uri url = new Uri("https://triptoestonia.com/obshhaya-informaciya/prazdniki-estonii/den-nezavisimosti-estonii/");
            await Browser.OpenAsync(url);
        }
    }
}