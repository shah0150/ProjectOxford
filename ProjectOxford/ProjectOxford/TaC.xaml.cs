using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ProjectOxford
{
    public partial class TaC : ContentPage
    {
        public TaC()
        {
            InitializeComponent();
        }

        public async void tacbutton(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }
    }
}
