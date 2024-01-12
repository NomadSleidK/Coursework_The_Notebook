using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using static System.Net.Mime.MediaTypeNames;

namespace CourseProject.Forms
{
    public partial class NotebookMenu : Form
    {
        DataBase notebookBase;
        bool sortType;

        public NotebookMenu()
        {
            InitializeComponent();
            sortType = true;
            notebookBase = new DataBase();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void SearchBirthday() //получаем записи у которых сегодня день рождения
        {
            BirthdayGridView1.ClearSelection();

            SqlDataAdapter dataAdapter = null;
            DataTable table = new DataTable();

            //создаем таблицу
            DataTable tableBirthday = new DataTable();
            tableBirthday.Columns.Add("Номер записи");
            tableBirthday.Columns.Add("Имя/Псевдоним");

            DateTime dateBirthday;
            DateTime dataYesterday = DateTime.Now;
            int id;
            String name;

            notebookBase.Open_Connection();  //открыли соединение с базой и получаем данные

            dataAdapter = new SqlDataAdapter("SELECT * FROM Notebook", notebookBase.Get_Connection());
            dataAdapter.Fill(table);

            notebookBase.Close_Connection(); //закрыли соединение с базой данных

            //поиск соврадений по дате сегодня и датой дня рождения из записи среди всех записей
            for (int i = 0; i <= table.Rows.Count - 1; i++)
            {
                dateBirthday = table.Rows[i].Field<DateTime>("DateOfBirth");
                if(dateBirthday.Day == dataYesterday.Day && dateBirthday.Month == dataYesterday.Month)
                {
                    id = table.Rows[i].Field<int>("EntryNumber");
                    name = table.Rows[i].Field<String>("FullName");
                    object[] boofer = { id, name };
                    tableBirthday.Rows.Add(boofer);
                }
            }

            if (tableBirthday.Rows.Count <= 0)  //если полученная табица пуста говорим что записей нет
            {
                BirthdayLabel.Visible = true;
                BirthdayLabel.Visible = true;
            }
            else //если полученная табица что то есть то отключаем сообщение об отсутствии записей
            {
                BirthdayLabel.Visible = false;
            }

            BirthdayGridView1.DataSource = tableBirthday;
        }

        private void DispleyDataNotebook() //вывод всей таблицы
        {
            SearchBirthday();
            NotebookGridView.ClearSelection(); //очистка NotebookGridView

            //отключаенм отображение значков сортировки
            NoSearch.Visible = false;
            ASortH.Visible = false; 
            ASortL.Visible = false;
            LEditSH.Visible = false;
            LEditSL.Visible = false;

            SqlDataAdapter dataAdapter = null;
            DataTable table = new DataTable();

            notebookBase.Open_Connection(); //открыли соединение с базой данных

            dataAdapter = new SqlDataAdapter("SELECT * FROM Notebook", notebookBase.Get_Connection()); // созлаём sql запрос 
            dataAdapter.Fill(table); //заполняем таблицу полученными данными

            //переименовали столбцы в таблице
            table.Columns["EntryNumber"].ColumnName = "Номер записи";
            table.Columns["FullName"].ColumnName = "Имя/Псевдоним";
            table.Columns["DateOfBirth"].ColumnName = "Дата рождения";
            table.Columns["Address"].ColumnName = "Адресс";
            table.Columns["Telephone"].ColumnName = "Телефон";
            table.Columns["PlaceOfWork"].ColumnName = "Место работы/учёбы";
            table.Columns["Post"].ColumnName = "Должность";
            table.Columns["Nature"].ColumnName = "Характер знакомства";
            table.Columns["Qualities"].ColumnName = "Деловые качества";
            table.Columns["Notes"].ColumnName = "Причечания";
            table.Columns["DateLastChange"].ColumnName = "Дата последнего изменения";


            if (table.Rows.Count <= 0)  //если полученная табица пуста говорим что записей нет
            {
                NoEntryLabel.Visible = true;
            }
            else //если полученная табица что то есть то отключаем сообщение об отсутствии записей
            {
                NoEntryLabel.Visible = false;
            }

            NotebookGridView.DataSource = table;

            notebookBase.Close_Connection();
        }

        private void SortDispleyDataNotebook() //вывод результатов поиска
        {
            NotebookGridView.ClearSelection(); //очистка NotebookGridView

            SqlDataAdapter dataAdapter = null;
            DataTable table = new DataTable();
            String dataSearch = SearchBox.Text; //получаем ввод из поля поиск 

            notebookBase.Open_Connection(); //открыли соединение с базой данных

            dataAdapter = new SqlDataAdapter("SELECT * FROM Notebook where concat(EntryNumber, FullName, DateOfBirth, Address, Telephone, PlaceOfWork, Post, Nature, Qualities, Notes, DateLastChange) like N'%" + dataSearch + "%'", notebookBase.Get_Connection());

            dataAdapter.Fill(table);

            if (table.Rows.Count <= 0)  //если полученная табица пуста говорим что записей нет
            {
                NoSearch.Visible = true;
            }
            else //если полученная табица что то есть то отключаем сообщение об отсутствии записей
            {
                NoSearch.Visible = false;
            }

            NotebookGridView.DataSource = table;

            notebookBase.Close_Connection();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            String str = SearchBox.Text;
            str = str.Replace(" ", ""); //убираем пробелы из записи

            if (str != "") //если в поисковом окне что то есть ищем
            {
                SortDispleyDataNotebook();
            }
            else  //если в поисковом окне ничего нет то оставляем полную таблицу
            {
                DispleyDataNotebook();
            }
            
        }

        private void NotebookMenu_Load(object sender, EventArgs e)
        {
            DispleyDataNotebook();
        }

        //Редактировать запись
        private void NotebookGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SearchBox.Text = "";

            int id = int.Parse(NotebookGridView.CurrentRow.Cells[0].Value.ToString());

            //получаем значения из выбранной строки
            String name = NotebookGridView.CurrentRow.Cells[1].Value.ToString();
            String date = NotebookGridView.CurrentRow.Cells[2].Value.ToString();
            String address = NotebookGridView.CurrentRow.Cells[3].Value.ToString();
            String Phone = NotebookGridView.CurrentRow.Cells[4].Value.ToString();
            String WorkPlace = NotebookGridView.CurrentRow.Cells[5].Value.ToString();
            String Post = NotebookGridView.CurrentRow.Cells[6].Value.ToString();
            String Nature = NotebookGridView.CurrentRow.Cells[7].Value.ToString();
            String Quality = NotebookGridView.CurrentRow.Cells[8].Value.ToString();
            String Note = NotebookGridView.CurrentRow.Cells[9].Value.ToString();

            //вызвваем оено редактирования передавая зваиси из выбранной ранее строки
            EditEntry editEntry = new EditEntry(id, name, date, address, Phone, WorkPlace, Post, Nature, Quality, Note);
            editEntry.ShowDialog();
            DispleyDataNotebook();
        }

