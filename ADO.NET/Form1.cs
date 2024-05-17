using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StudentDal _students = new StudentDal();
        

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadScreen();
        }

        private void LoadScreen()
        {
            dgwStudent.DataSource = _students.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                Name = (tbxName.Text).ToString(),
                Surname = (tbxSurname).Text.ToString(),
                No = Convert.ToInt32(tbxNo.Text),
            };
            _students.Add(student);

            tbxName.Text = string.Empty;
            tbxSurname.Text = string.Empty;
            tbxNo.Text = string.Empty;

            LoadScreen();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Student student = new Student()
            {
                Id = Convert.ToInt32(dgwStudent.CurrentRow.Cells[0].Value),
                Name = (tbxNameUpdate.Text).ToString(),
                Surname = (tbxSurnameUpdate.Text).ToString(),
                No = Convert.ToInt32(tbxNoUpdate.Text)
            };
            _students.Update(student);

            tbxNameUpdate.Text =string.Empty;
            tbxSurnameUpdate.Text =string.Empty;
            tbxNoUpdate.Text =string.Empty;

            LoadScreen();

        }

        private void dgwStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwStudent.CurrentRow.Cells[1].Value.ToString();
            tbxSurnameUpdate.Text = dgwStudent.CurrentRow.Cells[2].Value.ToString();
            tbxNoUpdate.Text = dgwStudent.CurrentRow.Cells[3].Value.ToString();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ıd = Convert.ToInt32(dgwStudent.CurrentRow.Cells[0].Value);

            _students.Delete(ıd);

            tbxNameUpdate.Text = string.Empty;
            tbxSurnameUpdate.Text = string.Empty;
            tbxNoUpdate.Text = string.Empty;

            LoadScreen();
        }
    }
}
