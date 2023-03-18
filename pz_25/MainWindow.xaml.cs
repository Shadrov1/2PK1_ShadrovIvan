﻿using System;
using System.Collections.Generic;
using System.Data;
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

namespace pz_25
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement element in Calcul.Children)
            {
                if (element is Button)
                {
                    ((Button)element).Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;

            if (str == "AC")
            {
                Result.Text = "";
            }
            else if (str == "=")
            {
                string value = new DataTable().Compute(Result.Text, null).ToString();//

                Result.Text = value;
            }
            else
            {
                Result.Text += str;
            }
        }

    }
}