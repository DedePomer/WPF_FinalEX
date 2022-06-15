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
using WPF_FinalEX.ClassesFolder;
using WPF_FinalEX.FrameFolder;

namespace WPF_FinalEX
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NavigationClass.frame = Fmain;
            BD.data = new TestEX2022Entities();
            List<Material> a = BD.data.Material.ToList();
            TimeSpan timeSpan = new TimeSpan();
            DateTime date1 = new DateTime(2010, 1, 1, 8, 0, 15);
            DateTime date2 = new DateTime(2010, 1, 1, 10, 6, 50);
            timeSpan = date2 - date1;
            NavigationClass.frame.Navigate(new MainFrame());
        }
    }
}
