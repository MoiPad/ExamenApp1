
using ExamenApp1.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ExamenApp1.ViewModels
{
    public partial class AreaCirculoViewModel : ObservableObject
    {
        [ObservableProperty]
        private double radio;

        [ObservableProperty]
        private double pi;

        [ObservableProperty]
        private double resultado;


        [RelayCommand]

        public void CalcularCirculo()
        {
            try
            {
                if (Validar())
                {
                    ExamenApp examenApp = new ExamenApp();
                    examenApp.Radio = radio;
                    examenApp.Pi = pi;

                    Resultado = Math.PI * Math.Pow(Radio, 2);
                }
            

            }catch (Exception ex)
            {
                Alerta("Error", $"Excepción{ex.Message}");
            }

        
        }

        [RelayCommand]
        private void Limpiar()
        {
            Radio = 0;
            Pi = 0;
            Resultado = 0;
        }

        private bool Validar()
        {
            if(Radio == 0)
            {
                Alerta("Avertencia!", "Los campos no pueden ir vacios, ingrese el radio");

                return false;
            }
            else
            {
                return true;
            }
            
        }
       
        public void Alerta(string tipo, string mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(tipo, mensaje, "Aceptar") );
        }
    }
}
