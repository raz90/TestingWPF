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

namespace WpfHello
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            WpfHello.new_schemaDataSet new_schemaDataSet = ((WpfHello.new_schemaDataSet)(this.FindResource("new_schemaDataSet")));
            // Load data into the table user. You can modify this code as needed.
            WpfHello.new_schemaDataSetTableAdapters.userTableAdapter new_schemaDataSetuserTableAdapter = new WpfHello.new_schemaDataSetTableAdapters.userTableAdapter();
            new_schemaDataSetuserTableAdapter.Fill(new_schemaDataSet.user);
            System.Windows.Data.CollectionViewSource userViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("userViewSource")));
            userViewSource.View.MoveCurrentToFirst();
        }

        
    }
}
