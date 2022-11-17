using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;


namespace IS1_20_DodardzhonovKK
{
    public partial class MainForm : MetroFramework.Forms.MetroForm

    {
        
        public MainForm()
        {
            InitializeComponent();

            // Делаем обычный стиль.
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Убираем кнопки свернуть, развернуть, закрыть.
            this.ControlBox = false;
            // Убираем заголовок.
            this.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Сокрытие текущей формы
            this.Hide();
            //Инициализируем и вызываем форму диалога авторизации
            Authh Auth2 = new Authh();
            //Вызов формы в режиме диалога
            Auth2.ShowDialog();
            //Если авторизации была успешна и в поле класса хранится истина, то делаем движуху:
            if (Auth.auth)
            {
                //Отображаем рабочую форму
                this.Show();
                //Вытаскиваем из класса поля в label'ы
                label1.ForeColor = Color.GreenYellow;
                label1.Text = Auth.auth_id;
                label1.Text = Auth.auth_fio;
                label1.Text = $"Успешная авторизация! \nЗдравствуйте, {Auth.auth_fio} ";

                //Красим текст в label в зелёный цвет

            }
            //иначе
            else
            {
                //Закрываем форму
                Application.Exit();
            }
        }



        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            //Сокрытие текущей формы
            this.Hide();
            //Инициализируем и вызываем форму диалога авторизации
            Authh f = new Authh ();
            //Вызов формы в режиме диалога
            f.ShowDialog();

            this.Close();
        }





        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


    }
}
