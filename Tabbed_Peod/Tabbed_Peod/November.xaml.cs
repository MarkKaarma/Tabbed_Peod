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
    public partial class November : ContentPage
    {
        public November()
        {
            InitializeComponent();
        }

        private async void November1_Clicked(object sender, EventArgs e)
        {

            Uri url = new Uri("https://stolitsa.ee/estoniya/v-voskresene-vyvesheny-flagi-v-chest-dnya-otcov");
            await Browser.OpenAsync(url); 
        }

        private void Texti_Clicked(object sender, EventArgs e)
        {
            Textis.IsVisible = true;
            Textis1.IsVisible = true;
        }
    }
}