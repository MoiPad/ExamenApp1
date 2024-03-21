using ExamenApp1.ViewModels;

namespace ExamenApp1.Views;

public partial class AreaCirculo : ContentPage
{
    private AreaCirculoViewModel viewModel;
    public AreaCirculo()
	{
		InitializeComponent();
		viewModel = new AreaCirculoViewModel();
		this.BindingContext = viewModel;
	}
}