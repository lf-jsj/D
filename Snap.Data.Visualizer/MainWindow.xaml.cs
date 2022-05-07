using System.Windows;
using WPFUI.Appearance;

namespace Snap.Data.Visualizer;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        InitializeUi();
    }

    private void InitializeUi()
    {
        Loaded += (sender, args) =>
        {
            WPFUI.Appearance.Watcher.Watch(this, BackgroundType.Mica, true, true);
        };
    }
}
