﻿using Desktop.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Desktop
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Кнопка "Назад"
        /// </summary> 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
        /// <summary>
        /// Кнопка "Зарегистрироваться" 
        /// </summary> 
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string name = textBox.Text;
            string email = textBox1.Text;
            string password = textBox2.Text;
            string password2 = textBox3.Text;

            if (!name.IsValidName())
            {
                MessageBox.Show("Имя должно содержать не менее 3 символов!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!email.IsValidEmail())
            {
                MessageBox.Show("Неверный формат почты! Должно быть в формате *ex@ee.com*", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!InputValidator.IsValidPassword(password))
            {
                MessageBox.Show("Пароль должен содержать не менее 6 символов!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (password != password2)
            {
                MessageBox.Show("Пароли не совпадают!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Window2 win2 = new Window2();
            win2.Show();
            this.Close();
        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            UpdateWatermark();
        }
        private void UpdateWatermark()
        {
            watermark.Visibility = string.IsNullOrWhiteSpace(textBox.Text) ? Visibility.Visible : Visibility.Collapsed;
        }

        private void TextBox_TextChanged1(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            UpdateWatermark1();
        }
        private void UpdateWatermark1()
        {
            watermark1.Visibility = string.IsNullOrWhiteSpace(textBox1.Text) ? Visibility.Visible : Visibility.Collapsed;
        }

        private void TextBox_TextChanged2(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            UpdateWatermark2();
        }
        private void UpdateWatermark2()
        {
            watermark2.Visibility = string.IsNullOrWhiteSpace(textBox2.Text) ? Visibility.Visible : Visibility.Collapsed;
        }

        private void TextBox_TextChanged3(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            UpdateWatermark3();
        }
        private void UpdateWatermark3()
        {
            watermark3.Visibility = string.IsNullOrWhiteSpace(textBox3.Text) ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}
