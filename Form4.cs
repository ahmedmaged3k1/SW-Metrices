using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SW_Metrices
{
    public partial class Form4 : Form

    {
        float TCF = 0;
        float FP = 0;
        int UCF = 0;
        float LOC;
        private Dictionary<string, int> programingLanguage = new Dictionary<string, int>()
        {
            {"Assembly Language",320 } ,
            {"C",128 },
            {"COBOL/Fortran",105 },
            {"Pascal ",90 },
            {"Ada",70 },
            {"C++",64 },
            {"Visual Basic",32 },
            {"Object-Oriented Languages",30 },
            {"Smalltalk",22 },
            {"Code Generators (PowerBuilder",15 },
            {"SQL/Oracle",12 },
            {"Spreadsheets",6 },
            {"Graphical Languages (icons)",4 }



        };
        public Form4(float fPoint, float tcfPoint,int ucfPoint)
        {
            FP = fPoint;
            TCF = tcfPoint;    
            UCF = ucfPoint; 
            InitializeComponent();
        }

        private void LOC_Value_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UFP_Answer_lbl_Click(object sender, EventArgs e)
        {

        }

        private void FP_Calculation_btn_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please Enter LOC");
            }
            else
            {
                LOC = (programingLanguage[comboBox1.SelectedItem.ToString()] * FP);
                LOC_Answer_lbl.Text = LOC.ToString();
                FP_Answer_lbl.Text = FP.ToString();
                UFP_Answer_lbl.Text = UCF.ToString();
                TCF_Answer_lbl.Text = TCF.ToString();

            }



        }

        private void LOC_Answer_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
