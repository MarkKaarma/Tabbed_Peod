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
    public partial class Marts : ContentPage
    {
        public Marts()
        {
            InitializeComponent();
        }

        private async void March_Clicked(object sender, EventArgs e)
        {
            Uri url = new Uri("http://www.culture.ee/sobytie/den-rodnogo-iazyka-v-estonii/");
            await Browser.OpenAsync(url);
        }

        private void Texti_Clicked(object sender, EventArgs e)
        {
            Textis.IsVisible = true;
            Textis1.IsVisible = true;
        }
    }
}