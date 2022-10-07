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

namespace GreenBank.UController
{
    /// <summary>
    /// Interaction logic for AddCustomer.xaml
    /// </summary>
    public partial class AddCustomer : Window
    {
        public string customer_id = null;
        private string selected_country;
        private string selected_city;
        Towns towns = new Towns();
        Cities cities = new Cities();
        Customers customers = new Customers();
        Countries countries = new Countries();
        public AddCustomer()
        {
            InitializeComponent();
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

        private void txt_input_passaport_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void txt_input_phone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }
        MainWindow gk = (MainWindow)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
        private void btn_customer_add_Click(object sender, RoutedEventArgs e)
        {
            customers.Name = txt_input_name.Text;
            customers.Surname = txt_input_surname.Text;
            customers.Email = txt_input_email.Text;
            customers.Password = txt_input_password.Text;
            customers.Phone = txt_input_phone.Text;
            customers.Adress = txt_input_adress.Text;
            customers.Passaport_no = txt_input_passaport.Text;
            customers.Birthday = txt_input_birthday.Text;
            customers.Country = txt_input_country.Text;
            customers.Distric = txt_input_province.Text;
            customers.Province = txt_input_province.Text;

            if (txt_input_gender.IsChecked == true) customers.Gender = "male";
            else if (txt_input_gender2.IsChecked == true) customers.Gender = "female";
            else customers.Gender = "Other";
            if (GetCustomerProperty.AddCustomers(customers)) MessageBox.Show("Ekleme İşlemi Başarılı");

            //InfoPopup pop = new InfoPopup();
            //pop.Owner = gk;
            //pop.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            if (customer_id != null)
            {
                if (GetCustomerProperty.FillCustomers(customers, customer_id))
                {
                    txt_input_name.Text = customers.Name;
                    txt_input_surname.Text = customers.Surname;
                    txt_input_email.Text = customers.Email;
                    txt_input_password.Text = customers.Password;
                    txt_input_phone.Text = customers.Phone;
                    txt_input_passaport.Text = customers.Passaport_no;
                    txt_input_adress.Text = customers.Adress;
                    txt_input_birthday.Text = customers.Birthday;
                    txt_input_country.SelectedValue = customers.Country;
                    txt_input_province.SelectedValue = customers.Province;
                    txt_input_district.SelectedValue = customers.Distric;

                    if (customers.Gender == "male") txt_input_gender.IsChecked = true;
                    else if (customers.Gender == "female") txt_input_gender2.IsChecked = true;
                    else txt_input_gender3.IsChecked= true ;
                }
            }
            if (GetCountriesProperty.FillCountries(countries))
            {
                for (int i = 0; i < countries.CountryNameCollection.Count; i++)
                {
                    txt_input_country.Items.Add(countries.CountryNameCollection[i]);
                }
            }


        }

        private void txt_input_country_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selected_country = txt_input_country.SelectedValue.ToString();
            cities.CityNameCollection.Clear();
            txt_input_province.Items.Clear();
            if (GetCitiesProperty.FillCities(cities, selected_country))
            {
                for (int i = 0; i < cities.CityNameCollection.Count; i++)
                {
                    txt_input_province.Items.Add(cities.CityNameCollection[i]);
                }

            }
        }

        private void txt_input_province_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selected_city = txt_input_province.SelectedValue.ToString();
            towns.TownNameCollection.Clear();
            txt_input_district.Items.Clear();
            if (GetTownProperty.FillTowns(towns, selected_city))
            {
                for (int i = 0; i < towns.TownNameCollection.Count; i++)
                {
                    txt_input_district.Items.Add(towns.TownNameCollection[i]);
                }
            }
        }

        private void btn_customer_edit_Click(object sender, RoutedEventArgs e)
        {
            customers.Name = txt_input_name.Text;
            customers.Surname = txt_input_surname.Text;
            customers.Email = txt_input_email.Text;
            customers.Password = txt_input_password.Text;
            customers.Phone = txt_input_phone.Text;
            customers.Adress = txt_input_adress.Text;
            customers.Passaport_no = txt_input_passaport.Text;
            customers.Birthday = txt_input_birthday.Text;
            customers.Country = txt_input_country.Text;
            customers.Province = txt_input_province.Text;
            customers.Distric = txt_input_district.Text;

            if (txt_input_gender.IsChecked == true) customers.Gender = "male";
            else if (txt_input_gender2.IsChecked == true) customers.Gender = "female";
            else customers.Gender = "Other";
            if (GetCustomerProperty.EditCustomer(customers, customer_id)) MessageBox.Show("Güncelleme İşlemi Başarılı");
        }

        private void btn_customer_delete_Click(object sender, RoutedEventArgs e)
        {
            if(GetCustomerProperty.DeleteCustomers(customers,customer_id))
            {
                MessageBox.Show("Silindi");
            }
        }
    }
}
