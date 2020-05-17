using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            this.Dot.IsEnabled = true;
            ResClass.operation = 0;
            ResClass.a = 0;
            ResClass.b = 0;
        }

        private void Stepen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ResClass.operation == 5)
                {
                    ResClass.b = Convert.ToDouble(this.Resault.Text);
                    ResClass.a = ResClass.Get_Resault(ResClass.operation, ResClass.a, ResClass.b);
                    this.Resault.Text = "";
                }
                else
                {
                    ResClass.a = Convert.ToDouble(this.Resault.Text);
                    this.Resault.Text = "";
                    ResClass.operation = 5;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("I spotted an error\nTry again or send a message on GitHub");
            }
        }

        private void Square_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ResClass.operation = 6;
                ResClass.a = Convert.ToDouble(this.Resault.Text);
                this.Resault.Text = $"{ResClass.Get_Resault(ResClass.operation, ResClass.a, ResClass.b).ToString()}";
                this.Zero.IsEnabled = true;
                if (!this.Resault.Text.Contains(',')) this.Dot.IsEnabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("I spotted an error\nTry again or send a message on GitHub");
            }
        }

        private void ClearEnd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ResClass.Resault_copy = this.Resault.Text;
                this.Resault.Text = $"{ResClass.Resault_copy.Remove(this.Resault.Text.Length - 1)}";
                if (!this.Resault.Text.Contains(',')) this.Dot.IsEnabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There's no number");
            }
        }

        private void Delit_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                if (ResClass.operation == 4)
                {
                    ResClass.b = Convert.ToDouble(this.Resault.Text);
                    ResClass.a = ResClass.Get_Resault(ResClass.operation, ResClass.a, ResClass.b);
                    this.Resault.Text = "";
                    this.Dot.IsEnabled = true;
                    this.Zero.IsEnabled = true;
                }
                else
                {
                    ResClass.a = Convert.ToDouble(this.Resault.Text);
                    this.Resault.Text = "";
                    ResClass.operation = 4;
                    this.Dot.IsEnabled = true;
                    this.Zero.IsEnabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("I spotted an error in your number\nYou better fix it");
            }
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            if (this.Resault.Text.Length == 12) MessageBox.Show("Can't count\nThis number is too big");
            else
            {
                if (ResClass.operation == 0)
                {
                    this.Resault.Text = "7";
                    ResClass.operation = 7;
                }
                else this.Resault.Text = $"{this.Resault.Text}7";
            }
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            if (this.Resault.Text.Length == 12) MessageBox.Show("Can't count\nThis number is too big");
            else
            {
                if (ResClass.operation == 0)
                {
                    this.Resault.Text = "8";
                    ResClass.operation = 7;
                }
                else this.Resault.Text = $"{this.Resault.Text}8";
            }
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            if (this.Resault.Text.Length == 12) MessageBox.Show("Can't count\nThis number is too big");
            else
            {
                if (ResClass.operation == 0)
                {
                    this.Resault.Text = "9";
                    ResClass.operation = 7;
                }
                else this.Resault.Text = $"{this.Resault.Text}9";
            }
        }

        private void Umnozh_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                if (ResClass.operation == 3)
                {
                    ResClass.b = Convert.ToDouble(this.Resault.Text);
                    ResClass.a = ResClass.Get_Resault(ResClass.operation, ResClass.a, ResClass.b);
                    this.Resault.Text = "";
                    this.Dot.IsEnabled = true;
                    this.Zero.IsEnabled = true;
                }
                else
                {
                    ResClass.a = Convert.ToDouble(this.Resault.Text);
                    this.Resault.Text = "";
                    ResClass.operation = 3;
                    this.Dot.IsEnabled = true;
                    this.Zero.IsEnabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("I spotted an error in your number\nYou better fix it");
            }
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            if (this.Resault.Text.Length == 12) MessageBox.Show("Can't count\nThis number is too big");
            else
            {
                if (ResClass.operation == 0)
                {
                    this.Resault.Text = "4";
                    ResClass.operation = 7;
                }
                else this.Resault.Text = $"{this.Resault.Text}4";
            }
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            if (this.Resault.Text.Length == 12) MessageBox.Show("Can't count\nThis number is too big");
            else
            {
                if (ResClass.operation == 0)
                {
                    this.Resault.Text = "5";
                    ResClass.operation = 7;
                }
                else this.Resault.Text = $"{this.Resault.Text}5";
            }
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            if (this.Resault.Text.Length == 12) MessageBox.Show("Can't count\nThis number is too big");
            else
            {
                if (ResClass.operation == 0)
                {
                    this.Resault.Text = "6";
                    ResClass.operation = 7;
                }
                else this.Resault.Text = $"{this.Resault.Text}6";
            }
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                if (ResClass.operation == 2)
                {
                    ResClass.b = Convert.ToDouble(this.Resault.Text);
                    ResClass.a = ResClass.Get_Resault(ResClass.operation, ResClass.a, ResClass.b);
                    this.Resault.Text = "";
                    this.Dot.IsEnabled = true;
                    this.Zero.IsEnabled = true;
                }
                else
                {
                    ResClass.a = Convert.ToDouble(this.Resault.Text);
                    this.Resault.Text = "";
                    ResClass.operation = 2;
                    this.Dot.IsEnabled = true;
                    this.Zero.IsEnabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("I spotted an error in your number\nYou better fix it");
            }
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            if (this.Resault.Text.Length == 12) MessageBox.Show("Can't count\nThis number is too big");
            else
            {
                if(ResClass.operation==0)
                {
                    this.Resault.Text="1";
                    ResClass.operation = 7;
                }
                else this.Resault.Text = $"{this.Resault.Text}1";
            }
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if (this.Resault.Text.Length == 12) MessageBox.Show("Can't count\nThis number is too big");
            else 
            {
                if (ResClass.operation == 0)
                {
                    this.Resault.Text = "2";
                    ResClass.operation = 7;
                }
                else this.Resault.Text = $"{this.Resault.Text}2";
            }
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            if (this.Resault.Text.Length == 12) MessageBox.Show("Can't count\nThis number is too big");
            else
            {
                if (ResClass.operation == 0)
                {
                    this.Resault.Text = "3";
                    ResClass.operation = 7;
                }
                else this.Resault.Text = $"{this.Resault.Text}3";
            }
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                if (ResClass.operation == 1)
                {
                    ResClass.b = Convert.ToDouble(this.Resault.Text);
                    ResClass.a = ResClass.Get_Resault(ResClass.operation, ResClass.a, ResClass.b);
                    this.Resault.Text = "";
                    this.Dot.IsEnabled = true;
                    this.Zero.IsEnabled = true;
                }
                else
                {
                    ResClass.a = Convert.ToDouble(this.Resault.Text);
                    this.Resault.Text = "";
                    ResClass.operation = 1;
                    this.Dot.IsEnabled = true;
                    this.Zero.IsEnabled = true;
                }
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
            
            try
            {
                if (this.Resault.Text.Length == 12) MessageBox.Show("Can't count\nThis number is too big");
                else if (this.Resault.Text.Contains('0') && this.Resault.Text.Length == 1) this.Zero.IsEnabled = false;
                else
                {
                    if (ResClass.operation == 0)
                    {
                        this.Resault.Text = "0";
                        ResClass.operation = 7;
                    }
                    else this.Resault.Text = $"{this.Resault.Text}0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void Dot_Click(object sender, RoutedEventArgs e)
        {
            this.Resault.Text = $"{this.Resault.Text},";
            this.Dot.IsEnabled = false;
            this.Zero.IsEnabled = true;
            
        }

        private void Resault_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ResClass.b = Convert.ToDouble(this.Resault.Text);
                if (ResClass.b == 0 && ResClass.operation == 4) MessageBox.Show("You can't do it because of 'Zero' number");
                else
                {
                    ResClass.Resault_copy = ResClass.Get_Resault(ResClass.operation, ResClass.a, ResClass.b).ToString();
                    if (ResClass.Resault_copy.Length > 12 && ResClass.Resault_copy.Contains(',') == true)
                    {
                        while (ResClass.Resault_copy.Contains(','))
                        {
                            ResClass.Resault_copy = ResClass.Resault_copy.Remove(ResClass.Resault_copy.Length - 1);
                            ResClass.lenth = ResClass.Resault_copy.Length;
                        }
                        this.Resault.Text = $"{Math.Round(ResClass.Get_Resault(ResClass.operation, ResClass.a, ResClass.b), 12 - ResClass.lenth)}";
                    }
                    else if (ResClass.Resault_copy.Length > 12 && ResClass.Resault_copy.Contains(',') == false)
                    {
                        ResClass.Resault = ResClass.Get_Resault(ResClass.operation, ResClass.a, ResClass.b);
                        this.Resault.Text = $"{Math.Round(ResClass.Resault * Math.Pow(10, -(ResClass.Resault_copy.Length - 1)), 2)}E+{ResClass.Resault_copy.Length - 1}";
                    }
                    else this.Resault.Text = $"{ResClass.Get_Resault(ResClass.operation, ResClass.a, ResClass.b).ToString()}";
                }
                ResClass.operation = 0;
                this.Dot.IsEnabled = true;
                this.Zero.IsEnabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something've gone wrong\nWe are working on solution to this problem");
            }
        }
    }
}

//ResClass.Resault = ResClass.Get_Resault(ResClass.operation, ResClass.a, ResClass.b);
//this.Resault.Text = $"{ResClass.Get_Resault(ResClass.operation, ResClass.a, ResClass.b).ToString()}";

/*ResClass.Resault_copy = ResClass.Get_Resault(ResClass.operation, ResClass.a, ResClass.b).ToString();
                    if (ResClass.Resault_copy.Length > 12 && ResClass.Resault_copy.Contains(',') == true)
                    {

                    }
                    else if (ResClass.Resault_copy.Length > 12 && ResClass.Resault_copy.Contains(',') == false)
                    {
                        ResClass.Resault = ResClass.Get_Resault(ResClass.operation, ResClass.a, ResClass.b);
                        this.Resault.Text = $"{Math.Round(ResClass.Resault * Math.Pow(10, -(ResClass.Resault_copy.Length - 1)), 2)}*E{ResClass.Resault_copy.Length - 1}";
                    }
                    else this.Resault.Text = $"{ResClass.Get_Resault(ResClass.operation, ResClass.a, ResClass.b).ToString()}";*/


//if (this.Resault.Text.Length < 1 && ResClass.operation == 0) ResClass.operation = 7;