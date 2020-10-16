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
    public partial class Julli : ContentPage
    {
        public Julli()
        {
            InitializeComponent();
        }

        private async  void July_Clicked(object sender, EventArgs e)
        {
            Uri url = new Uri("https://vgtimes.ru/news/68346-geymery-prazdnuyut-den-videoigry-i-publikuyut-lichnye-topy-s-samymi-lyubimymi-taytlami.html");
            await Browser.OpenAsync(url);
        }
    }
}