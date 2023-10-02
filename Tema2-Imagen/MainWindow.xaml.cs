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

namespace Tema2_Imagen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       
        private void Alta_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Opacity =0.3;
        }

        private void Media_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Opacity = 0.6;
        }

        private void Baja_Checked(object sender, RoutedEventArgs e)
        {
            
            imagen.Opacity = 1;
            
           
            
        }

        private void None_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.None;
        }

        private void UniformToFill_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch=Stretch.UniformToFill;

        }

        private void Uniform_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch=Stretch.Uniform;
        }

        private void Fill_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.Fill;
        }
    }
}
