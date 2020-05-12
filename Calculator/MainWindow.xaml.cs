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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClearAll_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Resault.Text = "";
        }

        private void Stepen_Click(object sender, RoutedEventArgs e)
        {
            ResClass.operation = 5;
            try
            {
                ResClass.a = Convert.ToDouble(this.Resault.Text);
                this.Resault.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("I spotted an error in your number\nYou better fix it");
            }
        }

        private void Square_Click(object sender, RoutedEventArgs e)
        {
            ResClass.operation = 6;
            try
            {
                ResClass.a = Convert.ToDouble(this.Resault.Text);
                this.Resault.Text = $"{ResClass.Get_Resault(ResClass.operation, ResClass.a, ResClass.b).ToString()}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("I spotted an error in your number\nYou better fix it");
            }
        }

        private void ClearEnd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ResClass.Resault_copy = this.Resault.Text;
                this.Resault.Text = $"{ResClass.Resault_copy.Remove(this.Resault.Text.Length - 1)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("There's no number");
            }
        }

        private void Delit_Click(object sender, RoutedEventArgs e)
        {
            ResClass.operation = 4;
            try
            {
                ResClass.a = Convert.ToDouble(this.Resault.Text);
                this.Resault.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("I spotted an error in your number\nYou better fix it");
            }
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            if (this.Resault.Text.Length == 12) MessageBox.Show("Can't count\nThis number is too big");
            else this.Resault.Text = $"{this.Resault.Text}7";
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            if (this.Resault.Text.Length == 12) MessageBox.Show("Can't count\nThis number is too big");
            else this.Resault.Text = $"{this.Resault.Text}8";
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            if (this.Resault.Text.Length == 12) MessageBox.Show("Can't count\nThis number is too big");
            else this.Resault.Text = $"{this.Resault.Text}9";
        }

        private void Umnozh_Click(object sender, RoutedEventArgs e)
        {
            ResClass.operation = 3;
            try
            {
                ResClass.a = Convert.ToDouble(this.Resault.Text);
                this.Resault.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("I spotted an error in your number\nYou better fix it");
            }
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            if (this.Resault.Text.Length == 12) MessageBox.Show("Can't count\nThis number is too big");
            else this.Resault.Text = $"{this.Resault.Text}4";
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            if (this.Resault.Text.Length == 12) MessageBox.Show("Can't count\nThis number is too big");
            else this.Resault.Text = $"{this.Resault.Text}5";
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            if (this.Resault.Text.Length == 12) MessageBox.Show("Can't count\nThis number is too big");
            else this.Resault.Text = $"{this.Resault.Text}6";
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            ResClass.operation = 2;
            try
            {
                ResClass.a = Convert.ToDouble(this.Resault.Text);
                this.Resault.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("I spotted an error in your number\nYou better fix it");
            }
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            if (this.Resault.Text.Length == 12) MessageBox.Show("Can't count\nThis number is too big");
            else this.Resault.Text = $"{this.Resault.Text}1";
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if (this.Resault.Text.Length == 12) MessageBox.Show("Can't count\nThis number is too big"); 
            else this.Resault.Text = $"{this.Resault.Text}2";
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            if (this.Resault.Text.Length == 12) MessageBox.Show("Can't count\nThis number is too big"); 
            else this.Resault.Text = $"{this.Resault.Text}3";
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            ResClass.operation = 1;
            try
            {
                ResClass.a = Convert.ToDouble(this.Resault.Text);
                this.Resault.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("I spotted an error in your number\nYou better fix it");
            }
        }
        //Convert to oposite sign
        private void Oposite_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Convert.ToDouble(this.Resault.Text) < 0)
                {
                    double a = Convert.ToDouble(this.Resault.Text);
                    double b = a + 2 * Math.Abs(a);
                    this.Resault.Text = $"{b}";
                }
                else
                {
                    double a = Convert.ToDouble(this.Resault.Text);
                    double b = a - 2 * Math.Abs(a);
                    this.Resault.Text = $"{b}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect number");
            }
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            this.Resault.Text = $"{this.Resault.Text}0";
        }

        private void Dot_Click(object sender, RoutedEventArgs e)
        {
            this.Resault.Text = $"{this.Resault.Text},";
        }

        private void Resault_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ResClass.b = Convert.ToDouble(this.Resault.Text);
                if (ResClass.b == 0 && ResClass.operation == 4) MessageBox.Show("You can't do it because of 'Zero' number");
                else this.Resault.Text = $"{ResClass.Get_Resault(ResClass.operation, ResClass.a, ResClass.b).ToString()}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something've gone wrong\nWe are working on solution to this problem");
            }
        }
    }
}
