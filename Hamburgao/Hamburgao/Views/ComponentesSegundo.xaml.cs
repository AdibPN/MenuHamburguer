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
    public partial class ComponentesSegundo : ContentPage
    {
        public ComponentesSegundo()
        {
            InitializeComponent();
        }

            private async void Button_Clicked(object sender, EventArgs e)
            {
                try
                {
                    var c = new Componentes
                    {
                        Nome = "Ética",
                        AtribuicoesResponsabilidades = "Habilitação em Gestão de Negócios, Direito, Gestão de Políticas Públicas, etc.",
                        ValoresAtitudes = "Desenvolver o olhar ético, responsabilizar-se pelas atitudes, gestão de pessoas.",
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
                    Nome = "Desenvolvimento de Sistemas",
                    AtribuicoesResponsabilidades = "Engenharia de Sistemas, Engenharia de Software, Matemática Aplicada, Computação Científica etc.",
                    ValoresAtitudes = "Desenvolver habilidades de Informática com Ênfase em Banco de Dados, Redes de Computadores, e outras linguagens, como, C#.",
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
                    Nome = "Banco de dados II",
                    AtribuicoesResponsabilidades = "Utilização de ambiente de desenvolvimento integrado para a execução de instruções de bancos de dados.",
                    ValoresAtitudes = "Desenvolver a Análise de Sistemas Administrativos em Processamento de Dados.",
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
                    Nome = "Programação Mobile",
                    AtribuicoesResponsabilidades = "Tecnologia em Desenvolvimento de Jogos Digitais, Tecnologia em Desenvolvimento de Software",
                    ValoresAtitudes = "Desenvolver aplicativos que utilizem todas as matérias como agragação",
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
                    Nome = "Sistemas Embarcados",
                    AtribuicoesResponsabilidades = "Utilização de ambiente de desenvolvimento integrado para a construção de instruções para sistemas embarcados.",
                    ValoresAtitudes = "Desenvolver programas integradas à sistemas embarcados que sejam úteis no cotidiano",
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
                    Nome = "Programação Web II",
                    AtribuicoesResponsabilidades = "Utilização de ambiente de desenvolvimento integrado para construção de páginas de Internet, linguagem de script e folhas de estilo.",
                    ValoresAtitudes = "Desenvolver página na web, com raciocínio lógico e idéias de layout",
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