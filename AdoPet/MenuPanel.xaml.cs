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
    /// Interaction logic for MenuPanel.xaml
    /// </summary>
    public partial class MenuPanel : Window
    {
        public MenuPanel()
        {
            InitializeComponent();
        }

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            if(Tg_Btn.IsChecked==true)
            {
                
                tt_add.Visibility = Visibility.Collapsed;
                tt_calculator.Visibility = Visibility.Collapsed;
                tt_vaccine.Visibility = Visibility.Collapsed;
                tt_email.Visibility = Visibility.Collapsed;
                tt_petList.Visibility = Visibility.Collapsed;
            }
            else
            {
                
                tt_add.Visibility = Visibility.Visible;
                tt_calculator.Visibility = Visibility.Visible;
                tt_vaccine.Visibility = Visibility.Visible;
                tt_email.Visibility = Visibility.Visible;
                tt_petList.Visibility = Visibility.Visible;
            }
        }
        private void Tg_Btn_Unchecked(object sender, RoutedEventArgs e)
        {
            img_bg.Opacity = 1;
        }

        private void Tg_Btn_Checked(object sender, RoutedEventArgs e)
        {
            img_bg.Opacity = 0.3;
        }

        private void BG_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Tg_Btn.IsChecked = false;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Image_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.Owner = this;
            calculator.ShowDialog();
        }

        private void Image_PreviewMouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {
            AddPet addPet = new AddPet();
            addPet.Owner = this;
            addPet.ShowDialog();
        }

        private void Image_PreviewMouseLeftButtonUp_2(object sender, MouseButtonEventArgs e)
        {
            VaccinesPanel vaccine = new VaccinesPanel();
            vaccine.Owner = this;
            vaccine.ShowDialog();
        }

        private void Image_PreviewMouseLeftButtonUp_3(object sender, MouseButtonEventArgs e)
        {
            Email email = new Email();
            email.Owner = this;
            email.ShowDialog();
        }

        private void Image_PreviewMouseLeftButtonUp_4(object sender, MouseButtonEventArgs e)
        {
            PetList petList = new PetList();
            petList.Owner = this;
            petList.ShowDialog();
        }
    }
}
