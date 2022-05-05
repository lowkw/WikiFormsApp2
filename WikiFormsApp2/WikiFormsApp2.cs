using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WikiFormsApp2
{
    public partial class WikiFormsApp2 : Form
    {
        // 6.2 Create a global List<T> of type Information called Wiki.
        List<Information> wikiList = new List<Information>();
        String[] categoryArray = new String[] { "Array", "List", "Tree", "Graphs", "Abstract", "Hash" };

        public WikiFormsApp2()
        {
            InitializeComponent();            
        }        

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Information addInformaion = new Information();
            addInformaion.Name = textBoxName.Text;
            addInformaion.Category = comboBoxCategory.SelectedItem.ToString();
            addInformaion.Structure = SelectedRadioButton();
            addInformaion.Definition = textBoxDefinition.Text;
            wikiList.Add(addInformaion);
        }
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private String SelectedRadioButton()
        {
            if (radioButtonLinear.Checked == true)
            {
                return radioButtonLinear.Text;
            } else
            {
                return radioButtonNonLinear.Text;
            }
        }
        private void WikiFormsApp2_Load(object sender, EventArgs e)
        {
            comboBoxCategory.DataSource = categoryArray;
        }

        
    }
}
