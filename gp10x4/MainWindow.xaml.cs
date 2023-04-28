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

namespace gp10x4
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
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (nadpis.Text != null) 
            { 
             Tex1.Items.Add(nadpis.Text);
            }
        }

        private void Tex1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (Tex1.SelectedItem != null)
            {
                list1.Items.Add(Tex1.SelectedItem);
                Tex1.Items.Remove(Tex1.SelectedItem);
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Tex1.SelectedItem != null)
            {
                Tex1.Items.Remove(Tex1.SelectedItem);
            }
            if (list1.SelectedItem != null)
            {
                list1.Items.Remove(list1.SelectedItem); 
            }
        }
    }
}
