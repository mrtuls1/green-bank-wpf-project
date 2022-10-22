using GreenBank.classes.Models;
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

namespace GreenBank.UController.Customer
{
    /// <summary>
    /// Interaction logic for ucAccountCustomer.xaml
    /// </summary>
    public partial class ucAccountCustomer : UserControl
    {
        public string customer_id;
        public ucAccountCustomer()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (GetAccountProperty.GetAccounts(grd_accounts,customer_id)) { };
        }

        private void grd_accounts_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
