namespace Lembretes
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnCreate = new Button();
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dtData = new DateTimePicker();
            dgvLembretes = new DataGridView();
            dataDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lembreteBindingSource = new BindingSource(components);
            lembreteBindingSource1 = new BindingSource(components);
            label4 = new Label();
            dtFilterDate = new DateTimePicker();
            cbFiltrarData = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvLembretes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lembreteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lembreteBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(536, 27);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(82, 22);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Criar";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(68, 26);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(224, 23);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 28);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(306, 30);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 4;
            label2.Text = "Data";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 7);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 5;
            label3.Text = "Novo Lembrete";
            // 
            // dtData
            // 
            dtData.CustomFormat = "dd/MM/yyyy HH:mm";
            dtData.Format = DateTimePickerFormat.Custom;
            dtData.Location = new Point(347, 26);
            dtData.Margin = new Padding(3, 2, 3, 2);
            dtData.Name = "dtData";
            dtData.Size = new Size(183, 23);
            dtData.TabIndex = 6;
            dtData.Value = new DateTime(2023, 6, 17, 16, 12, 23, 0);
            // 
            // dgvLembretes
            // 
            dgvLembretes.AllowUserToAddRows = false;
            dgvLembretes.AllowUserToDeleteRows = false;
            dgvLembretes.AllowUserToOrderColumns = true;
            dgvLembretes.AllowUserToResizeColumns = false;
            dgvLembretes.AllowUserToResizeRows = false;
            dgvLembretes.AutoGenerateColumns = false;
            dgvLembretes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLembretes.Columns.AddRange(new DataGridViewColumn[] { dataDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            dgvLembretes.DataSource = lembreteBindingSource;
            dgvLembretes.Location = new Point(19, 104);
            dgvLembretes.Margin = new Padding(3, 2, 3, 2);
            dgvLembretes.MultiSelect = false;
            dgvLembretes.Name = "dgvLembretes";
            dgvLembretes.ReadOnly = true;
            dgvLembretes.RowHeadersWidth = 51;
            dgvLembretes.RowTemplate.Height = 29;
            dgvLembretes.Size = new Size(599, 233);
            dgvLembretes.TabIndex = 7;
            dgvLembretes.CellClick += dgvLembretes_CellClick;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            dataDataGridViewTextBoxColumn.HeaderText = "Data";
            dataDataGridViewTextBoxColumn.MinimumWidth = 6;
            dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            dataDataGridViewTextBoxColumn.ReadOnly = true;
            dataDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            dataDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            nameDataGridViewTextBoxColumn.Width = 300;
            // 
            // lembreteBindingSource
            // 
            lembreteBindingSource.DataSource = typeof(Models.Lembrete);
            // 
            // lembreteBindingSource1
            // 
            lembreteBindingSource1.DataSource = typeof(Models.Lembrete);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 62);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 8;
            label4.Text = "Lista de lembretes";
            // 
            // dtFilterDate
            // 
            dtFilterDate.CustomFormat = "dd/MM/yyyy";
            dtFilterDate.Format = DateTimePickerFormat.Custom;
            dtFilterDate.Location = new Point(212, 76);
            dtFilterDate.Margin = new Padding(3, 2, 3, 2);
            dtFilterDate.Name = "dtFilterDate";
            dtFilterDate.Size = new Size(102, 23);
            dtFilterDate.TabIndex = 9;
            dtFilterDate.Value = new DateTime(2023, 6, 17, 16, 12, 23, 0);
            dtFilterDate.ValueChanged += dtFilterDate_ValueChanged;
            // 
            // cbFiltrarData
            // 
            cbFiltrarData.AutoSize = true;
            cbFiltrarData.Location = new Point(19, 80);
            cbFiltrarData.Name = "cbFiltrarData";
            cbFiltrarData.Size = new Size(165, 19);
            cbFiltrarData.TabIndex = 10;
            cbFiltrarData.Text = "Filtrar lembretes pela data:";
            cbFiltrarData.UseVisualStyleBackColor = true;
            cbFiltrarData.Click += cbFiltrarData_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 351);
            Controls.Add(cbFiltrarData);
            Controls.Add(dtFilterDate);
            Controls.Add(label4);
            Controls.Add(dgvLembretes);
            Controls.Add(dtData);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(btnCreate);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Lembretes";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLembretes).EndInit();
            ((System.ComponentModel.ISupportInitialize)lembreteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)lembreteBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private TextBox txtName;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtData;
        private DataGridView dgvLembretes;
        private BindingSource lembreteBindingSource;
        private DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private BindingSource lembreteBindingSource1;
        private Label label4;
        private DateTimePicker dtFilterDate;
        private CheckBox cbFiltrarData;
    }
}