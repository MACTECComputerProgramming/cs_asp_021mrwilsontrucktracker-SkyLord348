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

        public void dateReturnedCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            dateReturned = dateReturnedCalendar.SelectedDate.Value;

            
        }


        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Instatiate variables for driver info, total days driven, total miles, total pay

            int socialSecurity = int.Parse(textBoxSocialSecurity.Text);
            int phone = int.Parse(textBoxPhone.Text);

            




           

            //Format driver info
            string driverName = string.Format("Driver - {0}", textBoxName.Text);

            string socialSecurityNumber = string.Format("Social Security Number # {0: 000-00-0000}", socialSecurity);

            string phoneNumber = string.Format("Phone Number: {0: (000)000-0000} ", phone);



            //Get Total Days out
            TimeSpan daysOut = dateReturned - dateLeft;

            int days = daysOut.Days;

            string totalDays = string.Format("Total Days Out {0}", days);



            //Get Days Off
            int num1 = days;

            int num2 = num1 % 5;

            int num3 = num1 - num2;

            int num4 = num3 / 5;

            int vacationDays = num4 * 2;

            string totalVacDays = string.Format("Vacation Days Earned: {0}", vacationDays);



            // Get Total miles
            int startMiles = int.Parse(startMilesTextBox.Text);
            int endMiles = int.Parse(endMilesTextBox.Text);
            int milesTotal = endMiles - startMiles;
            string totalMiles = string.Format("Total Miles: {0}", milesTotal);





            //Get Total Pay
             if (refridgeratedCheckBox.IsChecked == true)
             {
                double moneyEarned = milesTotal * 0.37;

                string amountPaid = string.Format("Total Pay Due: {0:c}", moneyEarned);

                resultlabel6.Content = amountPaid;
            }
             else
             {
                double moneyEarned = milesTotal * 0.25;

                string amountPaid = string.Format("Total Pay Due: {0:c}", moneyEarned);

                resultlabel6.Content = amountPaid;
             }

             
             

             





             //Print ticket
            resultlabel1.Content = driverName;
            resultlabel2.Content = socialSecurityNumber;
            resultlabel3.Content = phoneNumber;
            resultlabel4.Content = totalMiles;
            resultlabel5.Content = totalDays;
            resultlabel7.Content = totalVacDays;



        }
    }
}
