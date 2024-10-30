using System;
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
using ClassLibrary1;
using ClassLibrary2;
namespace WpfApp14
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

        private void CalculateCos(object sender, RoutedEventArgs e)
        {
            try
            {
             
                int[] numbers = numbersInput.Text
                    .Split(' ') 
                    .Select(int.Parse) 
                    .ToArray(); 

               
                double sum = numbers
                    .Where(n => n < 3) // Фильтруем числа меньшие 3
                    .Sum(); // Суммируем отфильтрованные числа

               
                double cosSum = Math.Cos(sum); 

               
                resultTextBlock.Text = $"Косинус суммы чисел меньше 3: {cosSum:F4}"; //Вывод результата
                resultTextBlock.Visibility = Visibility.Visible; 
            }
            catch (FormatException)
            {
               
                resultTextBlock.Text = "Некорректный ввод. Пожалуйста, введите целые числа, разделенные пробелом.";
                resultTextBlock.Visibility = Visibility.Visible;
            }
            catch (OverflowException)
            {
             
                resultTextBlock.Text = "Введенные числа слишком большие."; //Ошибки
                resultTextBlock.Visibility = Visibility.Visible; 
            }
        }

        private void ExitApplication(object sender, RoutedEventArgs e)
        {
            Close();
        }

     
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ФИО разработчика: Исаев Арсений  " + "Практическая №2  " + "Ввести n целых чисел. Вычислить косинус (cos) суммы чисел < 3. Результат вывести на экран ");
        }
    }
}
