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
                metroLabel1.ForeColor = Color.GreenYellow;
                metroLabel1.Text = Auth.auth_id;
                metroLabel1.Text = Auth.auth_fio;
                metroLabel1.Text = "Успешно!";
                //Красим текст в label в зелёный цвет

            }
            //иначе
            else
            {
                //Закрываем форму
                this.Close();
            }
        }
    }
}
