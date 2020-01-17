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
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void Window_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Test___CopyDataSet.Window_Table' table. You can move, or remove it, as needed.
            this.window_TableTableAdapter.Fill(this._Test___CopyDataSet.Window_Table);

            string[] listOfFilters = { "Filter/List all", "List All", "Filter by CRQNum", "Filter by TRBNum",
                                       "Filter by Activity", "Filter by Target Date", "Filter by PIC", "Filter by Status",
                                       "Filter by Remarks" };
            comboBox1.Items.AddRange(listOfFilters);
            comboBox1.SelectedIndex = 0;

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            windowTableBindingSource.AddNew();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           windowTableBindingSource.EndEdit();
           window_TableTableAdapter.Update(_Test___CopyDataSet.Window_Table);
            MessageBox.Show("OK");
        }

        private void FilterByCRQNumToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.window_TableTableAdapter.FilterByCRQNum(this._Test___CopyDataSet.Window_Table, cRQ_ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByTRBNumToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.window_TableTableAdapter.FilterByTRBNum(this._Test___CopyDataSet.Window_Table, tRB_ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByActivityToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.window_TableTableAdapter.FilterByActivity(this._Test___CopyDataSet.Window_Table, activityToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByTargetDateToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.window_TableTableAdapter.FilterByTargetDate(this._Test___CopyDataSet.Window_Table, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(target_DateToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByPICToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.window_TableTableAdapter.FilterByPIC(this._Test___CopyDataSet.Window_Table, pICToolStripTextBox.Text);
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
                this.window_TableTableAdapter.FilterByStatus(this._Test___CopyDataSet.Window_Table, statusToolStripTextBox.Text);
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
                this.window_TableTableAdapter.FilterByRemarks(this._Test___CopyDataSet.Window_Table, remarksToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = comboBox1.SelectedItem.ToString();
            ToolStrip[] toolStripArray = new ToolStrip[8];
            toolStripArray[0] = listAllToolStrip;
            toolStripArray[1] = filterByCRQNumToolStrip;
            toolStripArray[2] = filterByTRBNumToolStrip;
            toolStripArray[3] = filterByActivityToolStrip;
            toolStripArray[4] = filterByTargetDateToolStrip;
            toolStripArray[5] = filterByPICToolStrip;
            toolStripArray[6] = filterByStatusToolStrip;
            toolStripArray[7] = filterByRemarksToolStrip;

            toggleVisibility(selectedFilter, toolStripArray);

            //ListAllToolStripButton_Click();
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




        private void FilterByRemarksToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ListAllToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.window_TableTableAdapter.ListAll(this._Test___CopyDataSet.Window_Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form1 configTable = new Form1();
            configTable.Show();
            this.Hide();
        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            CRQ CRQForm = new CRQ();
            CRQForm.Show();
            this.Hide();
        }

        private void FilterByStatusToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.windowTableBindingSource.RemoveCurrent();
        }
    }
}
