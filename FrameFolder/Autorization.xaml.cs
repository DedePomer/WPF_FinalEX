using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace WPF_FinalEX.FrameFolder
{
    /// <summary>
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Page
    {

        public static int a = 0;
        public static DispatcherTimer timer = new DispatcherTimer();
        public Autorization()
        {
            InitializeComponent();
        }

        private void BAuto_Click(object sender, RoutedEventArgs e)
        {
            if (a == 0)
            {
                if (TBOXLog.Text == "admin" && TBOXPass.Text == "admin")
                {
                    NavigationClass.frame.Navigate(new MainFrame());
                }
                else if (TBOXLog.Text == "a" && TBOXPass.Text == "a")
                {
                    NavigationClass.frame.Navigate(new Plug());
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    a = 1;
                    if (a == 1)
                    {
                        timer.Tick += new EventHandler(EndTimer);

                        timer.Interval = new TimeSpan(0, 0, 10);

                        timer.Start();
                    }
                }
            }
            else
            {
                MessageBox.Show("Подождите 10 секунд", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        public static void EndTimer(object sender, EventArgs e)
        {
            a = 0;
            timer.Stop();
        }
    }
}
