
namespace WindowsFormsApp11
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentDBDataSet2 = new WindowsFormsApp11.StudentDBDataSet2();
            this.studentDBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDBDataSet1 = new WindowsFormsApp11.StudentDBDataSet1();
            this.studentDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDBDataSet = new WindowsFormsApp11.StudentDBDataSet();
            this.tBstudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBstudentTableAdapter = new WindowsFormsApp11.StudentDBDataSetTableAdapters.TBstudentTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.studentDBDataSet2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentDBDataSet3 = new WindowsFormsApp11.StudentDBDataSet3();
            this.tBstudentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tBstudentTableAdapter1 = new WindowsFormsApp11.StudentDBDataSet3TableAdapters.TBstudentTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBstudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBstudentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.goalDataGridViewTextBoxColumn,
            this.testDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBstudentBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(26, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(749, 217);
            this.dataGridView1.TabIndex = 0;
            // 
            // studentDBDataSet2
            // 
            this.studentDBDataSet2.DataSetName = "StudentDBDataSet2";
            this.studentDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDBDataSet2BindingSource
            // 
            this.studentDBDataSet2BindingSource.DataSource = this.studentDBDataSet2;
            this.studentDBDataSet2BindingSource.Position = 0;
            // 
            // studentDBDataSet1
            // 
            this.studentDBDataSet1.DataSetName = "StudentDBDataSet1";
            this.studentDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDBDataSet1BindingSource
            // 
            this.studentDBDataSet1BindingSource.DataSource = this.studentDBDataSet1;
            this.studentDBDataSet1BindingSource.Position = 0;
            // 
            // studentDBDataSet
            // 
            this.studentDBDataSet.DataSetName = "StudentDBDataSet";
            this.studentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBstudentBindingSource
            // 
            this.tBstudentBindingSource.DataMember = "TBstudent";
            this.tBstudentBindingSource.DataSource = this.studentDBDataSet;
            // 
            // tBstudentTableAdapter
            // 
            this.tBstudentTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("나눔고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(15, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 69);
            this.button1.TabIndex = 1;
            this.button1.Text = "600점\r\n이하";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("나눔고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(146, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 69);
            this.button2.TabIndex = 2;
            this.button2.Text = "600점대";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("나눔고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(282, 274);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 69);
            this.button3.TabIndex = 3;
            this.button3.Text = "700점대";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("나눔고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(415, 274);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 69);
            this.button4.TabIndex = 4;
            this.button4.Text = "800점대";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button5.Font = new System.Drawing.Font("나눔고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(546, 274);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 69);
            this.button5.TabIndex = 5;
            this.button5.Text = "900점대\r\n";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button6.Font = new System.Drawing.Font("나눔고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Location = new System.Drawing.Point(668, 274);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(107, 69);
            this.button6.TabIndex = 6;
            this.button6.Text = "전체보기\r\n";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button7.Font = new System.Drawing.Font("나눔고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button7.Location = new System.Drawing.Point(668, 369);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(107, 69);
            this.button7.TabIndex = 7;
            this.button7.Text = "종료";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // studentDBDataSet2BindingSource1
            // 
            this.studentDBDataSet2BindingSource1.DataSource = this.studentDBDataSet2;
            this.studentDBDataSet2BindingSource1.Position = 0;
            // 
            // studentDBDataSet3
            // 
            this.studentDBDataSet3.DataSetName = "StudentDBDataSet3";
            this.studentDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBstudentBindingSource1
            // 
            this.tBstudentBindingSource1.DataMember = "TBstudent";
            this.tBstudentBindingSource1.DataSource = this.studentDBDataSet3;
            // 
            // tBstudentTableAdapter1
            // 
            this.tBstudentTableAdapter1.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
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
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "모의고사 점수별 통계";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBstudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBstudentBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studentDBDataSet1BindingSource;
        private StudentDBDataSet1 studentDBDataSet1;
        private StudentDBDataSet2 studentDBDataSet2;
        private System.Windows.Forms.BindingSource studentDBDataSet2BindingSource;
        private StudentDBDataSet studentDBDataSet;
        private System.Windows.Forms.BindingSource tBstudentBindingSource;
        private StudentDBDataSetTableAdapters.TBstudentTableAdapter tBstudentTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.BindingSource studentDBDataSet2BindingSource1;
        private StudentDBDataSet3 studentDBDataSet3;
        private System.Windows.Forms.BindingSource tBstudentBindingSource1;
        private StudentDBDataSet3TableAdapters.TBstudentTableAdapter tBstudentTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
    }
}