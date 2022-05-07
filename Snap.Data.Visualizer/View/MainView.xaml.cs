using Snap.Data.Visualizer.ViewModel;
using System.Windows.Controls;

namespace Snap.Data.Visualizer.View;

public partial class MainView : UserControl
{
    public MainView()
    {
        DataContext = new MainViewModel();
        InitializeComponent();
    }
}
