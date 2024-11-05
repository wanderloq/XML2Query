namespace XML2Query
{
	// Token: 0x02000002 RID: 2
	public partial class XML2Query : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002070 File Offset: 0x00000270
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002A04 File Offset: 0x00000C04
		private void InitializeComponent()
		{
            this.btnLoadXML = new System.Windows.Forms.Button();
            this.txt_XMLLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_LoadDataTable = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_Parent = new System.Windows.Forms.TextBox();
            this.txt_Replace = new System.Windows.Forms.TextBox();
            this.btn_RenameCol = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Columns = new System.Windows.Forms.ComboBox();
            this.rtxt_GeneratedQuery = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TableName = new System.Windows.Forms.TextBox();
            this.btn_GenerateQuery = new System.Windows.Forms.Button();
            this.prb_Progress = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ss_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.ss_StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_DatabaseName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Hide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadXML
            // 
            this.btnLoadXML.Location = new System.Drawing.Point(299, 13);
            this.btnLoadXML.Name = "btnLoadXML";
            this.btnLoadXML.Size = new System.Drawing.Size(96, 23);
            this.btnLoadXML.TabIndex = 0;
            this.btnLoadXML.Text = "Load XML File";
            this.btnLoadXML.UseVisualStyleBackColor = true;
            this.btnLoadXML.Click += new System.EventHandler(this.btnLoadXML_Click);
            // 
            // txt_XMLLocation
            // 
            this.txt_XMLLocation.Location = new System.Drawing.Point(60, 16);
            this.txt_XMLLocation.Name = "txt_XMLLocation";
            this.txt_XMLLocation.ReadOnly = true;
            this.txt_XMLLocation.Size = new System.Drawing.Size(233, 20);
            this.txt_XMLLocation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Parent";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_LoadDataTable
            // 
            this.btn_LoadDataTable.Location = new System.Drawing.Point(299, 42);
            this.btn_LoadDataTable.Name = "btn_LoadDataTable";
            this.btn_LoadDataTable.Size = new System.Drawing.Size(96, 23);
            this.btn_LoadDataTable.TabIndex = 4;
            this.btn_LoadDataTable.Text = "Transfer to Table";
            this.btn_LoadDataTable.UseVisualStyleBackColor = true;
            this.btn_LoadDataTable.Click += new System.EventHandler(this.btn_LoadDataTable_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(768, 234);
            this.dataGridView1.TabIndex = 5;
            // 
            // txt_Parent
            // 
            this.txt_Parent.Location = new System.Drawing.Point(60, 42);
            this.txt_Parent.Name = "txt_Parent";
            this.txt_Parent.Size = new System.Drawing.Size(233, 20);
            this.txt_Parent.TabIndex = 6;
            // 
            // txt_Replace
            // 
            this.txt_Replace.Location = new System.Drawing.Point(494, 44);
            this.txt_Replace.Name = "txt_Replace";
            this.txt_Replace.Size = new System.Drawing.Size(205, 20);
            this.txt_Replace.TabIndex = 8;
            // 
            // btn_RenameCol
            // 
            this.btn_RenameCol.Location = new System.Drawing.Point(705, 42);
            this.btn_RenameCol.Name = "btn_RenameCol";
            this.btn_RenameCol.Size = new System.Drawing.Size(75, 22);
            this.btn_RenameCol.TabIndex = 9;
            this.btn_RenameCol.Text = "Rename Column";
            this.btn_RenameCol.UseVisualStyleBackColor = true;
            this.btn_RenameCol.Click += new System.EventHandler(this.btn_RenameCol_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Column Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Replace with";
            // 
            // cb_Columns
            // 
            this.cb_Columns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Columns.FormattingEnabled = true;
            this.cb_Columns.Location = new System.Drawing.Point(494, 15);
            this.cb_Columns.Name = "cb_Columns";
            this.cb_Columns.Size = new System.Drawing.Size(205, 21);
            this.cb_Columns.TabIndex = 7;
            // 
            // rtxt_GeneratedQuery
            // 
            this.rtxt_GeneratedQuery.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_GeneratedQuery.Location = new System.Drawing.Point(13, 341);
            this.rtxt_GeneratedQuery.Name = "rtxt_GeneratedQuery";
            this.rtxt_GeneratedQuery.Size = new System.Drawing.Size(767, 211);
            this.rtxt_GeneratedQuery.TabIndex = 13;
            this.rtxt_GeneratedQuery.Text = "";
            this.rtxt_GeneratedQuery.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Generated Query";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Table Name";
            // 
            // txt_TableName
            // 
            this.txt_TableName.Location = new System.Drawing.Point(451, 314);
            this.txt_TableName.Name = "txt_TableName";
            this.txt_TableName.Size = new System.Drawing.Size(205, 20);
            this.txt_TableName.TabIndex = 16;
            // 
            // btn_GenerateQuery
            // 
            this.btn_GenerateQuery.Location = new System.Drawing.Point(662, 313);
            this.btn_GenerateQuery.Name = "btn_GenerateQuery";
            this.btn_GenerateQuery.Size = new System.Drawing.Size(117, 22);
            this.btn_GenerateQuery.TabIndex = 17;
            this.btn_GenerateQuery.Text = "Generate Query";
            this.btn_GenerateQuery.UseVisualStyleBackColor = true;
            this.btn_GenerateQuery.Click += new System.EventHandler(this.btn_GenerateQuery_Click);
            // 
            // prb_Progress
            // 
            this.prb_Progress.Location = new System.Drawing.Point(13, 558);
            this.prb_Progress.Name = "prb_Progress";
            this.prb_Progress.Size = new System.Drawing.Size(766, 23);
            this.prb_Progress.TabIndex = 18;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ss_Status,
            this.ss_StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 588);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(791, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "Ready";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // ss_Status
            // 
            this.ss_Status.Name = "ss_Status";
            this.ss_Status.Size = new System.Drawing.Size(0, 17);
            // 
            // ss_StatusLabel
            // 
            this.ss_StatusLabel.Name = "ss_StatusLabel";
            this.ss_StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // txt_DatabaseName
            // 
            this.txt_DatabaseName.Location = new System.Drawing.Point(271, 314);
            this.txt_DatabaseName.Name = "txt_DatabaseName";
            this.txt_DatabaseName.Size = new System.Drawing.Size(103, 20);
            this.txt_DatabaseName.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Database Name";
            // 
            // btn_Hide
            // 
            this.btn_Hide.Location = new System.Drawing.Point(704, 14);
            this.btn_Hide.Name = "btn_Hide";
            this.btn_Hide.Size = new System.Drawing.Size(75, 22);
            this.btn_Hide.TabIndex = 22;
            this.btn_Hide.Text = "Hide";
            this.btn_Hide.UseVisualStyleBackColor = true;
            this.btn_Hide.Click += new System.EventHandler(this.btn_Hide_Click);
            // 
            // XML2Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 610);
            this.Controls.Add(this.btn_Hide);
            this.Controls.Add(this.txt_DatabaseName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.prb_Progress);
            this.Controls.Add(this.btn_GenerateQuery);
            this.Controls.Add(this.txt_TableName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtxt_GeneratedQuery);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_RenameCol);
            this.Controls.Add(this.txt_Replace);
            this.Controls.Add(this.cb_Columns);
            this.Controls.Add(this.txt_Parent);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_LoadDataTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_XMLLocation);
            this.Controls.Add(this.btnLoadXML);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "XML2Query";
            this.Text = "XML2Query";
            this.Load += new System.EventHandler(this.XML2Query_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000001 RID: 1
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000002 RID: 2
		private global::System.Windows.Forms.Button btnLoadXML;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.TextBox txt_XMLLocation;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Button btn_LoadDataTable;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.DataGridView dataGridView1;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.TextBox txt_Parent;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.TextBox txt_Replace;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.Button btn_RenameCol;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.ComboBox cb_Columns;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.RichTextBox rtxt_GeneratedQuery;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.TextBox txt_TableName;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Button btn_GenerateQuery;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.ProgressBar prb_Progress;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.StatusStrip statusStrip1;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.ToolStripStatusLabel ss_Status;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.ToolStripStatusLabel ss_StatusLabel;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.TextBox txt_DatabaseName;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.Button btn_Hide;
	}
}
