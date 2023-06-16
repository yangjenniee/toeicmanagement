
namespace WindowsFormsApp11
{
    partial class Form7
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tBdateBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.studentDBDataSet7 = new WindowsFormsApp11.StudentDBDataSet7();
            this.studentDBDataSet4 = new WindowsFormsApp11.StudentDBDataSet4();
            this.tBdateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBdateTableAdapter = new WindowsFormsApp11.StudentDBDataSet4TableAdapters.TBdateTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.studentDBDataSet5 = new WindowsFormsApp11.StudentDBDataSet5();
            this.tBdateBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tBdateTableAdapter1 = new WindowsFormsApp11.StudentDBDataSet5TableAdapters.TBdateTableAdapter();
            this.studentDBDataSet6 = new WindowsFormsApp11.StudentDBDataSet6();
            this.tBdateBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tBdateTableAdapter2 = new WindowsFormsApp11.StudentDBDataSet6TableAdapters.TBdateTableAdapter();
            this.tBdateTableAdapter3 = new WindowsFormsApp11.StudentDBDataSet7TableAdapters.TBdateTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBdateBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.studentDBDataSet8 = new WindowsFormsApp11.StudentDBDataSet8();
            this.tBdateTableAdapter4 = new WindowsFormsApp11.StudentDBDataSet8TableAdapters.TBdateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tBdateBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBdateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBdateBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBdateBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBdateBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 92);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(24, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "시험일자";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 25);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Font = new System.Drawing.Font("나눔고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(28, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 67);
            this.button1.TabIndex = 3;
            this.button1.Text = "날짜등록";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MistyRose;
            this.button2.Font = new System.Drawing.Font("나눔고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(167, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 67);
            this.button2.TabIndex = 4;
            this.button2.Text = "D-Day\r\n변경";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(403, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 25);
            this.textBox2.TabIndex = 5;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(310, 92);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 6;
            this.monthCalendar2.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateSelected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(306, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "오늘일자";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MistyRose;
            this.button3.Font = new System.Drawing.Font("나눔고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(310, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 67);
            this.button3.TabIndex = 8;
            this.button3.Text = "날짜 삭제";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MistyRose;
            this.button4.Font = new System.Drawing.Font("나눔고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(449, 341);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 67);
            this.button4.TabIndex = 9;
            this.button4.Text = "종료";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tBdateBindingSource3
            // 
            this.tBdateBindingSource3.DataMember = "TBdate";
            this.tBdateBindingSource3.DataSource = this.studentDBDataSet7;
            // 
            // studentDBDataSet7
            // 
            this.studentDBDataSet7.DataSetName = "StudentDBDataSet7";
            this.studentDBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDBDataSet4
            // 
            this.studentDBDataSet4.DataSetName = "StudentDBDataSet4";
            this.studentDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBdateBindingSource
            // 
            this.tBdateBindingSource.DataMember = "TBdate";
            this.tBdateBindingSource.DataSource = this.studentDBDataSet4;
            // 
            // tBdateTableAdapter
            // 
            this.tBdateTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MistyRose;
            this.button5.Font = new System.Drawing.Font("나눔고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(599, 45);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 41);
            this.button5.TabIndex = 11;
            this.button5.Text = "새로고침";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // studentDBDataSet5
            // 
            this.studentDBDataSet5.DataSetName = "StudentDBDataSet5";
            this.studentDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBdateBindingSource1
            // 
            this.tBdateBindingSource1.DataMember = "TBdate";
            this.tBdateBindingSource1.DataSource = this.studentDBDataSet5;
            // 
            // tBdateTableAdapter1
            // 
            this.tBdateTableAdapter1.ClearBeforeFill = true;
            // 
            // studentDBDataSet6
            // 
            this.studentDBDataSet6.DataSetName = "StudentDBDataSet6";
            this.studentDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBdateBindingSource2
            // 
            this.tBdateBindingSource2.DataMember = "TBdate";
            this.tBdateBindingSource2.DataSource = this.studentDBDataSet6;
            // 
            // tBdateTableAdapter2
            // 
            this.tBdateTableAdapter2.ClearBeforeFill = true;
            // 
            // tBdateTableAdapter3
            // 
            this.tBdateTableAdapter3.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.ddayDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBdateBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(599, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(463, 219);
            this.dataGridView1.TabIndex = 12;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // ddayDataGridViewTextBoxColumn
            // 
            this.ddayDataGridViewTextBoxColumn.DataPropertyName = "dday";
            this.ddayDataGridViewTextBoxColumn.HeaderText = "dday";
            this.ddayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ddayDataGridViewTextBoxColumn.Name = "ddayDataGridViewTextBoxColumn";
            this.ddayDataGridViewTextBoxColumn.Width = 125;
            // 
            // tBdateBindingSource4
            // 
            this.tBdateBindingSource4.DataMember = "TBdate";
            this.tBdateBindingSource4.DataSource = this.studentDBDataSet8;
            // 
            // studentDBDataSet8
            // 
            this.studentDBDataSet8.DataSetName = "StudentDBDataSet8";
            this.studentDBDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBdateTableAdapter4
            // 
            this.tBdateTableAdapter4.ClearBeforeFill = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1074, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form7";
            this.Text = "토익일정관리";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBdateBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBdateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBdateBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBdateBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBdateBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private StudentDBDataSet4 studentDBDataSet4;
        private System.Windows.Forms.BindingSource tBdateBindingSource;
        private StudentDBDataSet4TableAdapters.TBdateTableAdapter tBdateTableAdapter;
        private System.Windows.Forms.Button button5;
        private StudentDBDataSet5 studentDBDataSet5;
        private System.Windows.Forms.BindingSource tBdateBindingSource1;
        private StudentDBDataSet5TableAdapters.TBdateTableAdapter tBdateTableAdapter1;
        private StudentDBDataSet6 studentDBDataSet6;
        private System.Windows.Forms.BindingSource tBdateBindingSource2;
        private StudentDBDataSet6TableAdapters.TBdateTableAdapter tBdateTableAdapter2;
        private StudentDBDataSet7 studentDBDataSet7;
        private System.Windows.Forms.BindingSource tBdateBindingSource3;
        private StudentDBDataSet7TableAdapters.TBdateTableAdapter tBdateTableAdapter3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private StudentDBDataSet8 studentDBDataSet8;
        private System.Windows.Forms.BindingSource tBdateBindingSource4;
        private StudentDBDataSet8TableAdapters.TBdateTableAdapter tBdateTableAdapter4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddayDataGridViewTextBoxColumn;
    }
}