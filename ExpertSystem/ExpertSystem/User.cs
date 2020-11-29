using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuzzyInference;

namespace ExpertSystem
{
    public partial class User : Form
    {
        Database db;
        public User()
        {
            InitializeComponent();
            textBox1.Text = "> Welcome in our app which helps you to choose best University and course!!! \r\n> Choose your  3 best matura exam scores \r\n>";
            
            for(ExamName i=0;i<=ExamName.UKRAINIAN;++i)
            {
                comboBox1.Items.Add(i.ToString());
                comboBox2.Items.Add(i.ToString());
                comboBox3.Items.Add(i.ToString());
            }
            comboBox1.SelectedIndex = (int)ExamName.MATHEMATICS;
            comboBox2.SelectedIndex = (int)ExamName.PHYSICS;
            comboBox3.SelectedIndex = (int)ExamName.ENGLISH;
            db = new Database();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex != 0 && comboBox1.SelectedIndex!= 3 && comboBox1.SelectedIndex != 2)
            {
                radioButton3.Select();
                radioButton4.Enabled = false;
            }
            else
            {
                radioButton4.Enabled = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != 0 && comboBox2.SelectedIndex != 3 && comboBox2.SelectedIndex != 2)
            {
                radioButton2.Select();
                radioButton1.Enabled = false;
            }
            else
            {
                radioButton1.Enabled = true;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex != 0 && comboBox3.SelectedIndex != 3 && comboBox3.SelectedIndex != 2)
            {
                radioButton6.Select();
                radioButton5.Enabled = false;
            }
            else
            {
                radioButton5.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExamResult ex1 = new ExamResult();
            ex1.ExamName = (ExamName)comboBox1.SelectedIndex;
            ex1.ExamLevel = radioButton4.Checked ? ExamLevel.BASIC : ExamLevel.ADVANCED;
            ex1.Result = (int)numericUpDown1.Value;
            ExamResult ex2 = new ExamResult();
            ex2.ExamLevel = radioButton1.Checked ? ExamLevel.BASIC : ExamLevel.ADVANCED;
            ex2.ExamName = (ExamName)comboBox2.SelectedIndex;
            ex2.Result = (int)numericUpDown2.Value;
            ExamResult ex3 = new ExamResult();
            ex3.ExamName = (ExamName)comboBox3.SelectedIndex;
            ex3.ExamLevel = radioButton5.Checked ? ExamLevel.BASIC : ExamLevel.ADVANCED;
            ex3.Result = (int)numericUpDown3.Value;
            List<ExamResult> ls = new List<ExamResult>() { ex1, ex2, ex3 };
            InferenceEngine engine= new InferenceEngine();
            var ret = engine.Run(ls);
            ret.Result.Sort((x, y) => { return x.Item2.CompareTo(y.Item2); });
            ret.Result.Reverse();
            string txt = "> Welcome in our app which helps you to choose best University and course!!! \r\n> Choose your  3 best matura exam scores \r\n> \r\n> \r\n>";
            foreach (var el in ret.Result)
            {
                txt += ("You will " + el.Item2.ToString() + " get into " + el.Item1.CourseName + " on " + el.Item1.CollegeName + "\r\n>");
            }
            textBox1.Text = txt;



        }
    }
}
