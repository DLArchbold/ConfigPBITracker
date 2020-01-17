using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace CSharp_2
{
    public partial class ConfigSummary : Form
    {
        
        public ConfigSummary()
        {
            InitializeComponent();
         
                        
      


         }



        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ConfigSummary_Load(object sender, EventArgs e)
        {
            monthlySummaryTableAdapter.Fill(_Test___CopyDataSet.MonthlySummary);
            yearlySummaryTableAdapter.Fill(_Test___CopyDataSet.YearlySummary);
            uCRSummaryTableAdapter.Fill(_Test___CopyDataSet.UCRSummary);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            configSummaryBindingSource4.AddNew();
        }

        private void Button2_Click(object sender, EventArgs e)
        {   //test branching
            //test stash
            //textBox10.Text = (Int32.Parse(textBox11.Text) + Int32.Parse(textBox8.Text) + Int32.Parse(textBox9.Text)).ToString();
            configSummaryBindingSource4.EndEdit();
            config_SummaryTableAdapter.Update(_Test___CopyDataSet.Config_Summary);
            MessageBox.Show("OK");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.configSummaryBindingSource4.RemoveCurrent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form1 test = new Form1();
            test.Show();
            this.Hide();
        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FilterByUCRNumToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.uCRSummaryTableAdapter.FilterByUCRNum(this._Test___CopyDataSet1.UCRSummary, uCR_ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

    

        private void filterByUCRNumToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.uCRSummaryTableAdapter.FilterByUCRNum(this._Test___CopyDataSet.UCRSummary, uCR_ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
