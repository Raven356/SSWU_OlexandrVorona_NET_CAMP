using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX8
{
    public partial class CrossroadSelectionForm : Form
    {
        public CrossroadSelectionForm()
        {
            InitializeComponent();
        }

        private void CrossroadSelectionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form mainForm = Application.OpenForms.Cast<Form>().First();
            mainForm.Visible = true;
        }

        private void backToMainButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CrossroadSelectionForm_Load(object sender, EventArgs e)
        {
            crossroadNumber.Maximum = Controller.Crossroads.Count - 1;
        }

        private void selectCrossroadButton_Click(object sender, EventArgs e)
        {
            ChoosedCrossroadForm choosedCrossroadForm = new ChoosedCrossroadForm(Controller.Crossroads[(int)crossroadNumber.Value]);
            choosedCrossroadForm.Show();
            this.Visible = false;
        }
    }
}
