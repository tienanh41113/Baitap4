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

namespace veMayBay
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double Tong = 0;
        string sex, ve, tien, nuoc;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void male_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)male.IsChecked)
            {
                sex = male.Content.ToString();
            }
        }
        private void female_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)female.IsChecked)
            {
                sex = female.Content.ToString();
            }
        }
        private void bed_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)bed.IsChecked)
            {
                ve = bed.Content.ToString();
                Tong = 500000;
            }
        }
        private void chair_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)chair.IsChecked)
            {
                ve = chair.Content.ToString();
                Tong = 200000;
            }
        }
        private void TicketBoking_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem selectedType = (nationality.SelectedItem as ListBoxItem);
            if (selectedType.Name == "vietnam")
            {
                if ((bool)usd.IsChecked)
                {
                    tien = usd.Content.ToString();
                    Tong /= 20000;
                }
                else
                    if ((bool)vnd.IsChecked)
                    {
                        tien = vnd.Content.ToString();
                    }
                Tong = Tong * 0.8;
            }
            nuoc = selectedType.Content.ToString();
            MessageBox.Show("Tên: " + name.Text
                            + "\nSố điện thoại: " + phone.Text
                            + "\nGiới tính: " + sex
                            + "\nQuốc tịch: " + nuoc
                            + "\nLoại vé: " + ve
                            + "\nThanh toán: " + tien
                            + "\nTiền: " + Tong);
        }
    }
}
