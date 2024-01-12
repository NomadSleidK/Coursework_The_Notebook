using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Net;
using System.Text.RegularExpressions;

namespace CourseProject.Forms
{
    public partial class NewEntry : Form
    {
        DataBase notebookBase = new DataBase();

        int idNewRow;

        public NewEntry(int id)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            idNewRow = id + 1;  //получаем id для новой записи
        }

        //закрыть окно
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //сохранить запись
        private void SaveButton_Click(object sender, EventArgs e)
        {
            notebookBase.Open_Connection();

            if (!FIOPError.Visible && !DateError.Visible && !PhoneError.Visible) //если обязательные поля заполнены верно
            {
                //Sql запрос, где @Name, @DateB и т.д заглушки с дальнейшей реализацией
                SqlCommand Command = new SqlCommand("insert into Notebook (EntryNumber, FullName, DateOfBirth, Address, Telephone, PlaceOfWork, Post, Nature, Qualities, Notes, DateLastChange) values (@RowId, @Name, @DateB, @Address, @Telephone, @PlaceOfWork, @Post, @Nature, @Qualities, @Notes, @DateLastChange)", notebookBase.Get_Connection());

                //реализация заглушек и передача в них значений из полей
                DateTime boofer = Convert.ToDateTime(DateBox.Text);

                Command.Parameters.Add("@RowId", Convert.ToString(idNewRow));
                Command.Parameters.Add("@Name", FIOBox.Text);
                Command.Parameters.Add("@DateB", (boofer).ToString("yyyy-MM-dd HH:mm:ss"));
                Command.Parameters.Add("@Address", AdressBox.Text);
                Command.Parameters.Add("@Telephone", PhoneBox.Text);
                Command.Parameters.Add("@PlaceOfWork", WorkPlaceBox.Text);
                Command.Parameters.Add("@Post", PostBox.Text);
                Command.Parameters.Add("@Nature", NatureBox.Text);
                Command.Parameters.Add("@Qualities", QualityBox.Text);
                Command.Parameters.Add("@Notes", NoteBox.Text);
                Command.Parameters.Add("@DateLastChange", (DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss"));

                Command.ExecuteNonQuery(); //вызов Sql запроса
                notebookBase.Close_Connection();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка! \n Некоторые поля заполнены не правильно!");
            }
        }

        private void NewEntry_Load(object sender, EventArgs e)
        {

        }


        //Проверки корректности значений
        private void FIOBox_TextChanged(object sender, EventArgs e) //Проверка поля Имя или псевдоним
        {
            String length = Convert.ToString(FIOBox.Text.Length) + "/50"; //счётчик символов
            Length1.Text = length; //вернул значение счётчика в label

            String str = FIOBox.Text;
            str = str.Replace(" ", ""); //убираем пробклы из записи

            if (str == "" || str == " ") //если в строке нет символов кроме пробела
            {
                FIOPError.Visible = true;
            }
            else //если в строке есть хотя бы один символ после удаления пробелов
            {
                FIOPError.Visible = false;
            }
        }

        private void DateBox_TextChanged_1(object sender, EventArgs e) //проверка корректности даты
        {
            DateTime boofer;

            if (DateBox.MaskCompleted && DateBox.MaskFull && DateTime.TryParse(DateBox.Text, out boofer))
            {
                DateError.Visible = false;
            }
            else
            {
                DateError.Visible = true;
            }
        }

        private void AdressBox_TextChanged(object sender, EventArgs e) //счётчик символов поля Адресс
        {
            String length = Convert.ToString(AdressBox.Text.Length) + "/50";
            Length3.Text = length;
        }

        private void PhoneBox_TextChanged(object sender, EventArgs e) //проверка корректности номер телефона
        {
            if (PhoneBox.MaskCompleted && PhoneBox.MaskFull)
            {
                PhoneError.Visible = false;
            }
            else
            {
                PhoneError.Visible = true;
            }
        }

        private void WorkPlaceBox_TextChanged(object sender, EventArgs e) //счётчик символов поля Место работы
        {
            String length = Convert.ToString(WorkPlaceBox.Text.Length) + "/50";
            Length5.Text = length;
        }

        private void PostBox_TextChanged(object sender, EventArgs e) //счётчик символов поля Должность
        {
            String length = Convert.ToString(PostBox.Text.Length) + "/50";
            Length6.Text = length;
        }

        private void NatureBox_TextChanged(object sender, EventArgs e) //счётчик символов поля Статус
        {
            String length = Convert.ToString(NatureBox.Text.Length) + "/50";
            Length7.Text = length;
        }

        private void QualityBox_TextChanged(object sender, EventArgs e) //счётчик символов поля Характер знакомства
        {
            String length = Convert.ToString(QualityBox.Text.Length) + "/50";
            Length8.Text = length;
        }

        private void NoteBox_TextChanged(object sender, EventArgs e)  //счётчик символов поля Качества
        {
            String length = Convert.ToString(NoteBox.Text.Length) + "/50";
            Length9.Text = length;
        }
    }
}
