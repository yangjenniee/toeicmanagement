
namespace WindowsFormsApp11
{
    partial class Form3
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
            this.studentDBDataSet1 = new WindowsFormsApp11.StudentDBDataSet1();
            this.tBstudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBstudentTableAdapter = new WindowsFormsApp11.StudentDBDataSet1TableAdapters.TBstudentTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tBstudentBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.studentDBDataSet2 = new WindowsFormsApp11.StudentDBDataSet2();
            this.studentDBDataSet = new WindowsFormsApp11.StudentDBDataSet();
            this.studentDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBstudentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tBstudentTableAdapter1 = new WindowsFormsApp11.StudentDBDataSetTableAdapters.TBstudentTableAdapter();
            this.tBstudentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tBstudentTableAdapter2 = new WindowsFormsApp11.StudentDBDataSet2TableAdapters.TBstudentTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBstudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBstudentBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBstudentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBstudentBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // studentDBDataSet1
            // 
            this.studentDBDataSet1.DataSetName = "StudentDBDataSet1";
            this.studentDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBstudentBindingSource
            // 
            this.tBstudentBindingSource.DataMember = "TBstudent";
            this.tBstudentBindingSource.DataSource = this.studentDBDataSet1;
            // 
            // tBstudentTableAdapter
            // 
            this.tBstudentTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.goalDataGridViewTextBoxColumn,
            this.testDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBstudentBindingSource3;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.Location = new System.Drawing.Point(30, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(722, 273);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tBstudentBindingSource3
            // 
            this.tBstudentBindingSource3.DataMember = "TBstudent";
            this.tBstudentBindingSource3.DataSource = this.studentDBDataSet2;
            // 
            // studentDBDataSet2
            // 
            this.studentDBDataSet2.DataSetName = "StudentDBDataSet2";
            this.studentDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDBDataSet
            // 
            this.studentDBDataSet.DataSetName = "StudentDBDataSet";
            this.studentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDBDataSetBindingSource
            // 
            this.studentDBDataSetBindingSource.DataSource = this.studentDBDataSet;
            this.studentDBDataSetBindingSource.Position = 0;
            // 
            // tBstudentBindingSource1
            // 
            this.tBstudentBindingSource1.DataMember = "TBstudent";
            this.tBstudentBindingSource1.DataSource = this.studentDBDataSetBindingSource;
            // 
            // tBstudentTableAdapter1
            // 
            this.tBstudentTableAdapter1.ClearBeforeFill = true;
            // 
            // tBstudentBindingSource2
            // 
            this.tBstudentBindingSource2.DataMember = "TBstudent";
            this.tBstudentBindingSource2.DataSource = this.studentDBDataSetBindingSource;
            // 
            // tBstudentTableAdapter2
            // 
            this.tBstudentTableAdapter2.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LavenderBlush;
            this.button1.Font = new System.Drawing.Font("나눔고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(56, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 80);
            this.button1.TabIndex = 1;
            this.button1.Text = "성적부실\r\n학생조회\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LavenderBlush;
            this.button2.Font = new System.Drawing.Font("나눔고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(223, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 80);
            this.button2.TabIndex = 2;
            this.button2.Text = "성적우수\r\n학생조회\r\n";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // goalDataGridViewTextBoxColumn
            // 
            this.goalDataGridViewTextBoxColumn.DataPropertyName = "goal";
            this.goalDataGridViewTextBoxColumn.HeaderText = "goal";
            this.goalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goalDataGridViewTextBoxColumn.Name = "goalDataGridViewTextBoxColumn";
            this.goalDataGridViewTextBoxColumn.Width = 125;
            // 
            // testDataGridViewTextBoxColumn
            // 
            this.testDataGridViewTextBoxColumn.DataPropertyName = "test";
            this.testDataGridViewTextBoxColumn.HeaderText = "test";
            this.testDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.testDataGridViewTextBoxColumn.Name = "testDataGridViewTextBoxColumn";
            this.testDataGridViewTextBoxColumn.Width = 125;
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "class";
            this.classDataGridViewTextBoxColumn.HeaderText = "class";
            this.classDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            this.classDataGridViewTextBoxColumn.Width = 125;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LavenderBlush;
            this.button3.Font = new System.Drawing.Font("나눔고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(388, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 80);
            this.button3.TabIndex = 3;
            this.button3.Text = "전체학생\r\n조회";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LavenderBlush;
            this.button4.Font = new System.Drawing.Font("나눔고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(544, 339);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 80);
            this.button4.TabIndex = 4;
            this.button4.Text = "종료";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "성적관리창";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBstudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBstudentBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBstudentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBstudentBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private StudentDBDataSet1 studentDBDataSet1;
        private System.Windows.Forms.BindingSource tBstudentBindingSource;
        private StudentDBDataSet1TableAdapters.TBstudentTableAdapter tBstudentTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studentDBDataSetBindingSource;
        private StudentDBDataSet studentDBDataSet;
        private System.Windows.Forms.BindingSource tBstudentBindingSource1;
        private StudentDBDataSetTableAdapters.TBstudentTableAdapter tBstudentTableAdapter1;
        private System.Windows.Forms.BindingSource tBstudentBindingSource2;
        private StudentDBDataSet2 studentDBDataSet2;
        private System.Windows.Forms.BindingSource tBstudentBindingSource3;
        private StudentDBDataSet2TableAdapters.TBstudentTableAdapter tBstudentTableAdapter2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}