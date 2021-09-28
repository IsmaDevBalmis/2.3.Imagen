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

namespace Imagen
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void opacidadAltaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagenImage.Opacity = 1.0;
        }

        private void opacidadMeidaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagenImage.Opacity = 0.6;
        }

        private void opacidadBajaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagenImage.Opacity = 0.3;
        }

        private void rellenoAjusteRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagenImage.Stretch = Stretch.Fill;
        }

        private void uniformeAjusteRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagenImage.Stretch = Stretch.Uniform;
        }

        private void rellenoUniformeAjusteRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagenImage.Stretch = Stretch.UniformToFill;
        }

        private void sinAjusteRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagenImage.Stretch = Stretch.None;
        }
    }
}
