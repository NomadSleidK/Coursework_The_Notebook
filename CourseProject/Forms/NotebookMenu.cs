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
    }
}
