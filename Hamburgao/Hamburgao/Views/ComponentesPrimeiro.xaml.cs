using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Hamburgao.Models;

namespace Hamburgao.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComponentesPrimeiro : ContentPage
    {
        public ComponentesPrimeiro()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componentes
                {
                    Nome = "Design digital",
                    AtribuicoesResponsabilidades = "Desenvolver a criatividade, a comunição visual utilizando cartases, potifólios, etc.",
                    ValoresAtitudes = "Desenvolver o olha estético, responsabilizar-se pela produção, utilização e divulgação de informações.",
                };

                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("IXI", ex.Message, "OK");
            }
        }

        private async void Button_Clicked1(object sender, EventArgs e)
        {
            try
            {
                var c = new Componentes
                {
                    Nome = "Programação de algoritimos",
                    AtribuicoesResponsabilidades = "Implementar algorítimos em linguagem de programação, utilizando ambientes de desenvolvimento de acordo com as necessidades",
                    ValoresAtitudes = "Estimular a organização, incentivar atitudes de autonomia, fortalecer a persistência e ointeresse na resolução de situações-problemas ",
                };

                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("IXI", ex.Message, "OK");
            }
        }

        private async void Button_Clicked2(object sender, EventArgs e)
        {
            try
            {
                var c = new Componentes
                {
                    Nome = "Banco de dados I",
                    AtribuicoesResponsabilidades = "Modelar banco de dados",
                    ValoresAtitudes = "Estimular a organização, incentivar atitudes de autonomia, fortalecer a persistência, interesse na resolução de situações-problemas e promover ações que considerem o respeito às normas estabelecidas. ",
                };

                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("IXI", ex.Message, "OK");
            }
        }

        private async void Button_Clicked3(object sender, EventArgs e)
        {
            try
            {
                var c = new Componentes
                {
                    Nome = "Análise de sistemas",
                    AtribuicoesResponsabilidades = "Elaborar projetos de sistema de informação ",
                    ValoresAtitudes = "Estimular a organização, incentivar atitudes de autonomia, fortalecer a persistência, interesse na resolução de situações-problemas e promover ações que considerem o respeito às normas estabelecidas. ",
                };

                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("IXI", ex.Message, "OK");
            }
        }


        private async void Button_Clicked4(object sender, EventArgs e)
        {
            try
            {
                var c = new Componentes
                {
                    Nome = "Fundamentos da informática",
                    AtribuicoesResponsabilidades = "Elaborar projetos de sistema de informação ",
                    ValoresAtitudes = "Estimular a organização, incentivar atitudes de autonomia, fortalecer a persistência, interesse na resolução de situações-problemas e promover ações que considerem o respeito às normas estabelecidas. ",
                };

                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("IXI", ex.Message, "OK");
            }
        }

        private async void Button_Clicked5(object sender, EventArgs e)
        {
            try
            {
                var c = new Componentes
                {
                    Nome = "Programação Web I",
                    AtribuicoesResponsabilidades = "Operar sistemas computacionais",
                    ValoresAtitudes = "Desenvolver a criticidade, incentivar comporamentos éticos, promover ações que considerem o respeito às normas estabelecidas. ",
                };

                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("IXI", ex.Message, "OK");
            }
        }
    }
}