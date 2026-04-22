using Avalonia.Controls;
using AOOP3.ViewModels;

namespace AOOP3.Views;

public partial class RouteView : UserControl
{
    public RouteView()
    {
        InitializeComponent();

        // Assign the Map manually once the ViewModel is attached
        DataContextChanged += (_, _) =>
        {
            if (DataContext is RouteViewModel vm)
            {
                MapControl.Map = vm.Map;
            }
        };
    }
}