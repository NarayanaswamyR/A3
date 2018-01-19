using oELib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.frmQuestions frmQuestion = new Forms.frmQuestions();

            //frmMasterData masterData = new frmMasterData();
            //masterData.Show();
            frmQuestion.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //frmQuestion question = new frmQuestion();
            //question.Show();
            WindowsFormsApplication1.Forms.frmQuestionBank qb = new WindowsFormsApplication1.Forms.frmQuestionBank();
            qb.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Forms.frmMemberQB pqb = new WindowsFormsApplication1.Forms.frmMemberQB();
            pqb.Show();
        }
    }
}
