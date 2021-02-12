using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AdoPet
{
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class Calculator : Window
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            try
            {
                double Weight = 0;
                double Result = 0;
                Weight = int.Parse(txbWeight.Text);
                if ((bool)rbJunior.IsChecked)
                {
                    if (Weight >= 1 && Weight <= 40)
                    {
                        if ((bool)rbJunior.IsChecked && Weight >= 1 && Weight <= 5)
                        {
                            Result = Weight * 37;
                        }
                        else if ((bool)rbJunior.IsChecked && Weight >= 6 && Weight <= 10)
                        {
                            Result = Weight * 28;
                        }
                        else if ((bool)rbJunior.IsChecked && Weight >= 11 && Weight <= 20)
                        {
                            Result = Weight * 23;
                        }
                        else if ((bool)rbJunior.IsChecked && Weight >= 21 && Weight <= 30)
                        {
                            Result = Weight * 20;
                        }
                        else if ((bool)rbJunior.IsChecked && Weight >= 31 && Weight <= 40)
                        {
                            Result = Weight * 19;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Podaj wagę zwierzaka z przedziału 1 do 40 kg");
                    }
                }
                else if((bool)rbAdult.IsChecked)
                {
                    if(Weight >= 1 && Weight <= 50)
                    {

                        if ((bool)rbAdult.IsChecked && Weight >= 1 && Weight <= 5)
                        {
                            Result = Weight * 26;

                        }
                        else if ((bool)rbAdult.IsChecked && Weight >= 6 && Weight <= 10)
                        {
                            Result = Weight * 19;
                        }
                        else if ((bool)rbAdult.IsChecked && Weight >= 11 && Weight <= 20)
                        {
                            Result = Weight * 16;
                        }
                        else if ((bool)rbAdult.IsChecked && Weight >= 21 && Weight <= 30)
                        {
                            Result = Weight * 14;
                        }
                        else if ((bool)rbAdult.IsChecked && Weight >= 31 && Weight <= 40)
                        {
                            Result = Weight * 13;
                        }
                        else if ((bool)rbAdult.IsChecked && Weight >= 41 && Weight <= 50)
                        {
                            Result = Weight * 12;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Podaj wagę zwierzaka z przedziału 1 do 50 kg");
                    }
                }
               else if ((bool)rbSenior.IsChecked)
                {
                    if (Weight >= 1 && Weight <= 90)
                    {
                        if ((bool)rbSenior.IsChecked && Weight >= 1 && Weight <= 5)
                        {
                            Result = Weight * 20;

                        }
                        else if ((bool)rbSenior.IsChecked && Weight >= 6 && Weight <= 10)
                        {
                            Result = Weight * 15;
                        }
                        else if ((bool)rbSenior.IsChecked && Weight >= 11 && Weight <= 20)
                        {
                            Result = Weight * 12;
                        }
                        else if ((bool)rbSenior.IsChecked && Weight >= 21 && Weight <= 30)
                        {
                            Result = Weight * 11;
                        }
                        else if ((bool)rbSenior.IsChecked && Weight >= 31 && Weight <= 40)
                        {
                            Result = Weight * 10;
                        }
                        else if ((bool)rbSenior.IsChecked && Weight >= 41 && Weight <= 50)
                        {
                            Result = Weight * 9;
                        }
                        else if ((bool)rbSenior.IsChecked && Weight >= 51 && Weight <= 90)
                        {
                            Result = Weight * 8;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Podaj wagę zwierzaka z przedziału 1 do 90");
                    }
                }
                else
                {
                    MessageBox.Show("Zaznacz wiek zwierzaka");
                }
                txbResult.Text = Result.ToString() + "g";
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        
    }
}
