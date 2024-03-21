using ExamenApp1.ViewModels;

namespace ExamenApp1.Views;

public partial class AreaRectangulo : ContentPage
{
    private AreaRectanguloViewModel viewModel;
	public AreaRectangulo()
	{
        InitializeComponent();
        viewModel = new AreaRectanguloViewModel();
        this.BindingContext = viewModel;
    }
}