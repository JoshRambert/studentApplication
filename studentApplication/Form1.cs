using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void requiredHoursButton_Click(object sender, EventArgs e)
        {
            //Variables to hold the input 
            string name, id, track;

            //get the students name and the id from the textBoxes
            name = nameTextBox.Text;
            id = idNumberTextBox.Text;

            //Get th academic track of the student
            if (infoSystemsRadioButton.Checked)
            {
                track = "Information Systems";
            }
            else
            {
                track = "Software Engineering";
            }

            //create a CompSciStudent object 
            CompSciStudent compSciStudent = new CompSciStudent(name, id, track);

            //Display the students required hours 
            requredHoursLabel.Text = compSciStudent.RequiredHours.ToString("n1"); 
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
