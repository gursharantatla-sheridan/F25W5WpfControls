﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace F25W5WpfControls
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

        private void btnGetHobbies_Click(object sender, RoutedEventArgs e)
        {
            string hobbies = "";

            if (chkGardening.IsChecked == true)
                hobbies += chkGardening.Content + "\n";

            if (chkTravelling.IsChecked == true)
                hobbies += chkTravelling.Content + "\n";

            if (chkSinging.IsChecked == true)
                hobbies += chkSinging.Content + "\n";

            txtOutput.Text = hobbies;
        }

        private void btnGetGender_Click(object sender, RoutedEventArgs e)
        {
            string gender = "";

            if (rdoFemale.IsChecked == true)
                gender = rdoFemale.Content.ToString();
            else if (rdoMale.IsChecked == true)
                gender = rdoMale.Content.ToString();
            else if (rdoOther.IsChecked == true)
                gender = rdoOther.Content.ToString();
            else
                gender = "Please select your gender";

            txtOutput.Text = gender;
        }

        private void btnGetCity_Click(object sender, RoutedEventArgs e)
        {
            if (cmbCities.SelectedIndex > 0)
                txtOutput.Text = cmbCities.Text;
            else
                txtOutput.Text = "Please select your city";
        }

        private void cmbCities_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbCities.SelectedIndex > 0)
                //txtOutput.Text = cmbCities.Text;
                txtOutput.Text = ((ComboBoxItem)cmbCities.SelectedItem).Content.ToString();
            else
                txtOutput.Text = "Please select your city";
        }
    }
}