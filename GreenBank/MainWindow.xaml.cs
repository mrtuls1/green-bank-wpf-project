using GreenBank.classes;
using GreenBank.classes.Models;
using GreenBank.UController;
using System;
using System.Collections.Generic;
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

namespace GreenBank
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public string employee_id;
        public Employees employees = new Employees();
        public MainWindow()
        {
            InitializeComponent();
            this.MaxWidth = SystemParameters.MaximizedPrimaryScreenWidth;
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }
        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void brdLeftTop_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
          //  this.WindowState = WindowState.Maximized;
          //  grd_MainGridWindow.Margin = new Thickness(0, 0, 0, 15);
            EmployeeUnits employee_units = new EmployeeUnits();
            EmployeeTitles employee_titles = new EmployeeTitles();
            employees = GetEmployeeProperty.GetEmployee(employees, employee_titles, employee_units, employee_id);
            lbl_personal_name.Content = employees.Name+" "+employees.Surname;
            lbl_personal_unit.Content = employee_units.Name;
            lbl_personal_title.Content = employee_titles.Name;
            DatabaseConnection.SqlConnectTest();
            Version.Content = DatabaseConnection.ConnState.ToString();

        }

        private void btn_minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btn_fullscreen_Click(object sender, RoutedEventArgs e)
        {
            if(this.WindowState==WindowState.Normal)
            {
                this.WindowState=WindowState.Maximized;
                grd_MainGridWindow.Margin = new Thickness(0, 0, 0, 15);
            }
            else
            {
                this.WindowState=WindowState.Normal;
                grd_MainGridWindow.Margin = new Thickness(15);
            }
        }

        #region menuButtons
        private void menu_button_customers_Click(object sender, RoutedEventArgs e)
        {
            UcCall.Uc_Add(Content_Icerik, new ucCustomers());
        }

        private void menu_button_payments_Click(object sender, RoutedEventArgs e)
        {
            UcCall.Uc_Add(Content_Icerik,new ucPayments());
        }
        private void menu_button_loans_Click(object sender, RoutedEventArgs e)
        {
            UcCall.Uc_Add(Content_Icerik, new ucLoans());
        }
        private void menu_button_credits_Click(object sender, RoutedEventArgs e)
        {
            UcCall.Uc_Add(Content_Icerik, new ucAccounts());
        }
        #endregion menuButtons
    }
}
