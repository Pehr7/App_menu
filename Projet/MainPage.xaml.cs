using Projet.Paginas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Projet
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Teste OK", "Ola, " + txtNome.Text + "!", "Fechar");
        }

        private void btnImagem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Imagem());
        }

        private void btnTexto_Clicked(object sender, EventArgs e)
        {
            var Navegacao = new Texto();
            Navigation.PushModalAsync(Navegacao);
        }
    }
}
