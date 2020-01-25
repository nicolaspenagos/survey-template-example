using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using model;

namespace Template
{
    public partial class Form1 : Form
    {
        private Poll poll;
        public Form1()
        {
            InitializeComponent();
            poll = new Poll();
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox2.Text;
            String lastname = textBox3.Text;
            int age = int.Parse(textBox1.Text);
           
            int semester = int.Parse(comboBox1.Text);
            Boolean recycle = comboBox2.Text.Equals("YES") ? true : false;
   
            poll.add(name, lastname, age, semester, recycle);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            poll.print();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            poll.load();
            List<Person> peopleList = poll.getPeopleList();

            int r = poll.getPeopleList().Count() - 1;
            int c = peopleList.Count-1;
            dataGridView1.Rows.Clear();


            while (c >= 0) {

                Person currentPerson = peopleList.ElementAt(c);
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = currentPerson.Name;
                dataGridView1.Rows[n].Cells[1].Value = currentPerson.Lastname;
                dataGridView1.Rows[n].Cells[2].Value = currentPerson.Age;
                dataGridView1.Rows[n].Cells[3].Value = currentPerson.getSemester();
                dataGridView1.Rows[n].Cells[4].Value = currentPerson.Recycle;

                c--;
            }

        }

    }
}
