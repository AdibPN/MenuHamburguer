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
    public partial class ComponentesTerceiro : ContentPage
    {
        public ComponentesTerceiro()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componentes
                {
                    Nome = "Segurança de Sistemas de Informações",
                    AtribuicoesResponsabilidades = "Implementar rotinas de segurança da informação",
                    ValoresAtitudes = "Estimular atitudes respeitosas, incentivar comportamentos éticos, desenvolver a criticidade",
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
                    Nome = "Desenvolvimento do trabalho de conclusão de curso (TCC) em Desenvolvimento de Sistemas",
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


        private async void Button_Clicked2(object sender, EventArgs e)
        {
            try
            {
                var c = new Componentes
                {
                    Nome = "Banco de dados III",
                    AtribuicoesResponsabilidades = "Realizar a gestão de banco de dados",
                    ValoresAtitudes = "incentivar a criatividade, desenvolver a criticidade, fortalecer a persistencia e o interesse na resolução de problemas",
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
                    Nome = "Programação Mobile II",
                    AtribuicoesResponsabilidades = "documentar, construitr e manter  sistemas de informações em plataformas móveis",
                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações, estimular a organização, etc. ",
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
                    Nome = "Qualidade e teste de sofware",
                    AtribuicoesResponsabilidades = "testar sofwares para melhoria da qualidade de sistemas, elaborar registros e planilhas de acompanhamento e controle das atividades ",
                    ValoresAtitudes = "responsabilizar-se pela produção, utilização e divulgação de informações, etc.",
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
                    Nome = "Programação Web III",
                    AtribuicoesResponsabilidades = "documentar, contruir e manter sistemas de informações para web",
                    ValoresAtitudes = "responsabilizar-se pela produçaõ, utilização e divulgação de informações, fortalecer a persistencia e o interesse na resolução de problemas, incentivar a criatividade",
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