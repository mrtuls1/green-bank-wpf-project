using GreenBank.classes;
using GreenBank.classes.Models;
using GreenBank.UController;
using GreenBank.UController.Customer;
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

namespace GreenBank.View.Customer
{
    /// <summary>
    /// Interaction logic for CustomerMainWindow.xaml
    /// </summary>
    public partial class CustomerMainWindow : Window
    {
        public string customer_id="";
        public CustomerMainWindow()
        {
            InitializeComponent();
        }

        private void menu_button_transactions_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Customers customer = new Customers();
            if (GetCustomerProperty.GetCustomers(customer,customer_id)) { };
            lbl_customer_name.Content= customer.Name+" "+customer.Surname;
        }

        private void menu_button_credits_Click(object sender, RoutedEventArgs e)
        {
            ucAccountCustomer uc = new ucAccountCustomer();
            uc.customer_id = customer_id;
            UcCall.Uc_Add(Content_Icerik, uc);
            
        }

        private void menu_button_payments_Click(object sender, RoutedEventArgs e)
        {

        }

        private void menu_button_loans_Click(object sender, RoutedEventArgs e)
        {

        }

        private void brdLeftTop_MouseDown(object sender, MouseButtonEventArgs e)
        {

            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        private void btn_minimize_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_fullscreen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
