using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WikiFormsApp2
{
    public partial class WikiFormsApp2 : Form
    {
        #region globals
        // 6.2 Create a global List<T> of type Information called Wiki.
        List<Information> wikiList = new List<Information>();
        #endregion globals

        #region forms
        public WikiFormsApp2()
        {
            InitializeComponent();
        }

        private void WikiFormsApp2_Load(object sender, EventArgs e)
        {
            //6.4 Create and initialise a global string array with the six categories as indicated in the Data Structure
            //Matrix. Create a custom method to populate the ComboBox when the Form Load method is called.
            //string[] categoryArray = new string[] { "Array", "List", "Tree", "Graphs", "Abstract", "Hash" };
            try
            {
                string[] categoryArray = System.IO.File.ReadAllLines(@"category.txt");
                comboBoxCategory.DataSource = categoryArray;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nCannot open category.txt for reading.");
            }
            try
            {
                //Stream traceFile = File.Create("Trace.txt");
                StreamWriter traceFile = File.AppendText("Trace.txt");
                Trace.Listeners.Add(new TextWriterTraceListener(traceFile));                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nCannot create the trace file.");
            }
        }

        //6.15 The Wiki application will save data when the form closes.
        private void WikiFormsApp2_FormClosing(Object sender, FormClosingEventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            if (MessageBox.Show("Do you want to save changes to a file?", "Wiki Application",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Cancel the Closing event from closing the form.
                e.Cancel = true;
                // Call method to save file...
                SaveFile();
                Trace.Close();
                e.Cancel = false;
            }
        }
        #endregion forms

        #region CRUD buttons
        //6.3 Create a button method to ADD a new item to the list.Use a TextBox for the Name input, ComboBox for
        //the Category, Radio group for the Structure and Multiline TextBox for the Definition.
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            if (ValidateInput())
            {
                Information newInformaion = new Information();
                newInformaion.Name = textBoxName.Text;
                newInformaion.Category = comboBoxCategory.SelectedItem.ToString();
                newInformaion.Structure = SelectedRadioButton();
                newInformaion.Definition = textBoxDefinition.Text;
                wikiList.Add(newInformaion);
                InitialiseInputs();
                DisplayList();
            }
        }

        //6.8 Create a button method that will save the edited record of the currently selected item in the ListView.
        //All the changes in the input controls will be written back to the list. Display an updated version of the
        //sorted list at the end of this process.
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            if (IsHandleCreated)
            {
                ListView.SelectedIndexCollection indexes = listView.SelectedIndices;
                if (indexes.Count == 0)
                {
                    MessageBox.Show("Click a Name in the list to EDIT");
                }
                else
                {
                    if (string.IsNullOrEmpty(textBoxName.Text))
                    {
                        MessageBox.Show("Name input can not change to empty.");
                    }
                    else
                    {
                        foreach (int index in indexes)
                        {
                            wikiList[index].Name = textBoxName.Text;
                            wikiList[index].Category = comboBoxCategory.SelectedItem.ToString();
                            wikiList[index].Structure = SelectedRadioButton();
                            wikiList[index].Definition = textBoxDefinition.Text;

                        }
                    }
                    InitialiseInputs();
                    DisplayList();
                }
            }
            else
            {
                MessageBox.Show("Click a Name in the list to EDIT");
            }
        }

        //6.7 Create a button method that will delete the currently selected record in the ListView. Ensure the user
        //has the option to backout of this action by using a dialog box. Display an updated version of the sorted list
        //at the end of this process.
        private void buttonDel_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            if (IsHandleCreated)
            {
                ListView.SelectedIndexCollection indexes = listView.SelectedIndices;
                if (indexes.Count == 0)
                {
                    MessageBox.Show("Click a Name in the list to DELETE");
                }
                else
                {
                    DialogResult delName = MessageBox.Show("Do you want to delete this Name ?",
                        "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (delName == DialogResult.Yes)
                    {
                        foreach (int index in indexes)
                        {
                            wikiList.RemoveAt(index);
                        }
                    }
                    InitialiseInputs();
                    DisplayList();
                }
            }
            else
            {
                MessageBox.Show("Click a Name in the list to DELETE");
            }

        }
        #endregion CRUD buttons

        #region binary search
        //6.10 Create a button method that will use the builtin binary search to find a Data Structure name.If the
        //record is found the associated details will populate the appropriate input controls and highlight the name in
        //the ListView.At the end of the search process the search input TextBox must be cleared.
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            Information infoName = new Information(textBoxSearch.Text);
            wikiList.Sort();            
            if (wikiList.BinarySearch(infoName) >= 0)
            {
                Trace.WriteLine(infoName.Name + " found.","Binary search ");
                Trace.Flush();                
                int index = wikiList.FindIndex(x => x.Name == textBoxSearch.Text);
                textBoxSearch.Clear();
                listView.Items[index].Selected = true;
                listView.Focus();
            }
            else
            {
                Trace.WriteLine(infoName.Name + " not found.", "Binary search ");
                Trace.Flush();                
                textBoxSearch.Clear();
                InitialiseInputs();
                DisplayList();
                toolStripStatusLabel1.Text = "Search not found";
            }            
        }
        #endregion binary search

        //6.13 Create a double click event on the Name TextBox to clear the TextBboxes, ComboBox and Radio
        //button.
        private void textBoxName_DoubleClick(object sender, EventArgs e)
        {
            InitialiseInputs();
            DisplayList();
        }

        #region FileIO
        //6.14 Create two buttons for the manual open and save option; this must use a dialog box to select a file or
        //rename a saved file. All Wiki data is stored/retrieved using a binary file format.
        private void buttonOpen_Click(object sender, EventArgs e)
        {            
            listView.Items.Clear();
            wikiList.Clear();
            InitialiseInputs();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Title = "Open a BIN file";
            openFileDialog.Filter = "BIN files|*.bin";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenRecord(openFileDialog.FileName);
            }
        }

        private void OpenRecord(string openFileName)
        {
            try
            {
                using (var stream = File.Open(openFileName, FileMode.Open))
                {
                    using (var br = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        while (br.BaseStream.Position != br.BaseStream.Length)
                        {
                            Information newInformaion = new Information();
                            newInformaion.Name = br.ReadString();
                            newInformaion.Category = br.ReadString();
                            newInformaion.Structure = br.ReadString();
                            newInformaion.Definition = br.ReadString();
                            wikiList.Add(newInformaion);
                            listView.Items.Add(new ListViewItem(new[] { newInformaion.Name, newInformaion.Category }));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nCannot open file for reading.");
                return;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            SaveFile();
        }

        private void SaveFile()
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "BIN files|*.bin";
            saveFileDialog.Title = "Save a BIN file";
            saveFileDialog.InitialDirectory = Application.StartupPath;
            saveFileDialog.DefaultExt = "bin";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveRecord(saveFileDialog.FileName);
            }
        }

        private void SaveRecord(string saveFileName)
        {
            try
            {
                using (var stream = File.Open(saveFileName, FileMode.Create))
                {
                    using (var bw = new BinaryWriter(stream, Encoding.UTF8, false))
                    {
                        foreach (var datastructure in wikiList)
                        {
                            bw.Write(datastructure.Name);
                            bw.Write(datastructure.Category);
                            bw.Write(datastructure.Structure);
                            bw.Write(datastructure.Definition);
                        }
                    }
                }
                InitialiseInputs();
                DisplayList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nCannot write data to file.");
                return;
            }
        }
        #endregion FileIO

        //6.11 Create a ListView event so a user can select a Data Structure Name from the list of Names and the
        //associated information will be displayed in the related text boxes combo box and radio button.
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            ListView.SelectedIndexCollection indexes = listView.SelectedIndices;
            foreach (int index in indexes)
            {
                textBoxName.Text = wikiList[index].Name;
                int comboIndex = comboBoxCategory.FindString(wikiList[index].Category);
                comboBoxCategory.SelectedIndex = comboIndex;
                int rbIndex = FindRadioButtonIndex(wikiList[index].Structure);
                if (rbIndex == 1)
                    radioButtonLinear.Checked = true;
                else
                    radioButtonNonLinear.Checked = true;
                textBoxDefinition.Text = wikiList[index].Definition;
            }
        }

        #region input validation
        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Name input must not be empty.");
                DisplayList();
                return false;
            }

            if (radioButtonLinear.Checked == false && radioButtonNonLinear.Checked == false)
            {
                MessageBox.Show("Select structure option Linear or Non-Linear.");
                DisplayList();
                return false;
            }

            if (ValidName(textBoxName.Text))
            {
                MessageBox.Show("Name existed and ADD action wasn't successful.");
                InitialiseInputs();
                DisplayList();
                return false;
            }
            else
            {
                return true;
            }
        }

        //6.5 Create a custom ValidName method which will take a parameter string value from the Textbox Name
        //and returns a Boolean after checking for duplicates. Use the built in List<T> method “Exists” to answer this
        //requirement.
        private bool ValidName(string name)
        {
            return wikiList.Exists(x => x.Name == name);
        }
        #endregion input validation

        #region radio button controls
        //6.6 Create two methods to highlight and return the values from the Radio button GroupBox. The first
        //method must return a string value from the selected radio button (Linear or Non-Linear). The second
        //method must send an integer index which will highlight an appropriate radio button.
        private string SelectedRadioButton()
        {
            if (radioButtonLinear.Checked == true)
            {
                return radioButtonLinear.Text;
            }
            else
            {
                return radioButtonNonLinear.Text;
            }
        }

        private int FindRadioButtonIndex(string structureName)
        {
            if (structureName.Equals(radioButtonLinear.Text))
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
        #endregion radio button controls

        //6.12 Create a custom method that will clear and reset the TextBboxes, ComboBox and Radio button
        private void InitialiseInputs()
        {
            textBoxName.Clear();
            comboBoxCategory.SelectedIndex = 0;
            radioButtonLinear.Checked = false;
            radioButtonNonLinear.Checked = false;
            textBoxDefinition.Clear();
            toolStripStatusLabel1.Text = "";
        }

        //6.9 Create a single custom method that will sort and then display the Name and Category from the wiki
        //information in the list.
        private void DisplayList()
        {
            listView.Items.Clear();
            wikiList.Sort();            
            foreach (var datastructure in wikiList)
            {
                listView.Items.Add(new ListViewItem(new[] { datastructure.Name, datastructure.Category }));
            }            
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar);
        }
    }
}
