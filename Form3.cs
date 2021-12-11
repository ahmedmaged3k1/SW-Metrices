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
    public partial class Form3 : Form
    {
        float TCF = 0 ;
        float FP = 0;
        int UCF = 0 ;
        public Form3(int ucfPoint)
        {
            UCF = ucfPoint;
            InitializeComponent();
        }

       

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void Display_All_Outputs_btn_Click(object sender, EventArgs e)
        {
            FP = UCF * TCF;
            Form4 f4 = new Form4(FP,TCF,UCF);
            f4.Show();
            this.Hide();
        }

        private void Data_communicatio_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void EndUserEfficiency_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Calculate_TCF_btn_Click(object sender, EventArgs e)
        {
            float Di = getData(Data_communicatio_cmbx) + getData(Data_Processing_cmbx) + getData(Performance_Criteria_cmbx) +
                getData(Heavly_Hardware_cmbx) + getData(HighTransRate_cmbx) + getData(OnlineData_cmbx) + getData(OnlineUpdating_cmbx) +
                getData(EndUserEfficiency_cmbx) + getData(ComplexCputations_cmbx) + getData(Reusability) + getData(EaseOfOperation_cmbx) +
                getData(Portability_cmbx) + getData(Maintinabilty_cmbx);
             TCF = 0.65f +( 0.01f * Di);
            label2.Text = TCF.ToString();

        }
        private int getData(ComboBox comboBox)
        {
            if(comboBox.SelectedIndex == -1)
            {
                comboBox.SelectedIndex = 0;
                return comboBox.SelectedIndex;

            }
            else
            {
                return comboBox.SelectedIndex;
            }
        }

        private void High_Transaction_Rates_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void EaseOfInstallation_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
