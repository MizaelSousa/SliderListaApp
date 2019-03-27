using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SliderListaApp
{
    public partial class MainPage : ContentPage
    {
        ArrayList listaDeUf = new ArrayList();

        void naMudancaDeValorDoSlider(object sender, Xamarin.Forms.ValueChangedEventArgs e){

            int posicao = Convert.ToInt32(slider.Value);
            string valordalabel = listaDeUf[posicao].ToString();

            label_uf.Text = valordalabel;
        }

        async void visualizarMunicipios(object sender, System.EventArgs e)
        {
            var cliente = new HttpClient();
            var json = await cliente.GetStringAsync($"http://viacep.com.br/ws/{label_uf.Text}/json/");
            var dados = JsonConvert.DeserializeObject<Object>(json);
            //await DisplayAlert("UF", label_uf.Text, "Ok");
        }

        public MainPage()
        {
            InitializeComponent();

            listaDeUf.Add("AC");
            listaDeUf.Add("AL");
            listaDeUf.Add("AM");
            listaDeUf.Add("AP");
            listaDeUf.Add("BA");
            listaDeUf.Add("CE");
            listaDeUf.Add("DF");
            listaDeUf.Add("ES");
            listaDeUf.Add("GO");
            listaDeUf.Add("MA");
            listaDeUf.Add("MG");
            listaDeUf.Add("MS");
            listaDeUf.Add("MT");
            listaDeUf.Add("PA");
            listaDeUf.Add("PB");
            listaDeUf.Add("PE");
            listaDeUf.Add("PI");
            listaDeUf.Add("PR");
            listaDeUf.Add("RJ");
            listaDeUf.Add("RN");
            listaDeUf.Add("RO");
            listaDeUf.Add("RR");
            listaDeUf.Add("RS");
            listaDeUf.Add("SC");
            listaDeUf.Add("SE");
            listaDeUf.Add("SP");
            listaDeUf.Add("TO");
        }
    }
}
