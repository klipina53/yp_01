using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
using yp02.Classes;

namespace yp02.Item
{
    /// <summary>
    /// Логика взаимодействия для MainPartners.xaml
    /// </summary>
    public partial class MainPartners : Page
    {
        MainWindow mw;
        Partners partners;
        public MainPartners(MainWindow _mw)
        {
            InitializeComponent();
            this.mw = _mw;

            LoadPartners();
        }
        public void LoadPartners()
        {
            parent.Children.Clear();
            mw.PartnersTable();
            foreach(Partners item in mw.partners)
                parent.Children.Add(new Elements.Partner(mw, item));
        }
        private void BackClick(object sender, RoutedEventArgs e)
        {
            mw.frame.Navigate(new Pages.Menu(mw));
        }
        private void Add(object sender, RoutedEventArgs e)
        {
            mw.frame.Navigate(new Pages.Add_Edit.AddPartners(mw, partners));
        }
    }
}
