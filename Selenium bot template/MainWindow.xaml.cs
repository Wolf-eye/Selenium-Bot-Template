﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Selenium_bot_template
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ManualResetEvent mre = new ManualResetEvent(true);
        Bot bot = new Bot();
        Thread botThread;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StatButton_Click(object sender, RoutedEventArgs e)
        {
            botThread = new Thread(bot.BotActions);
            botThread.Start();
        }
    }
}