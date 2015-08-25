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

namespace WpfGreatProject
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

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Enter(object sender, RoutedEventArgs e)
        {
            
            if ((UserName.Text == "hola") & (Password.Password == "hola") & ((bool)ChangePassword.IsChecked))
            {
                WpfChangePassword WchangePassword = new WpfChangePassword();
                WchangePassword.Show();
                WchangePassword = null;
                
                
            }
            else if ((UserName.Text == "hola") & (Password.Password == "hola")) 
            {
                Menu menu = new Menu();
                menu.Show();
                menu = null;
                this.Close();
            }
            
            else
            {
                MessageBox.Show("Incorrect Password");
            }

            
        }

        
    }
}
