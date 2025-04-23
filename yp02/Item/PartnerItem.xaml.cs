using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для PartnerItem.xaml
    /// </summary>
    public partial class PartnerItem : UserControl
    {
        MainWindow mw;
        Partners partners;
        PartnersProducts PartnersProducts;
        public PartnerItem(Partners _partners)
        {
            InitializeComponent();
            this.mw = _mw;
            this.partners = _partners;

            TypeName.Content = mw.partnersTypes.Where(x=>x.Id==partners.Id).First().NameType + " | " + partners.Name.ToString();
            FIO.Content = _partners.FIO;
            Phone.Content = "+7 "+ _partners.Phone;
            Rating.Content = "Рейтинг: " + _partners.Rating;

            var CountProducts = mw.PartnersProducts.Where(x => x.IdPartner == partners.Id).Sum(x=>x.Count());
            if (CountProducts < 10000) {

                Sale.Content = "0%";
            }
            if (CountProducts >10000 && CountProducts < 50000)
            {
                Sale.Content = "5%";
            }
            if (CountProducts > 50000 && CountProducts < 300000)
            {
                Sale.Content = "10%";
            }
            if (CountProducts > 300000)
            {

                Sale.Content = "15%";
            }
        }
        private void EditeElement(object sender, MouseButtonEventArgs e)
        {
            mw.frame.Navigate(new Pages.Add_Edit.AddPartners(mw, partners));
        }
    }
}
