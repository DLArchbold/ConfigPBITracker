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
    public partial class PBI : Form
    {
        public PBI()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void PBI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Test___CopyDataSet.PBI_Table' table. You can move, or remove it, as needed.
            this.pBI_TableTableAdapter.Fill(this._Test___CopyDataSet.PBI_Table);

            //Set default selected values
            string[] listOfFilters = { "Filter/List all", "List All", "Filter by PBINumber", "Filter by CRQ Number", "Filter by Problem Coordinator",
                                       "Filter by Service", "Filter by Assignee", "Filter by Status", "Filter by Remarks",
                                       "Filter by Assessment/POC MD", "Filter by Assessment/POC MD At Least", "Filter by Assessment/POC MD At Most",
                                       "Filter by Build & ST MD", "Filter by Build & ST MD At Least",  "Filter by Build & ST MD At Most",
                                       "Filter by Management, SIT & UAT MD", "Filter by Management, SIT & UAT MD At Least", "Filter by Management, SIT & UAT MD At Most",
                                       "Filter by Total MD", "Filter by Total MD At Least", "Filter by Total MD At Most",
                                       "Filter by Additional Remarks", "Filter by Issue"};
            comboBox1.Items.AddRange(listOfFilters);
            comboBox1.SelectedIndex = 0;

        }






        private void Button4_Click(object sender, EventArgs e)
        {
            Form1 config = new Form1();
            this.Hide();
            config.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Window windowTable = new Window();
            this.Hide();
            windowTable.ShowDialog() ;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            CRQ crqTable = new CRQ();
            this.Hide();
            crqTable.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pBITableBindingSource.AddNew();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox10.Text = (Int32.Parse(textBox11.Text) + Int32.Parse(textBox8.Text) + Int32.Parse(textBox9.Text)).ToString();
            pBITableBindingSource.EndEdit();
            pBI_TableTableAdapter.Update(_Test___CopyDataSet.PBI_Table);
            MessageBox.Show("OK"); 
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void FilterByPBINumberToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pBI_TableTableAdapter.FilterByPBINumber(this._Test___CopyDataSet.PBI_Table, pBI_NumberToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByProblemCoordinatorToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pBI_TableTableAdapter.FilterByProblemCoordinator(this._Test___CopyDataSet.PBI_Table, problem_CoordinatorToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        //private void FilterByServiceToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.pBI_TableTableAdapter.FilterByService(this._Test___CopyDataSet.PBI_Table);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        private void FilterByAssigneeToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pBI_TableTableAdapter.FilterByAssignee(this._Test___CopyDataSet.PBI_Table, assigneeToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByServiceToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.pBI_TableTableAdapter.FilterByService(this._Test___CopyDataSet.PBI_Table, serviceToolStripTextBox.Text);
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
                this.pBI_TableTableAdapter.FilterByStatus(this._Test___CopyDataSet.PBI_Table, statusToolStripTextBox.Text);
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
                this.pBI_TableTableAdapter.FilterByRemarks(this._Test___CopyDataSet.PBI_Table, remarksToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByAssessmentPOCMDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pBI_TableTableAdapter.FilterByAssessmentPOCMD(this._Test___CopyDataSet.PBI_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(assessment_POC_MDToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByAssessmentPOCMDAtLeastToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pBI_TableTableAdapter.FilterByAssessmentPOCMDAtLeast(this._Test___CopyDataSet.PBI_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(assessment_POC_MDToolStripTextBox1.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        //private void FilterByAssessmentPOCMDAtMostToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.pBI_TableTableAdapter.FilterByAssessmentPOCMDAtMost(this._Test___CopyDataSet.PBI_Table);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        private void FilterByBuildSTMDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pBI_TableTableAdapter.FilterByBuildSTMD(this._Test___CopyDataSet.PBI_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(build___ST_MDToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByBuildSTMDAtLeastToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pBI_TableTableAdapter.FilterByBuildSTMDAtLeast(this._Test___CopyDataSet.PBI_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(build___ST_MDToolStripTextBox1.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByBuildSTMDAtMostToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pBI_TableTableAdapter.FilterByBuildSTMDAtMost(this._Test___CopyDataSet.PBI_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(build___ST_MDToolStripTextBox2.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByAssessmentPOCMDAtMostToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.pBI_TableTableAdapter.FilterByAssessmentPOCMDAtMost(this._Test___CopyDataSet.PBI_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(assessment_POC_MDToolStripTextBox2.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByManagementSITUATMDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pBI_TableTableAdapter.FilterByManagementSITUATMD(this._Test___CopyDataSet.PBI_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(management__SIT___UAT_MDToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByManagementSITUATMDAtLeastToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pBI_TableTableAdapter.FilterByManagementSITUATMDAtLeast(this._Test___CopyDataSet.PBI_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(management__SIT___UAT_MDToolStripTextBox1.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        //private void FilterByManagementSITUATMDAtMostToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.pBI_TableTableAdapter.FilterByManagementSITUATMDAtMost(this._Test___CopyDataSet.PBI_Table);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        private void FilterByManagementSITUATMDAtMostToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.pBI_TableTableAdapter.FilterByManagementSITUATMDAtMost(this._Test___CopyDataSet.PBI_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(management__SIT___UAT_MDToolStripTextBox2.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByTotalMDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pBI_TableTableAdapter.FilterByTotalMD(this._Test___CopyDataSet.PBI_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(total_MDToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByTotalMDAtLeastToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pBI_TableTableAdapter.FilterByTotalMDAtLeast(this._Test___CopyDataSet.PBI_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(total_MDToolStripTextBox1.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByTotalMDAtMostToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pBI_TableTableAdapter.FilterByTotalMDAtMost(this._Test___CopyDataSet.PBI_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(total_MDToolStripTextBox2.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        //private void FilterByAdditionalRemarksToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.pBI_TableTableAdapter.FilterByAdditionalRemarks(this._Test___CopyDataSet.PBI_Table);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        private void FilterByAdditionalRemarksToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.pBI_TableTableAdapter.FilterByAdditionalRemarks(this._Test___CopyDataSet.PBI_Table, additional_RemarksToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByIssueToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pBI_TableTableAdapter.FilterByIssue(this._Test___CopyDataSet.PBI_Table, issueToolStripTextBox.Text);
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
                this.pBI_TableTableAdapter.ListAll(this._Test___CopyDataSet.PBI_Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = comboBox1.SelectedItem.ToString();
            ToolStrip[] toolStripArray = new ToolStrip[22];
            toolStripArray[0] = listAllToolStrip;
            toolStripArray[1] = filterByCRQNumberToolStrip;
            toolStripArray[2] = filterByPBINumberToolStrip;
            toolStripArray[3] = filterByProblemCoordinatorToolStrip;
            toolStripArray[4] = filterByServiceToolStrip;
            toolStripArray[5] = filterByAssigneeToolStrip;
            toolStripArray[6] = filterByStatusToolStrip;
            toolStripArray[7] = filterByRemarksToolStrip;
            toolStripArray[8] = filterByAssessmentPOCMDToolStrip;
            toolStripArray[9] = filterByAssessmentPOCMDAtLeastToolStrip;
            toolStripArray[10] = filterByAssessmentPOCMDAtMostToolStrip;
            toolStripArray[11] = filterByBuildSTMDToolStrip;
            toolStripArray[12] = filterByBuildSTMDAtLeastToolStrip;
            toolStripArray[13] = filterByBuildSTMDAtMostToolStrip;
            toolStripArray[14] = filterByManagementSITUATMDToolStrip;
            toolStripArray[15] = filterByManagementSITUATMDAtLeastToolStrip;
            toolStripArray[16] = filterByManagementSITUATMDAtMostToolStrip;
            toolStripArray[17] = filterByTotalMDToolStrip;
            toolStripArray[18] = filterByTotalMDAtLeastToolStrip;
            toolStripArray[19] = filterByTotalMDAtMostToolStrip;
            toolStripArray[20] = filterByAdditionalRemarksToolStrip;
            toolStripArray[21] = filterByIssueToolStrip;


            toggleVisibility(selectedFilter, toolStripArray);

        }

        private void toggleVisibility(string id, ToolStrip[] toolStripArray)
        {



            if (!id.Equals("List All"))
            {
                string third = id.Substring(10);
                if (third.IndexOf(" ") != -1 || third.IndexOf("&") != -1 || third.IndexOf(",") != -1 || third.IndexOf("/") != -1)
                {
                    List<char> thirdTemp = new List<char>();
                    for (int i = 0; i < third.Length; i++)
                    {
                        if (!(third[i].Equals(' ')) && !(third[i].Equals('&')) && !(third[i].Equals(',')) && !(third[i].Equals('/')))
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

        private void Button3_Click(object sender, EventArgs e)
        {
            this.pBITableBindingSource.RemoveCurrent();
        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pBI_TableTableAdapter.FillBy(this._Test___CopyDataSet.PBI_Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pBI_TableTableAdapter.FillBy1(this._Test___CopyDataSet.PBI_Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByCRQNumberToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pBI_TableTableAdapter.FilterByCRQNumber(this._Test___CopyDataSet.PBI_Table, cRQ__ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void IssueToolStripLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
