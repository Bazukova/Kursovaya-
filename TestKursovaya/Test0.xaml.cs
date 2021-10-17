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
using System.Windows.Shapes;

namespace TestKursovaya
{
    /// <summary>
    /// Логика взаимодействия для Test0.xaml
    /// </summary>
    public partial class Test0 : Window
    {
        public Test0()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
          

        }




        private void TextBlock_Clicked(object sender, MouseButtonEventArgs e)
        {


            if (que1.IsEnabled == false)
            {
                que1.Background = Brushes.Red;

            }
            if (que2.IsEnabled == false)
            {
                que2.Background = Brushes.Red;
            }
            if (que3.IsEnabled == true)
            {

                que3.Background = Brushes.Green;

            }
        }
    }
}
