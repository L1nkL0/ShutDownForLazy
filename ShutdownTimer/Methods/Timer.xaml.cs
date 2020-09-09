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
using Process = System.Diagnostics.Process;

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

        

        public string TimeInSecondsForTimer(string h,string m,string s)
        {
            int time = 0;
            time = (Convert.ToInt32(h)*60*60) + (Convert.ToInt32(m) *60) + Convert.ToInt32(s);
            return Convert.ToString(time);
        }


        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("cmd", "/c" + $@"shutdown /s /t {TimeInSecondsForTimer(Hour.Text, Minute.Text, Second.Text)}");    //параметр /c для закрытия консоли
            //MessageBox.Show(TimeInSecondsForTimer(Hour.Text, Minute.Text, Second.Text));
        }


        private void Cancle_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("cmd", "/c" + @"shutdown /a");

        }
    }
}
