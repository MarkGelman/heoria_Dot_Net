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

namespace L51_MVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel mvvm;
        public MainWindow()
        {
            mvvm = new MainWindowViewModel();
            InitializeComponent();
            DataContext = mvvm;         
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mvvm.MyPerson1.Name = "Yakov";
        }
    }
}
