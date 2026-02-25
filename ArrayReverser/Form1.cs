using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ArrayReverser
{
    public partial class Form1 : Form
    {
        // Конструктор
        public Form1()
        {
            InitializeComponent();
        }

        // Обработчик кнопки
        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем массив для 5 чисел
            int[] originalArray = new int[5];

            // Читаем числа из TextBox'ов
            try
            {
                originalArray[0] = int.Parse(textBox1.Text);
                originalArray[1] = int.Parse(textBox2.Text);
                originalArray[2] = int.Parse(textBox3.Text);
                originalArray[3] = int.Parse(textBox4.Text);
                originalArray[4] = int.Parse(textBox5.Text);

                // Создаем массив для реверсированных чисел
                int[] reversedArray = new int[5];

                // Заполняем реверсированный массив
                reversedArray[0] = originalArray[4];
                reversedArray[1] = originalArray[3];
                reversedArray[2] = originalArray[2];
                reversedArray[3] = originalArray[1];
                reversedArray[4] = originalArray[0];

                // Очищаем ListBox'ы
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                // Выводим исходный массив
                listBox1.Items.Add("Исходный массив:");
                for (int i = 0; i < 5; i++)
                {
                    listBox1.Items.Add($"arr[{i}] = {originalArray[i]}");
                }

                // Выводим реверсированный массив
                listBox2.Items.Add("Реверсированный:");
                for (int i = 0; i < 5; i++)
                {
                    listBox2.Items.Add($"rev[{i}] = {reversedArray[i]}");
                }

                // Добавляем итог
                listBox1.Items.Add("--------------");
                listBox2.Items.Add("--------------");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка! Введите целые числа во все поля.",
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
