﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace CalcHelperDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _NavigationFrame.Navigate(new Pages.Welcome());
            VersionLabel.Content = $"Version: {Assembly.GetExecutingAssembly().GetName().Version}";
        }

        private void StartNavbarItem_Click(object sender, RoutedEventArgs e)
        {
            _NavigationFrame.Navigate(new Pages.Welcome());
        }

        private void TransitionCurvesNavbarItem_Click(object sender, RoutedEventArgs e)
        {
            _NavigationFrame.Navigate(new Pages.TransitionCurves());
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if(this.Width < MinWidth)
            {
                this.Width = MinWidth;
                MessageBox.Show($"Minimalna szerokość okna wynosi: {MinWidth} px!");
            }

            if (this.Height < MinHeight)
            {
                this.Width = MinHeight;
                MessageBox.Show($"Minimalna wysokość okna wynosi: {MinHeight} px!");
            }
        }
    }
}
