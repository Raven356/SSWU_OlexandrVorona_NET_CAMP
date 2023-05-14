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
    internal partial class TrafficLightsFillerForm : Form
    {
        Dictionary<string, string> antonyms = new Dictionary<string, string>() { {"north", "south" }, {"west", "east" }
            , {"south", "north" }, {"east", "west" } };
        Dictionary<string, string> antonymsForStrait = new Dictionary<string, string>() { {"north", "west"}, {"south", "east" },
            {"west", "north" }, {"east", "south" } };
        Crossroad _crossroad;
        public TrafficLightsFillerForm(Crossroad crossroad)
        {
            InitializeComponent();
            _crossroad = crossroad;
        }

        private void TrafficLightsFillerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var forms = Application.OpenForms.Cast<Form>();
            foreach (var form in forms)
            {
                if (form is CrossroadFillerForm)
                {
                    form.Visible = true;
                    break;
                }
            }
        }

        private void trafficLightBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hasSideSignalCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            isSignalEnabledCheckBox.Visible = !isSignalEnabledCheckBox.Visible;
            label2.Visible = !label2.Visible;
            sideDirectionTextBox.Visible = !sideDirectionTextBox.Visible;
        }

        private void addTrafficLightButton_Click(object sender, EventArgs e)
        {
            string[] directions = directionTextBox.Text.ToLower().Split("-", StringSplitOptions.RemoveEmptyEntries);

            if (directions.Length != 2)
            {
                errorProvider1.SetError(directionTextBox, "Direction is not in right format");
                return;
            }

            if (antonyms.Where(x => x.Key.Equals(directions[0])).Count() == 0 || antonyms.Where(x => x.Key.Equals(directions[1])).Count() == 0)
            {
                errorProvider1.SetError(directionTextBox, "Name of direction is not right!");
                return;
            }

            string oppositeDirection = directions[1] + "-" + directions[0];

            Color color;
            Color oppositeColor;

            if (redRadio.Checked)
            {
                color = Color.Red;
                oppositeColor = Color.Green;
            }
            else if (greenRadio.Checked)
            {
                color = Color.Green;
                oppositeColor = Color.Red;
            }
            else if (yellowRadio.Checked)
            {
                color = Color.Yellow;
                oppositeColor = color;
            }
            else
            {
                errorProvider1.SetError(groupBox1, "No color selected");
                return;
            }

            AbstractTrafficLight abstractTrafficLight;
            AbstractTrafficLight opposite;

            foreach (AbstractTrafficLight trafficLight in _crossroad.Lights)
            {

                bool equathion;
                if ((directions[0].Equals("north") && directions[1].Equals("south"))
                    || (directions[0].Equals("west") && directions[1].Equals("east")))
                {
                    equathion = trafficLight.Direction.Equals(antonymsForStrait[directions[0]] + "-"
                    + antonymsForStrait[directions[1]]);
                }
                else
                {
                    equathion = trafficLight.Direction.Equals(antonyms[directions[0]] + "-"
                    + antonyms[directions[1]]);
                }

                if (equathion)
                {
                    if (!trafficLight.CurrentColor.Equals(oppositeColor))
                    {
                        errorProvider1.SetError(groupBox1, "Color on parallel road shouldn't be equal!");
                        return;
                    }
                    break;
                }

                if (trafficLight.Direction.Equals(directions[0] + "-" + directions[1]))
                {
                    if (!trafficLight.CurrentColor.Equals(color))
                    {
                        errorProvider1.SetError(groupBox1, $"Color on the same directions should be the same! Requiered: {trafficLight.CurrentColor}");
                        return;
                    }
                    break;
                }
            }

            if (hasSideSignalCheckBox.Checked)
            {
                if (sideDirectionTextBox.Text.Equals(directionTextBox.Text))
                {
                    errorProvider1.SetError(sideDirectionTextBox, "Side direction could't be equal to main");
                    return;
                }
                string first = directions[0];
                
                directions = sideDirectionTextBox.Text.Split("-");
                if (!first.Equals(directions[0]))
                {
                    errorProvider1.SetError(sideDirectionTextBox, "Side direction could't go from other light");
                    return;
                }
                abstractTrafficLight = new TwoDirectionalTrafficLight(directionTextBox.Text
                    , sideDirectionTextBox.Text, color, isSignalEnabledCheckBox.Checked);
                opposite = new TwoDirectionalTrafficLight(oppositeDirection, directions[1] + "-" + directions[0]
                    , color, isSignalEnabledCheckBox.Checked);
            }
            else
            {
                abstractTrafficLight = new OneDirectionalTrafficLight(directionTextBox.Text, color);
                opposite = new OneDirectionalTrafficLight(oppositeDirection, color);
            }

            _crossroad.AddTrafficLight(abstractTrafficLight);
            _crossroad.AddTrafficLight(opposite);

            directionTextBox.Clear();
            redRadio.Checked = false;
            yellowRadio.Checked = false;
            greenRadio.Checked = false;
            sideDirectionTextBox.Clear();
            hasSideSignalCheckBox.Checked = false;
            isSignalEnabledCheckBox.Checked = false;
            errorProvider1.Clear();
        }
    }
}
