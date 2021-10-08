using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResumeMessageBox
{
    public static class Resume
    {
        public static string FirstName { get; }
        public static string LastName { get; }
        public static int Age { get; }
        public static string WorkPlace { get; }
        public static string Hobby { get; }

        public static double CountChar()
        {
            return FirstName.Length + LastName.Length + Age.ToString().Length + WorkPlace.Length + Hobby.Length;
        }
        static Resume()
        {
            FirstName = "Иван;";
            LastName = "Гилязов;";
            Age = 31;
            WorkPlace = "завод Эколос;";
            Hobby = "Программирование;";
        }


    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Имя: {Resume.FirstName} \nФамилия: {Resume.LastName}", "Первый MesageBox");
            MessageBox.Show($"Возраст: {Resume.Age} год;", "Второй MesageBox");
            MessageBox.Show($"Место работы: {Resume.WorkPlace} \nХобби: {Resume.Hobby}", $"Среднее количество символов: {Resume.CountChar() / 3}");

        }
    }
}
