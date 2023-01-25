namespace kostya
{
    partial class tarif_form
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каталогиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покупателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.симкартыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контрактыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet = new kostya.Database1DataSet();
            this.tarifBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tarifTableAdapter = new kostya.Database1DataSetTableAdapters.tarifTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minutescallDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbinternetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbersmsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.каталогиToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(591, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.оПрограммеToolStripMenuItem.Text = "о программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // каталогиToolStripMenuItem
            // 
            this.каталогиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.покупателиToolStripMenuItem,
            this.симкартыToolStripMenuItem,
            this.контрактыToolStripMenuItem});
            this.каталогиToolStripMenuItem.Name = "каталогиToolStripMenuItem";
            this.каталогиToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.каталогиToolStripMenuItem.Text = "каталоги";
            // 
            // покупателиToolStripMenuItem
            // 
            this.покупателиToolStripMenuItem.Name = "покупателиToolStripMenuItem";
            this.покупателиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.покупателиToolStripMenuItem.Text = "покупатели";
            this.покупателиToolStripMenuItem.Click += new System.EventHandler(this.покупателиToolStripMenuItem_Click);
            // 
            // симкартыToolStripMenuItem
            // 
            this.симкартыToolStripMenuItem.Name = "симкартыToolStripMenuItem";
            this.симкартыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.симкартыToolStripMenuItem.Text = "сим-карты";
            this.симкартыToolStripMenuItem.Click += new System.EventHandler(this.симкартыToolStripMenuItem_Click);
            // 
            // контрактыToolStripMenuItem
            // 
            this.контрактыToolStripMenuItem.Name = "контрактыToolStripMenuItem";
            this.контрактыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.контрактыToolStripMenuItem.Text = "контракты";
            this.контрактыToolStripMenuItem.Click += new System.EventHandler(this.контрактыToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.minutescallDataGridViewTextBoxColumn,
            this.gbinternetDataGridViewTextBoxColumn,
            this.numbersmsDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tarifBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(563, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tarifBindingSource
            // 
            this.tarifBindingSource.DataMember = "tarif";
            this.tarifBindingSource.DataSource = this.database1DataSet;
            // 
            // tarifTableAdapter
            // 
            this.tarifTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // minutescallDataGridViewTextBoxColumn
            // 
            this.minutescallDataGridViewTextBoxColumn.DataPropertyName = "minutes_call";
            this.minutescallDataGridViewTextBoxColumn.HeaderText = "minutes_call";
            this.minutescallDataGridViewTextBoxColumn.Name = "minutescallDataGridViewTextBoxColumn";
            // 
            // gbinternetDataGridViewTextBoxColumn
            // 
            this.gbinternetDataGridViewTextBoxColumn.DataPropertyName = "gb_internet";
            this.gbinternetDataGridViewTextBoxColumn.HeaderText = "gb_internet";
            this.gbinternetDataGridViewTextBoxColumn.Name = "gbinternetDataGridViewTextBoxColumn";
            // 
            // numbersmsDataGridViewTextBoxColumn
            // 
            this.numbersmsDataGridViewTextBoxColumn.DataPropertyName = "number_sms";
            this.numbersmsDataGridViewTextBoxColumn.HeaderText = "number_sms";
            this.numbersmsDataGridViewTextBoxColumn.Name = "numbersmsDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // tarif_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "tarif_form";
            this.Text = "tarif_form";
            this.Load += new System.EventHandler(this.tarif_form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem каталогиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem покупателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem симкартыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контрактыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tarifBindingSource;
        private Database1DataSetTableAdapters.tarifTableAdapter tarifTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minutescallDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gbinternetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbersmsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}