using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DemoExamCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Ограничение ввода только цифрами
        private void NumericOnly_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !int.TryParse(e.Text, out _);
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            int module1, module2, module3, module4, module5;

            // Проверки и парсинг
            if (!int.TryParse(Module1TextBox.Text, out module1) || module1 < 0 || module1 > 10)
            {
                MessageBox.Show("Баллы за модуль 1 должны быть числом от 0 до 10.");
                return;
            }
            if (!int.TryParse(Module2TextBox.Text, out module2) || module2 < 0 || module2 > 15)
            {
                MessageBox.Show("Баллы за модуль 2 должны быть числом от 0 до 15.");
                return;
            }
            if (!int.TryParse(Module3TextBox.Text, out module3) || module3 < 0 || module3 > 25)
            {
                MessageBox.Show("Баллы за модуль 3 должны быть числом от 0 до 25.");
                return;
            }
            if (!int.TryParse(Module4TextBox.Text, out module4) || module4 < 0 || module4 > 25)
            {
                MessageBox.Show("Баллы за модуль 4 должны быть числом от 0 до 25.");
                return;
            }
            if (!int.TryParse(Module5TextBox.Text, out module5) || module5 < 0 || module5 > 25)
            {
                MessageBox.Show("Баллы за модуль 5 должны быть числом от 0 до 25.");
                return;
            }

            // Суммирование
            int total = module1 + module2 + module3 + module4 + module5;

            // Определение оценки
            string grade;
            if (total >= 90) grade = "5 (отлично)";
            else if (total >= 65) grade = "4 (хорошо)";
            else if (total >= 50) grade = "3 (удовлетворительно)";
            else grade = "2 (неудовлетворительно)";

            // Вывод результата
            ResultTextBlock.Text = $"Сумма: {total}\nОценка: {grade}";
        }
    }
}
