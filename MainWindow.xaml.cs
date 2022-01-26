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

namespace WpfAppLab3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textbox!=null)
            {
                textbox.FontFamily = new FontFamily(fontName);
            }
            
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            string fontsize = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textbox != null)
            {
                textbox.FontSize=   Convert.ToDouble(fontsize);
            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
                
                textbox.FontWeight = FontWeights.Bold;
            
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textbox.FontStyle = FontStyles.Italic;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textbox.TextDecorations = TextDecorations.Underline;
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            textbox.Foreground = Brushes.Black;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textbox.Foreground = Brushes.Red;
        }
    }
}
