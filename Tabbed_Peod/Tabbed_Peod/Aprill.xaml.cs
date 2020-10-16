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
    public partial class Aprill : ContentPage
    {
        public Aprill()
        {
            InitializeComponent();
        }

        private async void April_Clicked(object sender, EventArgs e)
        {
            Uri url = new Uri("https://www.tallinn.ee/rus/noorteinfo/Pjatnitsa,-10-aprelja-2020");
            await Browser.OpenAsync(url);
        }
    }
}