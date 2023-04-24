using System;
using System.Collections.Generic;
using System.IO;
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
using Newtonsoft.Json;

namespace Eventcalendar
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dictionary<DateTime, string> activities = new Dictionary<DateTime, string>();
        private string filePath = "activities.json";
        public MainWindow()
        {
            InitializeComponent();
            day();
            LoadActivities();
        }
        private void LoadActivities()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                activities = JsonConvert.DeserializeObject<Dictionary<DateTime, string>>(json);
            }
        }
        private void SaveActivities()
        {
            string json = JsonConvert.SerializeObject(activities);
            File.WriteAllText(filePath, json);
        }
        public void day()
        {
            t1.Text = DateTime.Now.ToString("dd.MM.yyyy");
            DateTime selectedDates = calendar.SelectedDate ?? DateTime.Today;
            int daysInMonth = DateTime.DaysInMonth(selectedDates.Year, selectedDates.Month);
            int a = 30;
            int b = 29;
            int c = 31;
            int v = 28;
            if (daysInMonth == b)
            {
                MainWindow window = Application.Current.MainWindow as MainWindow;
                window.Page1.Content = null;
                Page2.Content = new Page2();
            }
            else if (daysInMonth == a)
            {
                MainWindow window = Application.Current.MainWindow as MainWindow;
                window.Page2.Content = null;
                Page1.Content = new Page1();
            }
            else if (daysInMonth == c)
            {
                MainWindow window = Application.Current.MainWindow as MainWindow;
                window.Page1.Content = null;
                Page2.Content = new Page2();
            }
            else if (daysInMonth == v)
            {
                MainWindow window = Application.Current.MainWindow as MainWindow;
                window.Page1.Content = null;
                Page2.Content = new Page2();
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Page3 p = new Page3();
            DateTime selectedDate = (DateTime)calendar.SelectedDate;
            string activity = nap.Text;
            activities[selectedDate] = activity;
            SaveActivities();
        }
        private void Calendar_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            day();
            soxr();
        }
        public void soxr()
        {
            DateTime selectedDate = (DateTime)calendar.SelectedDate;
            if (activities.ContainsKey(selectedDate))
            {
                vav.Text = activities[selectedDate];
            }
            else
            {
                vav.Text = "";
            }
        }

    }
}
