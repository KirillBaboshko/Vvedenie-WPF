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

namespace Vvedenie_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //var submitButton = new Button
            //{
            //    Content = "Submit",
            //    FontFamily = new FontFamily("Consolas"),
            //    FontSize = 20.0,
            //    Foreground = Brushes.Green
                
            //};
            //this.Content=submitButton;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           //string text=textBox1.Text;
           // if(text!=" ")
           // {
           //     MessageBox.Show(text);
           // }
        }
        private void submitButton_Click(object sender,RoutedEventArgs e)
        {
            MessageBox.Show("LOX");
        }
    }
}