        //Создать новую запись
        private void CreateNewButton_Click(object sender, EventArgs e)
        {
            SearchBox.Text = ""; //очистить окно поиска

            int id = NotebookGridView.Rows.Count; //получаем номер последней записи

            NewEntry newEntry = new NewEntry(id);
            newEntry.ShowDialog();
            DispleyDataNotebook();
        }

        //сортировка
        private void AlfSortButton_Click(object sender, EventArgs e) //сортировка по алфавиту
        {
            LEditSH.Visible = false; //отображение значков сортировки по последнему редактированию выключить 
            LEditSL.Visible = false;

            if (sortType) //сортировка по возрастанию 
            {
                this.NotebookGridView.Sort(this.NotebookGridView.Columns[1], ListSortDirection.Ascending);
                sortType = false;
                ASortH.Visible = true;
                ASortL.Visible = false;
            }
            else //сортировка по убыванию 
            {
                this.NotebookGridView.Sort(this.NotebookGridView.Columns[1], ListSortDirection.Descending);
                sortType = true;
                ASortH.Visible = false;
                ASortL.Visible = true;
            }
        }

        private void LastEditSortButton_Click(object sender, EventArgs e) //сортировка по дате изменений
        {
            ASortH.Visible = false; //отображение значков алфавитной сортировки выключить 
            ASortL.Visible = false;

            if (sortType) //сортировка по возрастанию 
            {
                this.NotebookGridView.Sort(this.NotebookGridView.Columns[10], ListSortDirection.Ascending);
                sortType = false;
                LEditSH.Visible = true;
                LEditSL.Visible = false;
            }
            else //сортировка по убыванию 
            {
                this.NotebookGridView.Sort(this.NotebookGridView.Columns[10], ListSortDirection.Descending);
                sortType = true;
                LEditSH.Visible = false;
                LEditSL.Visible = true;
            }
        }
    }
}
