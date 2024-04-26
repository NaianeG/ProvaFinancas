using Dominio.Entidades;
using Integracao;
using Newtonsoft.Json;
using Microsoft.Maui.Controls;
using Prova;

namespace Prova
{

    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void CliqueBuscarInformacoes(object sender, EventArgs e)
        {
            string simboloAcao = campoSimbolo.Text;
            ShareDetails shareDetails = new ShareDetails(simboloAcao);
            await Navigation.PushAsync(shareDetails);
            SemanticScreenReader.Announce(BuscarInformacoes.Text);
        }

        private void CampoSimbolo_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(campoSimbolo.Text))
            {
                BuscarInformacoes.IsEnabled = false;
            }
            else
            {
                BuscarInformacoes.IsEnabled = true;
            }
        }
    }
}
