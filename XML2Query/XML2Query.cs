using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace XML2Query
{ 
	public partial class XML2Query : Form
	{ 
		public XML2Query()
		{
			this.InitializeComponent();
		}
		 
		private IEnumerable<string> GetParentNodes(XmlNode node)
		{
			for (;;)
			{
				node = node.ParentNode;
				if (node == null || node.NodeType == XmlNodeType.Document)
				{
					break;
				}
				yield return node.Name;
			}
			yield break;
		} 
		private void btnLoadXML_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Decompiled XML|*.xml";
			openFileDialog.Title = "Select Decompiled XML";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.txt_Parent.Text = "";
				string text = openFileDialog.InitialDirectory + openFileDialog.FileName;
				this.txt_XMLLocation.Text = text.Replace("\\", "\\\\");
				XmlDocument xmlDocument = new XmlDocument();
				try
				{
					xmlDocument.Load(text); 
					XmlNodeList elementsByTagName = xmlDocument.DocumentElement.GetElementsByTagName("Item");
					int num = 0;
					if (num < elementsByTagName.Count)
					{
						XmlNode node = elementsByTagName[num];
						foreach (string text2 in this.GetParentNodes(node))
						{
							this.txt_Parent.Text = text2.ToString() + "/" + this.txt_Parent.Text;
						}
					}
					TextBox textBox = this.txt_Parent;
					textBox.Text += "*";
				}
				catch (Exception arg)
				{
					MessageBox.Show("Cannot load XML File! It's either corrupted or encrypted! \n Error: " + arg);
				}
			}
		}  
		private void btn_LoadDataTable_Click(object sender, EventArgs e)
		{
			if (this.txt_XMLLocation.Text.Length != 0 && this.txt_Parent.Text.Length != 0)
			{
				this.dataGridView1.Columns.Clear();
				this.cb_Columns.Items.Clear();
				List<string> list = new List<string>();
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.Load(this.txt_XMLLocation.Text.ToString());
				XmlNode xmlNode = xmlDocument.SelectSingleNode(this.txt_Parent.Text);
				XmlNodeList xmlNodeList = xmlDocument.SelectNodes(this.txt_Parent.Text);
				ComboboxItem comboboxItem = new ComboboxItem();
				try
				{
					foreach (object obj in xmlNode.Attributes)
					{
						XmlNode xmlNode2 = (XmlNode)obj;
						list.Add(xmlNode2.Name.ToString());
						comboboxItem.Text = xmlNode2.Name.ToString();
						this.cb_Columns.Items.Add(comboboxItem);
						this.cb_Columns.SelectedIndex = 0;
						this.dataGridView1.Columns.Add(xmlNode2.Name.ToString(), xmlNode2.Name.ToString());
					}
				}
				catch (Exception arg)
				{
					MessageBox.Show("Invalid Parent! \n Exception: " + arg);
				}
				for (int i = 0; i < xmlNodeList.Count; i++)
				{
					DataGridViewRow dataGridViewRow = new DataGridViewRow();
					dataGridViewRow.CreateCells(this.dataGridView1);
					for (int j = 0; j < list.Count; j++)
					{
						try
						{
							dataGridViewRow.Cells[j].Value = xmlNodeList[i].Attributes[list[j]].Value;
						}
						catch (Exception)
						{
						}
					}
					this.dataGridView1.Rows.Add(dataGridViewRow);
				}
				return;
			}
			MessageBox.Show("Please load Valid XML File");
		}
		 
		private void XML2Query_Load(object sender, EventArgs e)
		{
		}
		 
		private void label1_Click(object sender, EventArgs e)
		{
		}
		 
		private void btn_RenameCol_Click(object sender, EventArgs e)
		{
			if (this.cb_Columns.SelectedItem != null && this.txt_Replace.Text.Length != 0)
			{
				this.dataGridView1.Columns[this.cb_Columns.SelectedIndex].HeaderCell.Value = this.txt_Replace.Text;
				this.cb_Columns.Items[this.cb_Columns.SelectedIndex] = this.txt_Replace.Text;
				return;
			}
			MessageBox.Show("No selected column or No replace text");
		}
		 
		private void btn_GenerateQuery_Click(object sender, EventArgs e)
		{
			if (this.txt_TableName.Text.Length != 0 && this.dataGridView1.Rows.Count > 0)
			{
				this.prb_Progress.Maximum = this.dataGridView1.Rows.Count - 1;
				int num = 0;
				string text = "";
				this.rtxt_GeneratedQuery.Text = "";
				for (int i = 0; i < this.cb_Columns.Items.Count; i++)
				{
					this.cb_Columns.SelectedIndex = i;
					text = text + "[" + this.cb_Columns.Text + "], ";
				}
				if (text.Substring(text.Length - 2).ToString() == ", ")
				{
					text = text.Remove(text.Length - 2);
				}
				this.cb_Columns.SelectedIndex = 0;
				foreach (object obj in ((IEnumerable)this.dataGridView1.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					string text2 = "";
					for (int j = 0; j < this.cb_Columns.Items.Count; j++)
					{
						int num2;
						if (int.TryParse(dataGridViewRow.Cells[j].Value.ToString(), out num2))
						{
							object obj2 = text2;
							text2 = string.Concat(new object[]
							{
								obj2,
								"'",
								dataGridViewRow.Cells[j].Value,
								"', "
							});
						}
						else
						{
							dataGridViewRow.Cells[j].Value = dataGridViewRow.Cells[j].Value.ToString().Replace("'", "''");
							if (dataGridViewRow.Cells[j].Value.ToString().Length == 0)
							{
								object obj3 = text2;
								text2 = string.Concat(new object[]
								{
									obj3,
									"'",
									dataGridViewRow.Cells[j].Value,
									"', "
								});
							}
							else
							{
								object obj4 = text2;
								text2 = string.Concat(new object[]
								{
									obj4,
									"N'",
									dataGridViewRow.Cells[j].Value,
									"', "
								});
							}
						}
					}
					if (text2.Substring(text2.Length - 2).ToString() == ", ")
					{
						text2 = text2.Remove(text2.Length - 2);
					}
					if (this.txt_DatabaseName.Text.ToString().Length == 0)
					{
						this.rtxt_GeneratedQuery.AppendText(string.Concat(new string[]
						{
							"INSERT INTO ",
							this.txt_TableName.Text,
							" (",
							text,
							") VALUES (",
							text2,
							"); \n"
						}));
					}
					else
					{
						this.rtxt_GeneratedQuery.AppendText(string.Concat(new string[]
						{
							"INSERT INTO ",
							this.txt_DatabaseName.Text,
							".dbo.",
							this.txt_TableName.Text,
							" (",
							text,
							") VALUES (",
							text2,
							"); \n"
						}));
					}
					this.prb_Progress.Value = num;
					if (this.prb_Progress.Maximum > this.prb_Progress.Value)
					{
						num++;
					}
					this.ss_StatusLabel.Text = string.Concat(new object[]
					{
						num,
						" / ",
						this.prb_Progress.Maximum,
						" Items"
					});
					this.statusStrip1.Refresh();
					Thread.Sleep(100);
				}
				if (this.prb_Progress.Maximum == this.prb_Progress.Value)
				{
					MessageBox.Show("Done!");
					return;
				}
			}
			else
			{
				MessageBox.Show("Table name might be null or There's no loaded data");
			}
		}
		 
		private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
		}
		 
		private void btn_Hide_Click(object sender, EventArgs e)
		{
			if (this.cb_Columns.SelectedItem != null)
			{
				this.dataGridView1.Columns.RemoveAt(this.cb_Columns.SelectedIndex);
				this.cb_Columns.Items.RemoveAt(this.cb_Columns.SelectedIndex);
				MessageBox.Show("Removed");
				return;
			}
			MessageBox.Show("No selected column");
		} 
	}
}
