using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Json_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            var deser = Logic.LineDeserialize(Logic.GetFilePath());
            DataGridView dataGridView= new DataGridView();
           
            foreach (var tempdeser in deser)
            {
                //DataGridViewRow row = new DataGridViewRow();
                bindingSource1.Add(tempdeser.result);
               
            }
            
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.AutoGenerateColumns = true;

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
