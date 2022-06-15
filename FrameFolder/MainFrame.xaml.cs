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

namespace WPF_FinalEX.FrameFolder
{
    /// <summary>
    /// Логика взаимодействия для MainFrame.xaml
    /// </summary>
    public partial class MainFrame : Page
    {
        List<Product> FirstList = BD.data.Product.ToList();
        List<Product> SecondList = BD.data.Product.ToList();
        public MainFrame()
        {
            InitializeComponent();
            LVMaterials.ItemsSource = FirstList;
            SecondList = FirstList;
        }

        private void Bup_Click(object sender, RoutedEventArgs e)
        {
            if (sort())
            {
                LVMaterials.Items.Refresh();
            }
        }

        private void Bdown_Click(object sender, RoutedEventArgs e)
        {
            if (sort())
            {
                SecondList.Reverse();
                LVMaterials.Items.Refresh();
            }
        }

        private bool sort()
        {
            switch (Sort.SelectedIndex)
            {
                case 0:
                    SecondList.Sort((x, y) => x.Title.CompareTo(y.Title));
                    return true;
                case 1:
                    SecondList.Sort((x, y) => x.MinCostForAgent.CompareTo(y.MinCostForAgent));
                    return true;
                default:
                    return false; 
            }
        }

        private void Sort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sort())
            {
                LVMaterials.Items.Refresh();
            }
        }


        private bool filt()
        {
            switch (Filt.SelectedIndex)
            {
                case 0:
                    SecondList = FirstList.Where(x=> x.ProductTypeID == 1).ToList();
                    sort();
                    return true;
                case 1:
                    SecondList = FirstList.Where(x => x.ProductTypeID == 2).ToList();
                    sort();
                    return true;
                default:
                    return false;
            }
        }

        private void Filt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            filt();
            LVMaterials.ItemsSource = SecondList;
            LVMaterials.Items.Refresh();
        }
    }
}
