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

namespace L51_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Person MyPerson1 { get; set; }
        public MainWindow()
        {
            MyPerson1 = new Person() { Name = "Yakov Israel" };
            InitializeComponent();
            DataContext = this;
        }

        private void Button_Click (object sender, RoutedEventArgs e)
        {
            MyPerson1.Name = "Yakov";
        }
    }
}
