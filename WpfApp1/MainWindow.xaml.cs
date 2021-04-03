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
using Xceed.Wpf.Toolkit;

namespace ComboBox_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public override string ToString ()
            {
                return $"{FirstName} {LastName}";
            }
        }

        private List<Person> people = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();
            people.Add(new Person { FirstName = "Dan", LastName = "Cohen" });
            people.Add(new Person { FirstName = "Eli", LastName = "Snir" });
            people.Add(new Person { FirstName = "Mariano", LastName = "Boser" });
            people.Add(new Person { FirstName = "Suzana", LastName = "Holmes" });

            myComboBox.ItemsSource = people;
            myComboBox.SelectedIndex = 0;

        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Xceed.Wpf.Toolkit.MessageBox.Show("hi");
        }

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            Person p = new Person();
            //Xceed.Wpf.Toolkit.MessageBox.Show("hi");
            people.Add(new Person { FirstName = firstNameTxt.Text, LastName = lastNameTxt.Text });
            string button = sender.ToString();
            switch (button)
            {
                case "Delete 1": for (int i=0;i<people.Count;i++)
                                    {
                        if (people[i].FirstName == firstNameTxt.Text && people[i].LastName == lastNameTxt.Text)
                            people.RemoveAt(i);
                                    }; break;
                   
            }
        }
    }
}
