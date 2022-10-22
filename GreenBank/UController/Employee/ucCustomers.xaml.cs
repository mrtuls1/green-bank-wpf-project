using GreenBank.classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Interaction logic for ucCustomers.xaml
    /// </summary>
    public partial class ucCustomers : UserControl
    {
        public ucCustomers()
        {
            InitializeComponent();
        }
        MainWindow gk= (MainWindow)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);

        private void btn_customer_add_Click(object sender, RoutedEventArgs e)
        {
            AddCustomer add = new AddCustomer();
            add.Owner = gk;
            gk.Opacity = 1;
            add.ShowDialog();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (GetCustomerProperty.GetCustomers(grd_customers)) { };
        }
        string customer_id;
        private void grd_customers_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            customer_id = ((TextBlock)grd_customers.Columns[0].GetCellContent(grd_customers.SelectedItem)).Text;
            AddCustomer add = new AddCustomer();
            add.btn_customer_add.Visibility = Visibility.Collapsed;
            add.btn_customer_edit.Visibility = Visibility.Visible;
            add.btn_customer_delete.Visibility = Visibility.Visible;
            add.customer_id = customer_id;
            add.ShowDialog();
        }
    }
}
