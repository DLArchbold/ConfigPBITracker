using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pbitrackerDataSet1.Test_Table' table. You can move, or remove it, as needed.
            this.test_TableTableAdapter.Fill(this._Test___CopyDataSet.Test_Table);





            //Hide toolstrips
            ToolStrip[] toolStripArray = new ToolStrip[6];
            toolStripArray[0] = filterByUCRNumToolStrip;
            toolStripArray[1] = filterByRequestDateToolStrip;
            toolStripArray[2] = filterByTestDateToolStrip;
            toolStripArray[3] = filterByRFSToolStrip;
            toolStripArray[4] = filterByServiceToolStrip;
            toolStripArray[5] = filterByEnvironmentToolStrip;


            for (int i = 0; i < toolStripArray.Length; i++)
            {
                toolStripArray[i].Visible = false;
            }




            //Set default selected values
            string[] listOfFilters = { "Filter/List all", "List All", "Filter by UCRNum", "Filter by Request Date",
                                       "Filter by Test Date", "Filter by RFS", "Filter by Service", "Filter by Environment",
                                       "Filter by Type", "Filter by Item", "Filter by Subject", "Filter by Raised By", "Filter by PIC",
                                       "Filter by Status", "Filter by Complexity",
                                       "Filter by Assessment/POC MD", "Filter by Assessment/POC MD At Least", "Filter by Assessment/POC MD At Most",
                                       "Filter by Build & ST MD", "Filter by Build & ST MD At Least", "Filter by Build & ST MD At Most",
                                       "Filter by SIT & UAT MD", "Filter by SIT & UAT MD At Least", "Filter by SIT & UAT MD At Most",
                                       "Filter by Total MD", "Filter by Total MD At Least", "Filter by Total MD At Most"};
            comboBox1.Items.AddRange(listOfFilters);
            comboBox1.SelectedIndex = 0;


        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            testTableBindingSource6.AddNew();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox17.Text = (Int32.Parse(textBox14.Text) + Int32.Parse(textBox15.Text) + Int32.Parse(textBox16.Text)).ToString();
            // Day.Text = Convert.ToDateTime(textBox4.Text);
            //Day.Text = DateTime.ParseExact(textBox4.Text, "mm/dd/YYYY", null);
            DateTime dateTemp = DateTime.Parse(textBox4.Text);
            Day.Text = dateTemp.Day.ToString();

            Mth.Text = dateTemp.Month.ToString() + "-" + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Int32.Parse(dateTemp.Month.ToString()));
            Yr.Text = dateTemp.Year.ToString(); 
            

            testTableBindingSource6.EndEdit();

            
            this.test_TableTableAdapter.Update(_Test___CopyDataSet.Test_Table);

            MessageBox.Show("OK");

 



        }
        
     

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FillBy(this._Test___CopyDataSet.Test_Table);
                
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
                this.test_TableTableAdapter.FillBy1(this._Test___CopyDataSet.Test_Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FillBy2(this._Test___CopyDataSet.Test_Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void FilterByServiceToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByService(this._Test___CopyDataSet.Test_Table, serviceToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = comboBox1.SelectedItem.ToString();
            ToolStrip[] toolStripArray = new ToolStrip[26];
            toolStripArray[0] = listAllToolStrip;
            toolStripArray[1] = filterByUCRNumToolStrip;
            toolStripArray[2] = filterByRequestDateToolStrip;
            toolStripArray[3] = filterByTestDateToolStrip;
            toolStripArray[4] = filterByRFSToolStrip;
            toolStripArray[5] = filterByServiceToolStrip;
            toolStripArray[6] = filterByEnvironmentToolStrip;
            toolStripArray[7] = filterByType2ToolStrip;
            toolStripArray[8] = filterByItemToolStrip;
            toolStripArray[9] = filterBySubjectToolStrip;
            toolStripArray[10] = filterByRaisedByToolStrip;
            toolStripArray[11] = filterByPICToolStrip;
            toolStripArray[12] = filterByStatusToolStrip;
            toolStripArray[13] = filterByComplexityToolStrip;
            toolStripArray[14] = filterByAssessmentPOCMDToolStrip;
            toolStripArray[15] = filterByAssessmentPOCMDAtLeastToolStrip;
            toolStripArray[16] = filterByAssessmentPOCMDAtMostToolStrip;
            toolStripArray[17] = filterByBuildSTMDToolStrip;
            toolStripArray[18] = filterByBuildSTMDAtLeastToolStrip;
            toolStripArray[19] = filterByBuildSTMDAtMostToolStrip;
            toolStripArray[20] = filterBySITUATMDToolStrip;
            toolStripArray[21] = filterBySITUATMDAtLeastToolStrip;
            toolStripArray[22] = filterBySITUATMDAtMostToolStrip;
            toolStripArray[23] = filterByTotalMDToolStrip;
            toolStripArray[24] = filterByTotalMDAtLeastToolStrip;
            toolStripArray[25] = filterByTotalMDAtMostToolStrip;



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




        private void FilterByUCRNumToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByUCRNum(this._Test___CopyDataSet.Test_Table, uCR_ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByUCRNumToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FilterByServiceToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FilterByRequestDateToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByRequestDate(this._Test___CopyDataSet.Test_Table, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(request_DateToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByRequestDateToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FilterByTestDateToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByTestDate(this._Test___CopyDataSet.Test_Table, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(test_DateToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByTestDateToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FilterByRFSToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByRFS(this._Test___CopyDataSet.Test_Table, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(rFSToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByRFSToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FilterByEnvironmentToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByEnvironment(this._Test___CopyDataSet.Test_Table, environmentToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByEnvironmentToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FilterByServiceToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByService(this._Test___CopyDataSet.Test_Table, serviceToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByUCRNumToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByUCRNum(this._Test___CopyDataSet.Test_Table, uCR_ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByRequestDateToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByRequestDate(this._Test___CopyDataSet.Test_Table, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(request_DateToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByTestDateToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByTestDate(this._Test___CopyDataSet.Test_Table, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(test_DateToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByRFSToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByRFS(this._Test___CopyDataSet.Test_Table, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(rFSToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByEnvironmentToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //this.test_TableTableAdapter.FilterByEnvironment(this._Test___CopyDataSet.Test_Table, environmentToolStripTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ToolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void FilterByEnvironmentToolStripButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                //this.test_TableTableAdapter.FilterByEnvironment(this._Test___CopyDataSet.Test_Table, environmentToolStripTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByRFSToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByRFS(this._Test___CopyDataSet.Test_Table, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(rFSToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByRFSToolStripButton_Click_3(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByRFS(this._Test___CopyDataSet.Test_Table, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(rFSToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByRFSToolStripButton_Click_4(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByRFS(this._Test___CopyDataSet.Test_Table, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(rFSToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByRFSToolStrip_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FilterByTypeToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByType(this._Test___CopyDataSet.Test_Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByType2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByType2(this._Test___CopyDataSet.Test_Table, typeToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByEnvironmentToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByEnvironment(this._Test___CopyDataSet.Test_Table, environmentToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByItemToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByItem(this._Test___CopyDataSet.Test_Table, itemToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterBySubjectToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterBySubject(this._Test___CopyDataSet.Test_Table, subjectToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByRaisedByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByRaisedBy(this._Test___CopyDataSet.Test_Table, raised_byToolStripTextBox.Text);
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
                this.test_TableTableAdapter.FilterByPIC(this._Test___CopyDataSet.Test_Table, pICToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FillByStatusToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FillByStatus(this._Test___CopyDataSet.Test_Table, statusToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByComplexityToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByComplexity(this._Test___CopyDataSet.Test_Table, complexityToolStripTextBox.Text);
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
                this.test_TableTableAdapter.FilterByStatus(this._Test___CopyDataSet.Test_Table, statusToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByTestDateToolStrip_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void ListAllToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.ListAll(this._Test___CopyDataSet.Test_Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            CRQ CRQTable = new CRQ();
            CRQTable.Show();
            this.Hide();

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            PBI pbiTable = new PBI();
            this.Hide();
            pbiTable.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {

            Window windowTable = new Window();
            windowTable.Show();

            this.Hide();

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            this.testTableBindingSource6.RemoveCurrent();
        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void TextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void FilterByAssessmentPOCMDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByAssessmentPOCMD(this._Test___CopyDataSet.Test_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(assessment_POC_MDToolStripTextBox.Text, typeof(int))))));
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
                this.test_TableTableAdapter.FilterByAssessmentPOCMDAtLeast(this._Test___CopyDataSet.Test_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(assessment_POC_MDToolStripTextBox1.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByAssessmentPOCMDAtMostToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByAssessmentPOCMDAtMost(this._Test___CopyDataSet.Test_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(assessment_POC_MDToolStripTextBox2.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterByBuildSTMDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByBuildSTMD(this._Test___CopyDataSet.Test_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(build___ST_MDToolStripTextBox.Text, typeof(int))))));
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
                this.test_TableTableAdapter.FilterByBuildSTMDAtLeast(this._Test___CopyDataSet.Test_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(build___ST_MDToolStripTextBox1.Text, typeof(int))))));
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
                this.test_TableTableAdapter.FilterByBuildSTMDAtMost(this._Test___CopyDataSet.Test_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(build___ST_MDToolStripTextBox2.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterBySITUATMDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterBySITUATMD(this._Test___CopyDataSet.Test_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(sIT___UAT_MDToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterBySITUATMDAtLeastToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterBySITUATMDAtLeast(this._Test___CopyDataSet.Test_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(sIT___UAT_MDToolStripTextBox1.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FilterBySITUATMDAtMostToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterBySITUATMDAtMost(this._Test___CopyDataSet.Test_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(sIT___UAT_MDToolStripTextBox2.Text, typeof(int))))));
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
                this.test_TableTableAdapter.FilterByTotalMD(this._Test___CopyDataSet.Test_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(total_MDToolStripTextBox.Text, typeof(int))))));
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
                this.test_TableTableAdapter.FilterByTotalMDAtLeast(this._Test___CopyDataSet.Test_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(total_MDToolStripTextBox1.Text, typeof(int))))));
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
                this.test_TableTableAdapter.FilterByTotalMDAtMost(this._Test___CopyDataSet.Test_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(total_MDToolStripTextBox2.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            ConfigSummary configSummary = new ConfigSummary();
            this.Hide();
            configSummary.Show();
        }

        private void Yr_TextChanged(object sender, EventArgs e)
        {

        }

        private void Day_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void listAllToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.ListAll(this._Test___CopyDataSet.Test_Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void filterByUCRNumToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByUCRNum(this._Test___CopyDataSet.Test_Table, uCR_ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void filterByType2ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByType2(this._Test___CopyDataSet.Test_Table, typeToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void filterByTotalMDAtMostToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByTotalMDAtMost(this._Test___CopyDataSet.Test_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(total_MDToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void filterByTotalMDAtLeastToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByTotalMDAtLeast(this._Test___CopyDataSet.Test_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(total_MDToolStripTextBox1.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void filterByTotalMDToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByTotalMD(this._Test___CopyDataSet.Test_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(total_MDToolStripTextBox2.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void filterByTestDateToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByTestDate(this._Test___CopyDataSet.Test_Table, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(test_DateToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void filterBySubjectToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterBySubject(this._Test___CopyDataSet.Test_Table, subjectToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void filterByStatusToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByStatus(this._Test___CopyDataSet.Test_Table, statusToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void filterBySITUATMDAtMostToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterBySITUATMDAtMost(this._Test___CopyDataSet.Test_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(sIT___UAT_MDToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void filterBySITUATMDAtLeastToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterBySITUATMDAtLeast(this._Test___CopyDataSet.Test_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(sIT___UAT_MDToolStripTextBox1.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void filterBySITUATMDToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterBySITUATMD(this._Test___CopyDataSet.Test_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(sIT___UAT_MDToolStripTextBox2.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void filterByAssessmentPOCMDAtMostToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByAssessmentPOCMDAtMost(this._Test___CopyDataSet.Test_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(assessment_POC_MDToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void filterByAssessmentPOCMDAtLeastToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByAssessmentPOCMDAtLeast(this._Test___CopyDataSet.Test_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(assessment_POC_MDToolStripTextBox1.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void filterByAssessmentPOCMDToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByAssessmentPOCMD(this._Test___CopyDataSet.Test_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(assessment_POC_MDToolStripTextBox2.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        

        private void filterByRaisedByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByRaisedBy(this._Test___CopyDataSet.Test_Table, raised_byToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void filterByRequestDateToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByRequestDate(this._Test___CopyDataSet.Test_Table, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(request_DateToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void filterByRFSToolStripButton_Click_5(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByRFS(this._Test___CopyDataSet.Test_Table, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(rFSToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void filterByEnvironmentToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByEnvironment(this._Test___CopyDataSet.Test_Table, environmentToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void filterByItemToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByItem(this._Test___CopyDataSet.Test_Table, itemToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void filterByPICToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByPIC(this._Test___CopyDataSet.Test_Table, pICToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void filterByServiceToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByService(this._Test___CopyDataSet.Test_Table, serviceToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void filterByComplexityToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByComplexity(this._Test___CopyDataSet.Test_Table, complexityToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void filterByBuildSTMDToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByBuildSTMD(this._Test___CopyDataSet.Test_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(build___ST_MDToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void filterByBuildSTMDAtLeastToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByBuildSTMDAtLeast(this._Test___CopyDataSet.Test_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(build___ST_MDToolStripTextBox1.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void filterByBuildSTMDAtMostToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.test_TableTableAdapter.FilterByBuildSTMDAtMost(this._Test___CopyDataSet.Test_Table, new System.Nullable<int>(((int)(System.Convert.ChangeType(build___ST_MDToolStripTextBox2.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
