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
    /// Interaction logic for ucAccounts.xaml
    /// </summary>
    public partial class ucAccounts : UserControl
    {
        string account_id = "";
        public ucAccounts()
        {
            InitializeComponent();
        }
        private void grd_accounts_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            account_id = ((TextBlock)grd_accounts.Columns[0].GetCellContent(grd_accounts.SelectedItem)).Text;
            AddAccount add= new AddAccount();
            add.btn_account_add.Visibility = Visibility.Collapsed;
            add.btn_account_edit.Visibility = Visibility.Visible;
            add.btn_account_delete.Visibility = Visibility.Visible;
            add.cmb_customer.IsEnabled = false; 
            add.account_id = account_id;
            add.ShowDialog();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (GetAccountProperty.GetAccounts(grd_accounts)) {};
        }
        MainWindow gk = (MainWindow)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
        private void btn_customer_add_Click(object sender, RoutedEventArgs e)
        {
            AddAccount add = new AddAccount();
            add.Owner = gk;
            gk.Opacity = 1;
            add.ShowDialog();
        }
    }
}
