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


namespace WpfHello
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

       

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string file_name = "test.txt";

            System.IO.StreamWriter objWriter; 
            objWriter= new System.IO.StreamWriter(file_name);
            objWriter.Write(textbox1.Text);
            objWriter.Close();

            

            MessageBox.Show("wrote file");

            
        }

        private void SaveButton_TextInput(object sender, TextCompositionEventArgs e)
        {

           
            
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Window1 windows1;

            windows1 = new Window1();

            windows1.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MDIParent1 windows2;

            windows2 = new MDIParent1();

            windows2.Show();
        }

    }
}
