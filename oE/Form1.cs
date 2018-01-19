using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using oEEntity;
using oELib;

namespace oE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //oEEntity.oExEntity oESch = new oEEntity.oExEntity();
            //string schemaString = oESch.GetXmlSchema();

            //System.IO.StreamWriter writer = new System.IO.StreamWriter("Customers.xsd");
            ////oESch.GetXmlSchema(writer);
            //writer.Close();

            QuestionNature QuestionNat = null;

            if (rbQuestionMode.Checked)
            {
                QuestionModeEntity CurrentQuestionNature = new QuestionModeEntity();
                CurrentQuestionNature.ID = Guid.NewGuid().ToString();
                CurrentQuestionNature.Code = txtQuestionMode.Text;
                CurrentQuestionNature.Description = txtQuestionDesc.Text;
                QuestionNat = new QuestionNatureMode();
            }
            else if (rbQuestionType.Checked)
            {
                QuestionTypeEntity CurrentQuestionNature = new QuestionTypeEntity();
                CurrentQuestionNature.ID = Guid.NewGuid().ToString();
                CurrentQuestionNature.Code = txtQuestionMode.Text;
                CurrentQuestionNature.Description = txtQuestionDesc.Text;
                QuestionNat = new QuestionNatureType();
            }

            //QuestionNat.Create();
        }
    }
}
