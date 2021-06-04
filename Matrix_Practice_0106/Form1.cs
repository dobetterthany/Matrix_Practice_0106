using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix_Practice_0106
{
    public partial class Form1 : Form
    {
        public int R, C,a,b,c;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbColumn1.Text) == Convert.ToInt32(tbRow2.Text))
            {
                //Matrix creation
                dataGridView3.RowCount = Convert.ToInt32(tbRow1.Text);
                dataGridView3.ColumnCount = Convert.ToInt32(tbColumn2.Text);
                dataGridView3.AutoResizeColumns();
                dataGridView3.AutoResizeRows();

                //Matrix Calculation
                try
                {
                    foreach (DataGridViewRow row in this.dataGridView1.Rows)
                    {
                        int R1 = row.Index;
                        {
                            for (b = 0; b < dataGridView2.ColumnCount; b++)
                            {
                                a = 0;
                                for (c = 0; c < dataGridView2.RowCount; c++)
                                {
                                    decimal D = Convert.ToDecimal(dataGridView1.Rows[R1].Cells[c].Value.ToString());
                                    decimal E = Convert.ToDecimal(dataGridView2.Rows[c].Cells[b].Value.ToString());

                                    decimal A = D * E;
                                    dataGridView3.Rows[R1].Cells[b].Value = decimal.Parse(A.ToString());
                                    dataGridView3.Rows[R1].Cells[b].Value = a + Convert.ToDouble(dataGridView3.Rows[R1].Cells[b].Value);
                                    a = Convert.ToInt32(dataGridView3.Rows[R1].Cells[b].Value);

                                }
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong");
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Create rows
            if (tbRow1.Text != "" & tbColumn1.Text != "")
            {
                dataGridView1.RowCount = (Convert.ToInt32(tbRow1.Text));
                R = dataGridView1.RowCount;
                dataGridView1.AllowUserToResizeColumns = true;
                dataGridView1.AutoResizeRows();

                dataGridView1.ColumnCount = (Convert.ToInt32(tbColumn1.Text));
                C = dataGridView1.ColumnCount;
                dataGridView1.AutoResizeColumns();
            }
            else
            {
                MessageBox.Show("Please fill in the blank");
            }

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

            
        }

        private void btnCreate2_Click(object sender, EventArgs e)
        {
            if (tbRow1.Text != "" & tbColumn1.Text != "")
            {
                dataGridView2.RowCount = (Convert.ToInt32(tbRow2.Text));
                R = dataGridView2.RowCount;
                dataGridView2.AllowUserToResizeColumns = true;
                dataGridView2.AutoResizeRows();

                dataGridView2.ColumnCount = (Convert.ToInt32(tbColumn2.Text));
                C = dataGridView2.ColumnCount;
                dataGridView2.AutoResizeColumns();
            }
            else
            {
                MessageBox.Show("Please fill in the blank");
            }

        }
    }
}
