using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace UserCintrolsDemo;

public partial class InputControl : UserControl
{
    private string _label;
    
    public string Text { get; set; }
    
    public InputControl(string label)
    {
        _label = label;
        
        InitializeComponent();
        LabelInput.Content = _label;
    }

    private void Input_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        Text = Input.Text;
    }
}