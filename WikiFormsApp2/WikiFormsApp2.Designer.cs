namespace WikiFormsApp2
{
    partial class WikiFormsApp2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Name");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Category");
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.radioButtonLinear = new System.Windows.Forms.RadioButton();
            this.radioButtonNonLinear = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBoxStructure = new System.Windows.Forms.GroupBox();
            this.listView = new System.Windows.Forms.ListView();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.LabelDefinition = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxStructure.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(93, 12);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 1;
            this.buttonDel.Text = "DEL";
            this.buttonDel.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(174, 12);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "EDIT";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 41);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(121, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(12, 70);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategory.TabIndex = 4;
            // 
            // radioButtonLinear
            // 
            this.radioButtonLinear.AutoSize = true;
            this.radioButtonLinear.Location = new System.Drawing.Point(6, 27);
            this.radioButtonLinear.Name = "radioButtonLinear";
            this.radioButtonLinear.Size = new System.Drawing.Size(54, 17);
            this.radioButtonLinear.TabIndex = 5;
            this.radioButtonLinear.TabStop = true;
            this.radioButtonLinear.Text = "Linear";
            this.radioButtonLinear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.radioButtonLinear.UseVisualStyleBackColor = true;
            // 
            // radioButtonNonLinear
            // 
            this.radioButtonNonLinear.AutoSize = true;
            this.radioButtonNonLinear.Location = new System.Drawing.Point(94, 27);
            this.radioButtonNonLinear.Name = "radioButtonNonLinear";
            this.radioButtonNonLinear.Size = new System.Drawing.Size(77, 17);
            this.radioButtonNonLinear.TabIndex = 6;
            this.radioButtonNonLinear.TabStop = true;
            this.radioButtonNonLinear.Text = "Non-Linear";
            this.radioButtonNonLinear.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 193);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(246, 195);
            this.textBox2.TabIndex = 7;
            // 
            // groupBoxStructure
            // 
            this.groupBoxStructure.Controls.Add(this.radioButtonLinear);
            this.groupBoxStructure.Controls.Add(this.radioButtonNonLinear);
            this.groupBoxStructure.Location = new System.Drawing.Point(12, 97);
            this.groupBoxStructure.Name = "groupBoxStructure";
            this.groupBoxStructure.Size = new System.Drawing.Size(192, 48);
            this.groupBoxStructure.TabIndex = 8;
            this.groupBoxStructure.TabStop = false;
            this.groupBoxStructure.Text = "Structure";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderCategory});
            this.listView.HideSelection = false;
            this.listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView.Location = new System.Drawing.Point(279, 41);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(291, 377);
            this.listView.TabIndex = 9;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(148, 44);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(35, 13);
            this.LabelName.TabIndex = 10;
            this.LabelName.Text = "Name";
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Location = new System.Drawing.Point(148, 73);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(49, 13);
            this.LabelCategory.TabIndex = 11;
            this.LabelCategory.Text = "Category";
            // 
            // LabelDefinition
            // 
            this.LabelDefinition.AutoSize = true;
            this.LabelDefinition.Location = new System.Drawing.Point(13, 174);
            this.LabelDefinition.Name = "LabelDefinition";
            this.LabelDefinition.Size = new System.Drawing.Size(51, 13);
            this.LabelDefinition.TabIndex = 12;
            this.LabelDefinition.Text = "Definition";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(279, 14);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(144, 20);
            this.textBoxSearch.TabIndex = 13;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(458, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 14;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(12, 394);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 15;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(106, 395);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 20;
            // 
            // columnHeaderCategory
            // 
            this.columnHeaderCategory.Text = "Category";
            this.columnHeaderCategory.Width = 20;
            // 
            // WikiFormsApp2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 428);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.LabelDefinition);
            this.Controls.Add(this.LabelCategory);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.groupBoxStructure);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Name = "WikiFormsApp2";
            this.Text = "Data Structures Wiki";
            this.groupBoxStructure.ResumeLayout(false);
            this.groupBoxStructure.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.RadioButton radioButtonLinear;
        private System.Windows.Forms.RadioButton radioButtonNonLinear;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBoxStructure;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.Label LabelDefinition;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderCategory;
    }
}

