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

namespace TestCaseConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenSourceBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (!String.IsNullOrWhiteSpace(openFileDialog.FileName))
                {
                    SourceTb.Text = openFileDialog.FileName;
                }
            }
        }

        private void OpenDestBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (!String.IsNullOrWhiteSpace(saveFileDialog.FileName))
                {
                    DestTb.Text = saveFileDialog.FileName;
                }
            }
        }

        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (FileStream inStream = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    using (FileStream outStream = new FileStream(saveFileDialog.FileName, FileMode.CreateNew))
                    {
                        List<PosRobotTestCase> tcList = PosRobotTestCase.fromPosRobotFile(inStream);
                        Functions.WriteAsIntellibot(outStream, tcList, Functions.WriteEncoding.UTF8);
                        MessageBox.Show(null, String.Format("Se han convertido {0} casos", tcList.Count), "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, String.Format("Ha ocurrido un error:\n\n{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
