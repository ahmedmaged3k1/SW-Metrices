using System;
using System.Collections;
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
    public partial class Form2 : Form
       
    {
        int sum = 0;    
        private List <int> externalInputResult = new List <int> ();
        private List<int> internalLogicalFileResult = new List<int>();
        private List<int> externalOutputResult = new List<int>();
        private List<int> externalInterfaceFilesResult = new List<int>();
        private List<int> externalInquiryResult = new List<int>();
        private Dictionary<string, int> externalInput = new Dictionary<string, int>()
        {
            {"Simple",3 } ,
            {"Average",4 }, 
            {"Complex",6 }
        };
        private Dictionary<string, int> internalLogicalFile = new Dictionary<string, int>()
        {
            {"Simple",7 } ,
            {"Average",10 },
            {"Complex",15 }
        };
        private Dictionary<string, int> externalOutput = new Dictionary<string, int>()
        {
            {"Simple",4} ,
            {"Average",5 },
            {"Complex",7 }
        };
        private Dictionary<string, int> externalInterfaceFiles = new Dictionary<string, int>()
        {
            {"Simple",5} ,
            {"Average",7},
            {"Complex",10 }

        };
        private Dictionary<string, int> externalInquiry = new Dictionary<string, int>()
        {
            {"Simple",3} ,
            {"Average",4},
            {"Complex",6 }
        };





        public Form2()
        {
            
           


            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TCF_btn_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(sum);
            f3.Show();
            this.Hide();
        }

        private void Answer_lbl_Click(object sender, EventArgs e)
        {
            
        }

        private void ILF_lbl_Click(object sender, EventArgs e)
        {

        }

        private void EIF_lbl_Click(object sender, EventArgs e)
        {

        }

        private void External_Interface_simple_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void External_Interface_Average_TextChanged(object sender, EventArgs e)
        {



        }

        private void External_Interface_Complex_TextChanged(object sender, EventArgs e)
        {
         
            


        }

        private void UFP_btn_Click(object sender, EventArgs e)
        {
            ///////////// External_Interface_simple ///////////////////
            setData(External_Interface_simple, "Simple",externalInterfaceFiles,externalInterfaceFilesResult);
            setData(External_Interface_Average, "Average", externalInterfaceFiles, externalInterfaceFilesResult);
            setData(External_Interface_Complex, "Complex", externalInterfaceFiles, externalInterfaceFilesResult);
            ///////////// Internal_Logical_Simple ///////////////////
            setData(Internal_Logical_Simple, "Simple", internalLogicalFile, internalLogicalFileResult);
            setData(Internal_Logical_Average, "Average", internalLogicalFile, internalLogicalFileResult);
            setData(Internal_Logical_Complex, "Complex", internalLogicalFile, internalLogicalFileResult);
            ///////////// External_Input_Simple ///////////////////
            setData(External_Input_Simple, "Simple", externalInput, externalInputResult);
            setData(External_Input_Average, "Average", externalInput, externalInputResult);
            setData(External_Input_Complex, "Complex", externalInput, externalInputResult);
            ///////////// External_Output_Simple ///////////////////
            setData(External_Output_Simple, "Simple", externalOutput, externalOutputResult);
            setData(External_Output_Average, "Average", externalOutput, externalOutputResult);
            setData(External_Output_Complex, "Complex", externalOutput, externalOutputResult);
            ///////////// External_Inquiry_Simple ///////////////////
            setData(External_Inquiry_Simple, "Simple", externalInquiry, externalInquiryResult);
            setData(External_Inquiry_Average, "Average", externalInquiry, externalInquiryResult);
            setData(External_Inquiry_Complex, "Complex", externalInquiry, externalInquiryResult);

            sum = getSum(externalInterfaceFilesResult) + getSum(internalLogicalFileResult) +
                getSum(externalInputResult) + getSum(externalOutputResult) + getSum(externalInquiryResult);
            
            Answer_lbl.Text = sum.ToString();
            externalInterfaceFilesResult.Clear();
            internalLogicalFileResult.Clear();
            externalInputResult.Clear();
            externalOutputResult.Clear();
            externalInquiryResult.Clear();

        }
        private void setData(TextBox textBox , string key, Dictionary<string, int> inputType, List<int> resultList)
        {
            if (textBox.Text == "")
            {
                resultList.Add(0);
            }
            else
            {
                int number = int.Parse(textBox.Text);
                resultList.Add(number * inputType[key]);
            }

           
            
          
            

        }
        private int getSum(List<int> resultList)
        {
            int result = 0;
            foreach (var value in resultList)
            {

                result += value;
                

            }
            Console.WriteLine(result.ToString());


            return result;
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            External_Interface_simple.Clear();
            External_Interface_Average.Clear();
            External_Interface_Complex.Clear();
            Internal_Logical_Simple.Clear();
            Internal_Logical_Average.Clear();
            Internal_Logical_Complex.Clear();
            External_Input_Simple.Clear();
            External_Input_Average.Clear();
            External_Input_Complex.Clear();
            External_Output_Simple.Clear();
            External_Output_Average.Clear();
            External_Output_Complex.Clear();
            External_Inquiry_Simple.Clear();
            External_Inquiry_Average.Clear();
            External_Inquiry_Complex.Clear();
            Answer_lbl.Text = "0";











        }

        private void Title_Click(object sender, EventArgs e)
        {

        }
    }
}
