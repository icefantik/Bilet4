using System;
using System.Collections.Generic;
using System.Data;
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

namespace ExamBilet
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Database database = new Database();
        public MainWindow()
        {
            InitializeComponent();
            FillTable();
        }

        private void ClickBackorders(object sender, RoutedEventArgs e)
        {
            LargestNumberOutstandApp largestNumberOutstandApp = new LargestNumberOutstandApp();
            largestNumberOutstandApp.Show();
        }

        private void ClickOpenSumRequests(object sender, RoutedEventArgs e)
        {
            SumRequestsPlanDates sumRequestsPlanDates = new SumRequestsPlanDates();
            sumRequestsPlanDates.Show();
        }
        private void ClickAdd(object sender, RoutedEventArgs e)
        {
            AddSpecification addSpecification = new AddSpecification();
            addSpecification.Show();
        }
        private void ClickDelete(object sender, RoutedEventArgs e)
        {
            EnterId enterId = new EnterId();
            enterId.Show();
        }
        private void ClickEdit(object sender, RoutedEventArgs e)
        {
            EditSpecification editSpecification = new EditSpecification();
            editSpecification.Show();
        }
        private void UpdateTable(object sender, RoutedEventArgs e)
        {
            FillTable();
        }
        private void FillTable()
        {
            table.ItemsSource = Database.GetListOrderFurnt();
        }
    }
}
