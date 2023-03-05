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

namespace lab1wpf
{
   
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DatePicker1.SelectedDate = DateTime.Today.AddDays(-1);
        }

        private void DateButtonClicked(object sender, RoutedEventArgs e)
        { 
            Person person = new Person(DatePicker1.SelectedDate.Value);
            if (person.birth > DateTime.Today || person.birth.Year < 1888) MessageBox.Show("Invalid date");
            if (person.birth.Day == DateTime.Today.Day && person.birth.Month == DateTime.Today.Month) BirthdayText.Text = "Happy Birthday!"; else { BirthdayText.Text = ""; }
            BirthText.Text = "You are " + person.CalculateYears().ToString() + " years old\nYour Chinese sign is " + person.chineseSign + "\nYour Western sign is " + person.westernSign;
            
        }
    }
}
