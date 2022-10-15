using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PM2TAREA11
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void sumar_Clicked(object sender, EventArgs e)
        {
            var resul = new Models.operaciones
            {   
                resultado = Convert.ToInt32(txtnumero1.Text) + Convert.ToInt32(txtnumero2.Text)   
            };
            var page = new Views.PageTwo();
            page.BindingContext = resul;
            await Navigation.PushAsync(page);
        }

        private async void restar_Clicked(object sender, EventArgs e)
        {
            var resul = new Models.operaciones
            {
                resultado = Convert.ToInt32(txtnumero1.Text) - Convert.ToInt32(txtnumero2.Text)
            };
            var page = new Views.PageTwo();
            page.BindingContext = resul;
            await Navigation.PushAsync(page);

        }

        private async void multiplicar_Clicked(object sender, EventArgs e)
        {
            var resul = new Models.operaciones
            {
                resultado = Convert.ToInt32(txtnumero1.Text) * Convert.ToInt32(txtnumero2.Text)
            };
            var page = new Views.PageTwo();
            page.BindingContext = resul;
            await Navigation.PushAsync(page);
        }

        private async void division_Clicked(object sender, EventArgs e)
        {
            var resul = new Models.operaciones
            {
                resultado = Convert.ToInt32(txtnumero1.Text) / Convert.ToInt32(txtnumero2.Text)
            };
            var page = new Views.PageTwo();
            page.BindingContext = resul;
            await Navigation.PushAsync(page);
        }
    }
}
