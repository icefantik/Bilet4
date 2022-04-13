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
    /// Логика взаимодействия для EditSpecification.xaml
    /// </summary>
    public partial class EditSpecification : Window
    {
        public EditSpecification()
        {
            InitializeComponent();
        }
        private void ClickEdit(object sender, RoutedEventArgs e)
        {
            Database.RunQuery($"exec EditSpecification @enterid = {id.Text}, @entername = \'{name.Text}\'");
            this.Hide();
        }
    }
}
