using GreenBank.classes;
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
using System.Windows.Shapes;

namespace GreenBank.View
{
    /// <summary>
    /// Interaction logic for AddLoan.xaml
    /// </summary>
    public partial class AddLoan : Window
    {
        Loans loan = new Loans();
        Accounts account = new Accounts();
        Customers customer = new Customers();
        List<Customers> customerList = new List<Customers>();
        List<Branches> branchesList = new List<Branches>();
        List<AccountTypes> accountTypes = new List<AccountTypes>();
        public string account_id = null;

        public AddLoan()
        {
            InitializeComponent();
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
                if (GetLoanProperty.FillPage(account,loan, account_id))
                {
                    cmb_account_type.SelectedValue = account.Account_type_id;
                    cmb_branch.SelectedValue = account.Branch_id;
                    cmb_customer.SelectedValue = account.Customer_id;
                    txt_account_name.Text = account.Name;
                    txt_description.Text = account.Description;

                    txt_loan_expiry.Text = loan.Expiry.ToString();
                    txt_loan_interest.Text = loan.Interest.ToString();
                    txt_loan_quantity.Text = loan.Quantity.ToString();
                    txt_loan_installment.Text = loan.Installment.ToString();
                    dtp_starting_date.Text = loan.Starting_date.ToString();
                    dtp_starting_date.IsEnabled = false;
                }
            }
        }

        private void border_left_top_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); 
        }

        private void btn_account_delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_account_add_Click(object sender, RoutedEventArgs e)
        {
            loan.Interest = float.Parse(txt_loan_interest.Text);
            loan.Expiry = float.Parse(txt_loan_expiry.Text);
            loan.Installment= int.Parse(txt_loan_installment.Text);
            loan.Starting_date= dtp_starting_date.DisplayDate;
            loan.End_date= DateTime.Now.Date;

            account.Name = txt_account_name.Text;
            account.Description = txt_description.Text;
            account.Branch_id = int.Parse(cmb_branch.SelectedValue.ToString());
            account.Account_type_id = int.Parse(cmb_account_type.SelectedValue.ToString());
            account.Opening_date = DateTime.Now.ToString();
            customer.Id = int.Parse(cmb_customer.SelectedValue.ToString());

            GetLoanProperty.AddLoans(loan, account,customer);
        }

        private void btn_account_edit_Click(object sender, RoutedEventArgs e)
        {
            account.Name = txt_account_name.Text;
            account.Description = txt_description.Text;
            account.Account_type_id = int.Parse(cmb_account_type.SelectedValue.ToString());
            account.Branch_id = int.Parse(cmb_branch.SelectedValue.ToString());

            loan.Interest = float.Parse(txt_loan_interest.Text);
            loan.Expiry = float.Parse(txt_loan_expiry.Text);
            loan.Quantity= float.Parse(txt_loan_quantity.Text);
            loan.Installment= int.Parse(txt_loan_installment.Text);

            if (GetLoanProperty.EditLoans(account, loan, account_id)) { }
        }
    }
}
