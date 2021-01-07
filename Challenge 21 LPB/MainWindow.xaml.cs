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

namespace Challenge_21_LPB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public DateTime dateLeft, dateReturned;
        public void dateLeftCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {

            dateLeft = dateLeftCalendar.SelectedDate.Value;


        }






        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Instatiate variables for driver info, total days driven, total miles, total pay

            int socialSecurity = int.Parse(textBoxSocialSecurity.Text);
            int phone = int.Parse(textBoxPhone.Text);

            int startMiles = int.Parse(startMilesTextBox.Text);
            int endMiles = int.Parse(endMilesTextBox.Text);
            int milesTotal = endMiles - startMiles;




            //Format driver info
            string driverName = string.Format("Driver - {0}", textBoxName.Text);

            string socialSecurityNumber = string.Format("Social Security Number # {0: 000-00-0000}", socialSecurity);

            string phoneNumber = string.Format("Phone Number: {0: (000)000-0000} ", phone);

            string totalMiles = string.Format("Total Miles: {0}", milesTotal);

            resultlabel1.Content = driverName;
            resultlabel2.Content = socialSecurityNumber;
            resultlabel3.Content = phoneNumber;
            resultlabel4.Content = totalMiles;





        }
    }
}
