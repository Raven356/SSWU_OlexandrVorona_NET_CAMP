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
    public partial class CrossroadFillerForm : Form
    {
        public CrossroadFillerForm()
        {
            InitializeComponent();
        }

        private void CrossroadFillerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Controller.Crossroads.Last().Lights.Count == 0) { 
                List<Crossroad> crossroads = Controller.Crossroads;
                crossroads.RemoveAt(crossroads.IndexOf(crossroads.Last()));
                Controller.Crossroads = crossroads;
            }
            Form mainForm = Application.OpenForms.Cast<Form>().First();
            mainForm.Visible = true;
        }

        private void crossroadBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addTraficLightsButton_Click(object sender, EventArgs e)
        {
            try
            {
                uint red = uint.Parse(redText.Text);
                uint green = uint.Parse(greenText.Text);
                if(green != red)
                {
                    throw new ArgumentException("Red and green time should be equal!");
                }
                Controller.AddCrossroad(new Crossroad(new uint[] {red, uint.Parse(yellowText.Text)
                , green}));
                TrafficLightsFillerForm trafficLightsFillerForm = new TrafficLightsFillerForm(Controller.Crossroads.Last());
                trafficLightsFillerForm.Show();
                this.Visible = false;
                redText.Clear();
                yellowText.Clear();
                greenText.Clear();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(groupBox1, ex.Message);
            }
        }
    }
}
