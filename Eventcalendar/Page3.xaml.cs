using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace Eventcalendar
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public class CheckBoxData
        {
            public bool CheckBox1 { get; set; }
            public bool CheckBox2 { get; set; }
            public bool CheckBox3 { get; set; }
        }
        public Page3()
        {
            InitializeComponent();
            LoadCheckBoxData();
        }
        public static void SaveCheckBoxData(CheckBoxData data)
        {
            string json = JsonConvert.SerializeObject(data);
            File.WriteAllText("checkboxdata.json", json);
        }

        public static CheckBoxData LoadCheckBoxData()
        {
            if (File.Exists("checkboxdata.json"))
            {
                string json = File.ReadAllText("checkboxdata.json");
                return JsonConvert.DeserializeObject<CheckBoxData>(json);
            }
            else
            {
                return new CheckBoxData();
            }
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CheckBoxData data = new CheckBoxData
            {
                CheckBox1 = checkBox1.IsChecked ?? false,
                CheckBox2 = checkBox2.IsChecked ?? false,
                CheckBox3 = checkBox3.IsChecked ?? false
            };
            SaveCheckBoxData(data);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CheckBoxData data = LoadCheckBoxData();
            checkBox1.IsChecked = data.CheckBox1;
            checkBox2.IsChecked = data.CheckBox2;
            checkBox3.IsChecked = data.CheckBox3;
        }
        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            
            DateTime selectedDate = calendar.SelectedDate ?? DateTime.Today;
            string fileName = $"checkboxdata_{selectedDate:yyyy-MM-dd}.json";
            CheckBoxData data = LoadCheckBoxData(fileName);
            checkBox1.IsChecked = data.CheckBox1;
            checkBox2.IsChecked = data.CheckBox2;
            checkBox3.IsChecked = data.CheckBox3;
        }

        public static void SaveCheckBoxData(CheckBoxData data, string fileName)
        {
            string json = JsonConvert.SerializeObject(data);
            File.WriteAllText(fileName, json);
        }

        public static CheckBoxData LoadCheckBoxData(string fileName)
        {
            if (File.Exists(fileName))
            {
                string json = File.ReadAllText(fileName);
                return JsonConvert.DeserializeObject<CheckBoxData>(json);
            }
            else
            {
                return new CheckBoxData();
            }
        }
    }
}
