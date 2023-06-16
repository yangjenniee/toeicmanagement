
namespace WindowsFormsApp11
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.수강생관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.수강생등ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.성적관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.선생님관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.시간표ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tBstudentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studentDBDataSet1 = new WindowsFormsApp11.StudentDBDataSet1();
            this.studentDBDataSet = new WindowsFormsApp11.StudentDBDataSet();
            this.tBstudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBstudentTableAdapter = new WindowsFormsApp11.StudentDBDataSetTableAdapters.TBstudentTableAdapter();
            this.studentDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBstudentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tBstudentTableAdapter1 = new WindowsFormsApp11.StudentDBDataSet1TableAdapters.TBstudentTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBstudentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBstudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBstudentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuStrip1.Font = new System.Drawing.Font("나눔고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.수강생관리ToolStripMenuItem,
            this.선생님관리ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1009, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 수강생관리ToolStripMenuItem
            // 
            this.수강생관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.수강생등ToolStripMenuItem,
            this.성적관리ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.종료ToolStripMenuItem});
            this.수강생관리ToolStripMenuItem.Name = "수강생관리ToolStripMenuItem";
            this.수강생관리ToolStripMenuItem.Size = new System.Drawing.Size(119, 25);
            this.수강생관리ToolStripMenuItem.Text = "수강생 관리";
            // 
            // 수강생등ToolStripMenuItem
            // 
            this.수강생등ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.수강생등ToolStripMenuItem.Name = "수강생등ToolStripMenuItem";
            this.수강생등ToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.수강생등ToolStripMenuItem.Text = "수강생 등록,수정,삭제";
            this.수강생등ToolStripMenuItem.Click += new System.EventHandler(this.수강생등ToolStripMenuItem_Click);
            // 
            // 성적관리ToolStripMenuItem
            // 
            this.성적관리ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.성적관리ToolStripMenuItem.Name = "성적관리ToolStripMenuItem";
            this.성적관리ToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.성적관리ToolStripMenuItem.Text = "성적 관리";
            this.성적관리ToolStripMenuItem.Click += new System.EventHandler(this.성적관리ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(275, 6);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // 선생님관리ToolStripMenuItem
            // 
            this.선생님관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.시간표ToolStripMenuItem});
            this.선생님관리ToolStripMenuItem.Name = "선생님관리ToolStripMenuItem";
            this.선생님관리ToolStripMenuItem.Size = new System.Drawing.Size(137, 25);
            this.선생님관리ToolStripMenuItem.Text = "학생 개인관리";
            // 
            // 시간표ToolStripMenuItem
            // 
            this.시간표ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.시간표ToolStripMenuItem.Name = "시간표ToolStripMenuItem";
            this.시간표ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.시간표ToolStripMenuItem.Text = "점수별 통계";
            this.시간표ToolStripMenuItem.Click += new System.EventHandler(this.시간표ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "KSU TOEIC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(287, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "고득점의 비결";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Font = new System.Drawing.Font("나눔고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(263, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 93);
            this.button1.TabIndex = 3;
            this.button1.Text = "TOEIC 시험 일정";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MistyRose;
            this.button2.Font = new System.Drawing.Font("나눔고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(263, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 93);
            this.button2.TabIndex = 4;
            this.button2.Text = "TOEIC 관련 사이트";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MistyRose;
            this.button3.Font = new System.Drawing.Font("나눔고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(18, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 93);
            this.button3.TabIndex = 5;
            this.button3.Text = "6월 예상 LC 문제";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MistyRose;
            this.button4.Font = new System.Drawing.Font("나눔고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(18, 205);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(183, 93);
            this.button4.TabIndex = 6;
            this.button4.Text = "6월 예상 RC 문제";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tBstudentBindingSource2
            // 
            this.tBstudentBindingSource2.DataMember = "TBstudent";
            this.tBstudentBindingSource2.DataSource = this.studentDBDataSet1;
            // 
            // studentDBDataSet1
            // 
            this.studentDBDataSet1.DataSetName = "StudentDBDataSet1";
            this.studentDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MistyRose;
            this.button5.Font = new System.Drawing.Font("나눔고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(18, 317);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(183, 93);
            this.button5.TabIndex = 9;
            this.button5.Text = "조회 업무";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBstudentBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(525, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(456, 253);
            this.dataGridView1.TabIndex = 10;
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
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "class";
            this.classDataGridViewTextBoxColumn.HeaderText = "class";
            this.classDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            this.classDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentDBDataSetBindingSource1
            // 
            this.studentDBDataSetBindingSource1.DataSource = this.studentDBDataSet;
            this.studentDBDataSetBindingSource1.Position = 0;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MistyRose;
            this.button6.Font = new System.Drawing.Font("나눔고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Location = new System.Drawing.Point(881, 370);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(69, 52);
            this.button6.TabIndex = 11;
            this.button6.Text = "새로\r\n고침\r\n";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Linen;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(536, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "수강생 목록";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.MistyRose;
            this.button7.Font = new System.Drawing.Font("나눔고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button7.Location = new System.Drawing.Point(263, 317);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(183, 93);
            this.button7.TabIndex = 13;
            this.button7.Text = "종 료";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1009, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "경성토익학원";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBstudentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBstudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBstudentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 수강생관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 수강생등ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 성적관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 선생님관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 시간표ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private StudentDBDataSet studentDBDataSet;
        private System.Windows.Forms.BindingSource tBstudentBindingSource;
        private StudentDBDataSetTableAdapters.TBstudentTableAdapter tBstudentTableAdapter;
        private System.Windows.Forms.BindingSource tBstudentBindingSource1;
        private System.Windows.Forms.BindingSource studentDBDataSetBindingSource;
        private StudentDBDataSet1 studentDBDataSet1;
        private System.Windows.Forms.BindingSource tBstudentBindingSource2;
        private StudentDBDataSet1TableAdapters.TBstudentTableAdapter tBstudentTableAdapter1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentDBDataSetBindingSource1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
    }
}

