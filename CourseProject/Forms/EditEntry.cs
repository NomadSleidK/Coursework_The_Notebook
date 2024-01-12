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
    }
}
