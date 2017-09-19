﻿using System.Windows;

namespace HelloWorldGit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnClickMe.Click += (s, e) => MessageBox.Show("Hello, World");
        }
    }
}
