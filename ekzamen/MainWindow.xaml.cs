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

namespace ekzamen
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

        private void imya_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(imyaBox.Text.Length < 3 || imyaBox.Text.Length > 15)
            {
                imyaBox.Background = Brushes.Red;
                string text = "Отказано!";
                imyaBlock.Text = text;
            }
            else
            {
                imyaBox.Background = Brushes.Green;
                string text1 = "Одобрено!";
                imyaBlock.Text = text1;
            }
        }

        private void familiyaBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (familiyaBox.Text.Length < 2 || familiyaBox.Text.Length > 25)
            {
                familiyaBox.Background = Brushes.Red;
                string text = "Отказано!";
                familiyaBlock.Text = text;
            }
            else
            {
                familiyaBox.Background = Brushes.Green;
                string text1 = "Одобрено!";
                familiyaBlock.Text = text1;
            }

        }
    }
    
}
