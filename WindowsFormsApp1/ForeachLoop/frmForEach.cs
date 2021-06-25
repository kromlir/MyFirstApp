﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp.ForeachLoop
{
    public partial class frmForEach : Form
    {
        public frmForEach()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.StudentId = Convert.ToInt32(txtStudentId.Text);            
            student.Name = txtName.Text;
            student.Surname = txtSurname.Text;
            student.Age = Convert.ToInt32(txtAge.Text);

            var studentList = new ArrayList();
            //Boxing, estas poniendo un objeto dentro de una "caja"
            studentList.Add(student);

            foreach (var _student in studentList)
            {
                //Unboxing, estas sacando un objeto de dentro de una "caja"
                MessageBox.Show(((Student)_student).Name + " " + ((Student)_student).Surname);
            }

            /* misma función pero casteando el objeto automaticamente dentro de la declaración del Foreach
            foreach (Student _student in studentList)
            {
                //Unboxing, estas sacando un objeto de dentro de una "caja"
                MessageBox.Show(_student.Name + " " + _student.Surname;
            }
            */
        }
    }
}
