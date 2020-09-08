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

namespace ShutdownTimer.Methods
{
    /// <summary>
    /// Логика взаимодействия для Timer.xaml
    /// </summary>
    public partial class Timer : Page
    {
        public Timer()
        {
            InitializeComponent();

            try
            {
                for (int i = 0; i < 25; i++)
                {
                    Hour.Items.Add(i);
                }

                Hour.SelectedIndex = 0;

                for (int i = 0; i < 61; i++)
                {
                    Minute.Items.Add(i);
                }

                Minute.SelectedIndex = 0;

                for (int i = 0; i < 61; i++)
                {
                    Second.Items.Add(i);
                }

                Second.SelectedIndex = 0;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        public string h  ;

        public string _h()
        {
            string h = Hour.SelectedItem.ToString();
            return h;
        }

        private void Hour_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Hour.SelectedIndex = Hour.SelectedIndex;
        }
    }
}
