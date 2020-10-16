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
    public partial class Detsember : ContentPage
    {
        public Detsember()
        {
            InitializeComponent();
        }

        
        private async void December_Clicked(object sender, EventArgs e)
        {
            Uri url = new Uri("https://www.youtube.com/watch?v=IO9XlQrEt2Y");
            await Browser.OpenAsync(url);
        }


        private void Texti_Clicked(object sender, EventArgs e)
        {
            Textis.IsVisible=true;
            Textis1.IsVisible = true;
        }
    }
}