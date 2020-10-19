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
    public partial class Oktoober : ContentPage
    {
        public Oktoober()
        {
            InitializeComponent();
        }

        private async void October_Clicked(object sender, EventArgs e)
        {
            Uri url = new Uri("https://rus.postimees.ee/4495972/v-estonskom-kalendare-poyavitsya-novaya-znamenatelnaya-data");
            await Browser.OpenAsync(url);
        
        }

        private void Texti_Clicked(object sender, EventArgs e)
        {
            Textis.IsVisible = true;
            Textis1.IsVisible = true;
        }
    }
}