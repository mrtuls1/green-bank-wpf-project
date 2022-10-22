using GreenBank.classes.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace GreenBank.View
{
    /// <summary>
    /// Interaction logic for AddAccount.xaml
    /// </summary>
    public partial class AddAccount : Window
    {
        List<Customers> customerList=new List<Customers>();
        List<Branches> branchesList =new List<Branches>();
        List<AccountTypes> accountTypes= new List<AccountTypes>();
        Customers customer=new Customers();
        Accounts account = new Accounts();
        public string account_id = null;

        public AddAccount()
        {
            InitializeComponent();
        }

        private void btn_account_delete_Click(object sender, RoutedEventArgs e)
        {
            if (GetAccountProperty.DeleteAccounts(account,account_id)) { }
        }

        private void btn_account_edit_Click(object sender, RoutedEventArgs e)
        {
            account.Name = txt_account_name.Text;
            account.Description = txt_description.Text;
            account.Account_type_id = int.Parse(cmb_account_type.SelectedValue.ToString());
            account.Branch_id= int.Parse(cmb_branch.SelectedValue.ToString());
            if (GetAccountProperty.EditAccount(account,account_id)) { }
        }

        private void btn_account_add_Click(object sender, RoutedEventArgs e)
        {
            account.Name = txt_account_name.Text;
            account.Description = txt_description.Text;
            account.Branch_id = int.Parse(cmb_branch.SelectedValue.ToString());
            account.Account_type_id = int.Parse(cmb_account_type.SelectedValue.ToString());
            account.Opening_date = DateTime.Now.ToString();
            customer.Id = int.Parse(cmb_customer.SelectedValue.ToString());
            if (GetAccountProperty.AddCustomers(account,customer)) {}
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (GetAccountProperty.FillCustomers(customerList))
            {
                cmb_customer.ItemsSource = customerList;
                cmb_customer.DisplayMemberPath = "Name";
                cmb_customer.SelectedValuePath = "Id";
            }
            if (GetAccountProperty.FillAccountTypes(accountTypes))
            {
                cmb_account_type.ItemsSource = accountTypes;
                cmb_account_type.DisplayMemberPath = "Name";
                cmb_account_type.SelectedValuePath = "Id";
            }
            if (GetAccountProperty.FillBranches(branchesList))
            {
                cmb_branch.ItemsSource = branchesList;
                cmb_branch.DisplayMemberPath = "Name";
                cmb_branch.SelectedValuePath = "Id";
            }

            if (account_id != null)
            {
                if(GetAccountProperty.FillPage(account,account_id))
                {
                    cmb_account_type.SelectedValue = account.Account_type_id;
                    cmb_branch.SelectedValue = account.Branch_id;
                    cmb_customer.SelectedValue = account.Customer_id;
                    txt_account_name.Text = account.Name;
                    txt_description.Text = account.Description;

                }
            }

        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void border_left_top_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }
    }
}
