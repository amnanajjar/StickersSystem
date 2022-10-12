using StickersSystem.ViewModels;
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

namespace StickersSystem.Views
{
    /// <summary>
    /// Interaction logic for ItemsView.xaml
    /// </summary>
    public partial class ItemsView : Window
    {
        public ItemsView()
        {
            DataContext = new ItemsViewModel();
            InitializeComponent();
        }
    }
}
