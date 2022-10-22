using GreenBank.classes;
using GreenBank.classes.Models;
using GreenBank.View;
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
    /// Interaction logic for ucLoans.xaml
    /// </summary>
    public partial class ucLoans : UserControl
    {
        Loans loan = new Loans();
        string account_id = "";
        public ucLoans()
        {
            InitializeComponent();
        }

        private void btn_loan_add_Click(object sender, RoutedEventArgs e)
        {
            AddLoan add = new AddLoan();
            add.ShowDialog();
        }

        private void grd_loans_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            account_id = ((TextBlock)grd_loans.Columns[3].GetCellContent(grd_loans.SelectedItem)).Text;
            AddLoan add = new AddLoan();
            add.account_id = account_id;
            add.btn_account_add.Visibility = Visibility.Collapsed;
            add.btn_account_edit.Visibility = Visibility.Visible;
            add.btn_account_delete.Visibility = Visibility.Visible;
            add.cmb_customer.IsEnabled = false;
            add.ShowDialog();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (GetLoanProperty.GetLoans(grd_loans)) { };
        }
    }
}
