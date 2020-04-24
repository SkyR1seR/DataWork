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

namespace DataWork
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Class happy = new Class();
        public DateTime data;
        public string[] number { get; set; }
        public string[] month { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            number = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"};

            month = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"};

            DataContext = this;
        }

        private void vchera_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(god.Text) > 0)
            {
                if (Convert.ToInt32(mesac.SelectedIndex) + 1 == 2 && Convert.ToInt32(chislo.SelectedIndex) + 1 > 28)
                {
                    MessageBox.Show("Дата указана неверно!");
                }
                else
                {
                    data = new DateTime(Convert.ToInt32(god.Text), Convert.ToInt32(mesac.SelectedIndex) + 1, Convert.ToInt32(chislo.SelectedIndex) + 1);
                    if (happy.visokosnoe(data))
                    {
                        MessageBox.Show(
                        $"Ваша дата: {Convert.ToString(data.ToShortDateString())}" +
                        $"\nВчерашняя дата: {Convert.ToString(happy.vcherashnee(data).ToShortDateString())}" +
                        $"\nГод високосный!"
                        );
                    }
                    else
                    {
                        MessageBox.Show(
                        $"Ваша дата: {Convert.ToString(data.ToShortDateString())}" +
                        $"\nВчерашняя дата: {Convert.ToString(happy.vcherashnee(data).ToShortDateString())}" +
                        $"\nГод невисокосный!"
                        );
                    }
                }
            }
            else
            {
                MessageBox.Show("Дата указана неверно!");
            }
        }

        private void visokosnost_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(god.Text) > 0)
            {
                if (Convert.ToInt32(mesac.SelectedIndex) + 1 == 2 && Convert.ToInt32(chislo.SelectedIndex) + 1 > 28)
                {
                    MessageBox.Show("Дата указана неверно!");
                }
                else
                {
                    data = new DateTime(Convert.ToInt32(god.Text), Convert.ToInt32(mesac.SelectedIndex) + 1, Convert.ToInt32(chislo.SelectedIndex) + 1);
                    if (happy.visokosnoe(data))
                    {
                        MessageBox.Show(
                        $"Ваша дата: {Convert.ToString(data.ToShortDateString())}" +
                        $"\nДней до конца месяца: {happy.daysLeft(data)}" +
                        $"\nГод високосный!"
                        );
                    }
                    else
                    {
                        MessageBox.Show(
                        $"Ваша дата: {Convert.ToString(data.ToShortDateString())}" +
                        $"\nДней до конца месяца: {happy.daysLeft(data)}" +
                        $"\nГод невисокосный!"
                        );
                    }
                }
            }
            else
            {
                MessageBox.Show("Дата указана неверно!");
            }
        }

        private void zavtra_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(god.Text) > 0)
            {
                if (Convert.ToInt32(mesac.SelectedIndex) + 1 == 2 && Convert.ToInt32(chislo.SelectedIndex) + 1 > 28)
                {
                    MessageBox.Show("Дата указана неверно!");
                }
                else
                {
                    if (happy.visokosnoe(data))
                    {
                        MessageBox.Show(
                        $"Ваша дата: {Convert.ToString(data.ToShortDateString())}" +
                        $"\nЗавтрашняя дата: {Convert.ToString(happy.zavtrashnee(data).ToShortDateString())}" +
                        $"\nГод високосный!"
                        );
                    }
                    else
                    {
                        MessageBox.Show(
                        $"Ваша дата: {Convert.ToString(data.ToShortDateString())}" +
                        $"\nЗавтрашняя дата: {Convert.ToString(happy.zavtrashnee(data).ToShortDateString())}" +
                        $"\nГод невисокосный!"
                        );
                    }
                }
            }
            else
            {
                MessageBox.Show("Дата указана неверно!");
            }
        }
    }
}
