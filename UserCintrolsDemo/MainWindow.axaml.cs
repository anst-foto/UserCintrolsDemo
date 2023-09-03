using Avalonia.Controls;
using Avalonia.Interactivity;

namespace UserCintrolsDemo;

public partial class MainWindow : Window
{
    private InputControl Input1 { get; set; }
    private InputControl Input2;
    public MainWindow()
    {
        Input1 = new InputControl("Name");
        Input2 = new InputControl("Age");
        InitializeComponent();
        
        Main.Children.Add(Input1);
        Main.Children.Add(Input2);
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        Output.Text = $"{Input1.Text} {Input1.Text}";
    }
}