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
    public partial class Mai : ContentPage
    {
        public Mai()
        {
            InitializeComponent();
        }

        private async void May_Clicked(object sender, EventArgs e)
        {
            Uri url = new Uri("https://triptoestonia.com/obshhaya-informaciya/prazdniki-estonii/pervoe-maya-den-vesny/");
            await Browser.OpenAsync(url);
        }

        private void Texti_Clicked(object sender, EventArgs e)
        {
            Textis.IsVisible = true;
            Textis1.IsVisible = true;
        }
    }
}