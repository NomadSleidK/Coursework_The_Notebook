using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.Forms
{
    public partial class EditEntry : Form
    {
        DataBase notebookBase = new DataBase();
        int idRow;

        public EditEntry(int id, String name, String date, String address, String Phone, String WorkPlace, String Post, String Nature, String Quality, String Note)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            //передаём полученные значения в соответствущие поля
            idRow = id;
            FIOBox.Text = name;
            DateBox.Text = date.Substring(0, date.Length - 8);
            AdressBox.Text = address;
            PhoneNomberBox.Text = Phone;
            WorkPlaceBox.Text = WorkPlace;
            PostBox.Text = Post;
            NatureBox.Text = Nature;
            QualityBox.Text = Quality;
            NoteBox.Text = Note;
        }

        private void EditEntry_Load(object sender, EventArgs e)
        {

        }

        //сохранить запись
        private void SaveEditButton_Click(object sender, EventArgs e)
        {
            if (!FIOPError.Visible && !DateError.Visible && !PhoneError.Visible)
            {
                notebookBase.Open_Connection();
                SqlCommand Command = new SqlCommand("update Notebook set FullName = @Name, DateOfBirth = @DateB, Address = @Address, Telephone = @Telephone, PlaceOfWork = @PlaceOfWork, Post = @Post, Nature = @Nature, Qualities = @Qualities, Notes = @Notes, DateLastChange = @DateLastChange where EntryNumber = " + idRow + "", notebookBase.Get_Connection());

                //реализация заглушек и передача в них значений из полей
                DateTime boofer = Convert.ToDateTime(DateBox.Text);

                Command.Parameters.Add("@Name", FIOBox.Text);
                Command.Parameters.Add("@DateB", (boofer).ToString("yyyy-MM-dd HH:mm:ss"));
                Command.Parameters.Add("@Address", AdressBox.Text);
                Command.Parameters.Add("@Telephone", PhoneNomberBox.Text);
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

        //удалить запись
        private void DeleteEntryButton_Click(object sender, EventArgs e)
        {
            notebookBase.Open_Connection();
            //команда для удаления записи с указанным id
            SqlCommand Command = new SqlCommand("delete from Notebook where EntryNumber = " + idRow + "", notebookBase.Get_Connection());
            //команда для изменения id у записей старше удалённой записи
            SqlCommand CommandIncrement = new SqlCommand("update Notebook set EntryNumber = EntryNumber - 1 where EntryNumber > " + idRow + "", notebookBase.Get_Connection());


            Command.ExecuteNonQuery(); //вызов Sql запросов
            CommandIncrement.ExecuteNonQuery(); 

            notebookBase.Close_Connection();
            this.Close();
        }


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

        private void DateBox_TextChanged(object sender, EventArgs e) //проверка корректности даты
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

        private void AdressBox_TextChanged(object sender, EventArgs e)  //счётчик символов поля Адресс
        {
            String length = Convert.ToString(AdressBox.Text.Length) + "/50";
            Length3.Text = length;
        }

        private void PhoneNomberBox_TextChanged(object sender, EventArgs e) //проверка корректности номер телефона
        {
            if (PhoneNomberBox.MaskCompleted && PhoneNomberBox.MaskFull)
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

        private void NoteBox_TextChanged(object sender, EventArgs e) //счётчик символов поля Качества
        {
            String length = Convert.ToString(NoteBox.Text.Length) + "/50";
            Length9.Text = length;
        }
    }
}
