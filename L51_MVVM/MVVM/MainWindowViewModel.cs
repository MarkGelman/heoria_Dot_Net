using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L51_MVVM
{
    class MainWindowViewModel
    {
        public Person MyPerson1 { get; set; }

        public MainWindowViewModel()
        {
            MyPerson1 = new Person() { Name = "Yakov Israel" };
        }
    }
}
