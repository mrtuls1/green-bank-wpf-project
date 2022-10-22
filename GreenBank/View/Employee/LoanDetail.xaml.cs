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
using System.Windows.Shapes;

namespace GreenBank.View
{
    /// <summary>
    /// Interaction logic for LoanDetail.xaml
    /// </summary>
    public partial class LoanDetail : Window
    {
        public string account_id = "";
        public LoanDetail()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (GetPaymentsProperty.GetPayment(grd_loan,account_id)) { }

        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void border_left_top_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(Mouse.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
    }
}
