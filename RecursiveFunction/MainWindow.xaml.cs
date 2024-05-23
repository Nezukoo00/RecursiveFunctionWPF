﻿using System;
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

namespace RecursiveFunction
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


        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double baseNumber = double.Parse(BaseTextBox.Text);
                int exponent = int.Parse(ExponentTextBox.Text);
                double result = Power(baseNumber, exponent);
                ResultLabel.Content = result.ToString();
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            

        }
        private double Power(double baseNumber, int exponent)
        {
            if (exponent == 0) return 1;
            else return baseNumber * Power(baseNumber, exponent - 1);
        }
    }
}
