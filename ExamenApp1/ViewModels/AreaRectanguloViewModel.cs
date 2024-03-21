
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExamenApp1.Models;

namespace ExamenApp1.ViewModels
{
    public partial class AreaRectanguloViewModel : ObservableObject
    {
        [ObservableProperty]
        private double _base;

        [ObservableProperty]
        private double _altura;

        [ObservableProperty]
        private double _resultado;

        [RelayCommand]
        public void CalcularRectangulo()
        {
            try
            {
                if (Validar())
                {
                    ExamenApp examenApp = new ExamenApp();
                    examenApp.Base = _base;
                    examenApp.Altura = _altura;

                    Resultado = Base * Altura;
                }


            }
            catch (Exception ex)
            {
                Alerta("Error", $"Excepción{ex.Message}");
            }

        }

        [RelayCommand]
        private void Limpiar()
        {
            Base = 0;
            Altura = 0;
            Resultado = 0;
        }

        private bool Validar()
        {
            if (Base == 0)
            {
                Alerta("Avertencia!", "Los campos no pueden ir vacios, la base");

                return false;
            }
            else if (Altura == 0)
            {
                Alerta("Avertencia!", "Los campos no pueden ir vacios, ingrese la altura");

                return false;
            }
            else
            {
                return true;
            }

        }

        public void Alerta(string tipo, string mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(tipo, mensaje, "Aceptar"));
        }
    }
}
