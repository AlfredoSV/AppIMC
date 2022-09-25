using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppIMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var peso = Peso.Text;
            var altura = Altura.Text;
            decimal imc;

            if (!String.IsNullOrEmpty(peso) || !String.IsNullOrEmpty(altura))
            {
                imc = Decimal.Parse(peso) / (Decimal.Parse(altura)/100);

                Imc.Text = Math.Round((imc),2).ToString();
            }
            else
            {
                DisplayAlert("Datos incorrectos", "Favor de validar la información ingresada", "Ok");
            }

           

        }

 
    }
}
