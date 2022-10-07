using GreenBank.classes;
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

namespace GreenBank.UController
{
    /// <summary>
    /// Interaction logic for ucPayments.xaml
    /// </summary>
    public partial class ucPayments : UserControl
    {
        public ucPayments()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (GetPaymentsProperty.GetAccount(grd_payments)) { }
        }

        private void grd_payments_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void btn_payment_add_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
