using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL.Entities;
namespace GUI.UC
{
    public partial class uc__students : UserControl
    {
        private FacultyBUS facultyBUS;
        private StudentBUS studentBUS;
        public uc__students()
        {
            facultyBUS = new FacultyBUS();
            studentBUS = new StudentBUS();
            InitializeComponent();

            this.Load += Uc__students_Load;
        }

        private void Uc__students_Load(object sender, EventArgs e)
        {
            LoadFaculty();
            LoadListStudents();

        }

        private void LoadFaculty()
        {
            var faculties = facultyBUS.GetAll();
            cmb__faculties.DisplayMember = "FacultyName";
            cmb__faculties.ValueMember = "FacultyID";
            cmb__faculties.DataSource = faculties;
            Alert(faculties.Count.ToString(), frm__alert.AlertType.Info);
        }

        private void LoadListStudents()
        {
            dgv__students.Rows.Clear();
            var students = studentBUS.GetAll();
            if(students != null)
            {
                foreach(var item in students)
                {
                    int index = dgv__students.Rows.Add();

                    dgv__students.Rows[index].Cells[0].Value = item.StudentID;
                    dgv__students.Rows[index].Cells[1].Value = item.StudentName;
                    dgv__students.Rows[index].Cells[2].Value = (item.StudentGender == 0)?"Nam":"Nữ";
                    dgv__students.Rows[index].Cells[3].Value = item.StudentBirthDay.ToString("dd/MM/yyyy");
                    dgv__students.Rows[index].Cells[4].Value = item.Faculty.FacultyName;
                    dgv__students.Rows[index].Cells[5].Value = item.StudentAgv;
                    dgv__students.Rows[index].Cells[6].Value = (item.Major == null)?"Chưa đăng ký":item.Major.MajorName;
                }
            }
        }


        public void Alert(string msg, frm__alert.AlertType type)
        {
            Thread aleart = new Thread(new ThreadStart(() => Application.Run(new frm__alert(msg, type))));
            aleart.Start();
        }
    }
}
