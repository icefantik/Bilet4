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

namespace ExamBilet
{
    /// <summary>
    /// Логика взаимодействия для EnterId.xaml
    /// </summary>
    public partial class EnterId : Window
    {
        public EnterId()
        {
            InitializeComponent();
        }
        private void ClickDeleteOnId(object sender, RoutedEventArgs e)
        {
            Database.RunQuery($"exec DelOnIdOrder @enterid={id.Text}");
            this.Hide();
        }
    }
}
