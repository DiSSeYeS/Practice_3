using System;
using System.Windows;

namespace Practice_3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, RoutedEventArgs e)
        {

            if (double.TryParse(number_1_enter.Text, out double num_1) && double.TryParse(number_2_enter.Text, out double num_2) && double.TryParse(number_3_enter.Text, out double num_3))
            {

                double number_1 = Convert.ToDouble(number_1_enter.Text);
                double number_2 = Convert.ToDouble(number_2_enter.Text);
                double number_3 = Convert.ToDouble(number_3_enter.Text);

                if (number_1 == number_2 | number_2 == number_3 | number_1 == number_3)
                {
                    MessageBox.Show("Введите разные числа для вычисления экстремума", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                if (maximum.IsChecked == true)
                {
                    answer.Text = Convert.ToString(Math.Max(number_1, Math.Max(number_2, number_3)));
                }

                else if (minimum.IsChecked == true)
                {
                    answer.Text = Convert.ToString(Math.Min(number_1, Math.Min(number_2, number_3)));
                }

                else
                {
                    MessageBox.Show("Выберите вид экстремума", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }

            else
            {
                MessageBox.Show("Введите числа, желаемые для вычисления экстремума", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }  

    }

}
