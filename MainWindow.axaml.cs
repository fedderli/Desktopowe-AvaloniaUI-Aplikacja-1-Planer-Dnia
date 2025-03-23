using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Desktopowe_AvaloniaUI_Aplikacja_1_Planer_Dnia;



public class Zadanie
{
    public string Nazwa { get; set; }
    public string Kategoria { get; set; }
    public bool CzyUkonczone { get; set; }
}
public partial class MainWindow : Window
{
    public List<Zadanie> Zadania { get; set; } = new List<Zadanie>();
    public MainWindow()
    {
        InitializeComponent();
        
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        string nazwa = InpuTextBox.Text ?? "puste zadanie";
        string kategoria = "" ;

        if (RadioButtonObowiazki.IsChecked == true)
        {
            kategoria = "Obowiązki";
        }
        else if (RadioButtonRozwoj.IsChecked == true)
        {
            kategoria = "Rozwoj";
        }
        else if (RadioButtonRelaks.IsChecked == true)
        {
            kategoria = "Relaks";
        }
        else if (RadioButtonZdrowie.IsChecked == true)
        {
            kategoria = "Zdrowie";
        }


        string zadanieText = $"{kategoria}: {nazwa}";
        
        var checkbox = new CheckBox() { Content = zadanieText };
        ZadaniaListBox.Items.Add(checkbox);
        
        InpuTextBox.Clear();
        RadioButtonObowiazki.IsChecked = false;
        RadioButtonRozwoj.IsChecked = false;
        RadioButtonRelaks.IsChecked = false;
        RadioButtonZdrowie.IsChecked = false;
    }
}