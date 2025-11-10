using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace Ejercicio2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Grid grid = new Grid();
            this.Content = grid;

            Button boton = new Button();
            boton.FontWeight = FontWeights.Bold;

            WrapPanel wrapPanel = new WrapPanel();

            TextBlock texto1 = new TextBlock();
            texto1.Text = "verde ";
            texto1.Foreground = Brushes.Green;

            TextBlock texto2 = new TextBlock();
            texto2.Text = "azul ";
            texto2.Foreground = Brushes.Blue;

            TextBlock texto3 = new TextBlock();
            texto3.Text = "normal";

            wrapPanel.Children.Add(texto1);
            wrapPanel.Children.Add(texto2);
            wrapPanel.Children.Add(texto3);

            boton.Content = wrapPanel;

            grid.Children.Add(boton);
        }
    }
}
