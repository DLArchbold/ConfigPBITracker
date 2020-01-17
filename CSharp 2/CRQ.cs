using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_2
{
    public partial class CRQ : Form
    {
        public CRQ()
        {
            InitializeComponent();
        }

        private void CRQ_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Test___CopyDataSet.CRQ_Table' table. You can move, or remove it, as needed.
            this.cRQ_TableTableAdapter.Fill(this._Test___CopyDataSet.CRQ_Table);


            //Set default selected values
            string[] listOfFilters = { "Filter/List all", "List All", "Filter by CRQNumber", "Filter by Coordinator",
                                       "Filter by Change Coordinator", "Filter by Status", "Filter by Service", "Filter by Remarks",
                                       "Filter by Summary", "Filter by RFS" };
            comboBox1.Items.AddRange(listOfFilters);
            comboBox1.SelectedIndex = 0;


        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = comboBox1.SelectedItem.ToString();
            ToolStrip[] toolStripArray = new ToolStrip[9];
            toolStripArray[0] = listAllToolStrip;
            toolStripArray[1] = filterByCRQNumberToolStrip;
            toolStripArray[2] = filterByCoordinatorToolStrip;
            toolStripArray[3] = filterByChangeCoordinatorToolStrip;
            toolStripArray[4] = filterByStatusToolStrip;
            toolStripArray[5] = filterByServiceToolStrip;
            toolStripArray[6] = filterByRemarksToolStrip;
            toolStripArray[7] = filterBySummaryToolStrip;
            toolStripArray[8] = filterByRFSToolStrip;

            toggleVisibility(selectedFilter, toolStripArray);
            
        }

        private void toggleVisibility(string id, ToolStrip[] toolStripArray)
        {



            if (!id.Equals("List All"))
            {
                string third = id.Substring(10);
                if (third.IndexOf(" ") != -1)
                {
                    List<char> thirdTemp = new List<char>();
                    for (int i = 0; i < third.Length; i++)
                    {
                        if (!(third[i].Equals(' ')))
                        {
                            thirdTemp.Add(third[i]);

                        }

                    }



                    third = new string(thirdTemp.ToArray());
                }
                string toggle = "filterBy" + third + "ToolStrip";

                for (int i = 0; i < toolStripArray.Length; i++)
                {

                    if (toolStripArray[i].Name.Equals(toggle))
                    {
                        toolStripArray[i].Visible = true;
                    }
                    else
                    {
                        toolStripArray[i].Visible = false;

                    }

                    //if(toolStripArray[i].Name.Equals("filter"))
                }

            }
            else
            {
                string toggle = "listAllToolStrip";

                for (int i = 0; i < toolStripArray.Length; i++)
                {

                    if (toolStripArray[i].Name.Equals(toggle))
                    {
                        toolStripArray[i].Visible = true;
                    }
                    else
                    {
                        toolStripArray[i].Visible = false;

                    }

                    //if(toolStripArray[i].Name.Equals("filter"))
                }
            }










        }

        private void FilterByCRQNumberToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cRQ_TableTableAdapter.FilterByCRQNumber(this._Test___CopyDataSet.CRQ_Table, cRQ_ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByCoordinatorToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cRQ_TableTableAdapter.FilterByCoordinator(this._Test___CopyDataSet.CRQ_Table, coordinatorToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByChangeCoordinatorToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cRQ_TableTableAdapter.FilterByChangeCoordinator(this._Test___CopyDataSet.CRQ_Table, change_CoordinatorToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByStatusToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cRQ_TableTableAdapter.FilterByStatus(this._Test___CopyDataSet.CRQ_Table, statusToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


        private void FilterByServiceToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cRQ_TableTableAdapter.FilterByService(this._Test___CopyDataSet.CRQ_Table, serviceToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByRemarksToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cRQ_TableTableAdapter.FilterByRemarks(this._Test___CopyDataSet.CRQ_Table, remarksToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterBySummaryToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cRQ_TableTableAdapter.FilterBySummary(this._Test___CopyDataSet.CRQ_Table, summaryToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByRFSToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cRQ_TableTableAdapter.FilterByRFS(this._Test___CopyDataSet.CRQ_Table, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(rFSToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ListAllToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cRQ_TableTableAdapter.ListAll(this._Test___CopyDataSet.CRQ_Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 form1Window = new Form1();
            form1Window.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Window windowForm = new Window();
            windowForm.Show();
            this.Hide();
        }

        private void FilterByStatusToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            cRQTableBindingSource.AddNew();
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            cRQTableBindingSource.EndEdit();
            cRQ_TableTableAdapter.Update(_Test___CopyDataSet.CRQ_Table);
            MessageBox.Show("OK");
        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            this.cRQTableBindingSource.RemoveCurrent();
        }
    }
}
