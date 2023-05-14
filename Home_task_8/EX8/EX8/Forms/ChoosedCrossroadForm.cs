using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX8
{
    internal partial class ChoosedCrossroadForm : Form
    {
        private Crossroad _crossroad;
        private Stopwatch _stopwatch = new Stopwatch();
        private List<GroupBox> _groupBoxes = new List<GroupBox>();

        public ChoosedCrossroadForm(Crossroad crossroad)
        {
            InitializeComponent();
            _crossroad = crossroad;
        }

        private void backToSelectionButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChoosedCrossroadForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var forms = Application.OpenForms.Cast<Form>();
            foreach (var form in forms)
            {
                if (form is CrossroadSelectionForm)
                {
                    form.Visible = true;
                    break;
                }
            }
            intervalTimer.Stop();
            intervalTimer.Dispose();
            _stopwatch.Stop();
            generalTimer.Stop();
            generalTimer.Dispose();
        }

        private void ChoosedCrossroadForm_Load(object sender, EventArgs e)
        {
            int counter = 0;
            foreach (var light in _crossroad.Lights)
            {
                GroupBox groupBox = new GroupBox()
                {
                    Location = new Point(counter * 200, 0),
                    Text = light.Direction,
                    AutoSize = true
                };
                AddRadioButtonsToGroupBox(groupBox, light);
                Controls.Add(groupBox);
                _groupBoxes.Add(groupBox);
                counter++;
            }
        }

        private void AddRadioButtonsToGroupBox(GroupBox groupBox, AbstractTrafficLight light)
        {
            List<string> colors = new List<string>() { "Red", "Yellow", "Green" };
            int color = GetColor(light);

            for (int i = 0; i < colors.Count; i++)
            {
                RadioButton radioButton = new RadioButton()
                {
                    Location = new Point(10, 24 + i * 24),
                    Text = colors[i],
                    Enabled = false,
                    Checked = color == i
                };
                groupBox.Controls.Add(radioButton);
            }
            if (light is TwoDirectionalTrafficLight)
            {
                CheckBox checkBox = new CheckBox()
                {
                    Location = new Point(10, 24 + 3 * 24),
                    Text = (light as TwoDirectionalTrafficLight).SideDirection,
                    Enabled = false,
                    Checked = (light as TwoDirectionalTrafficLight).IsSideDirectionEnabled
                };
                groupBox.Controls.Add(checkBox);
            }
        }

        private int GetColor(AbstractTrafficLight light)
        {
            if (light.CurrentColor.Equals(Color.Red))
            {
                return 0;
            }
            else if (light.CurrentColor == Color.Yellow)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        private void intervalTimer_Tick(object sender, EventArgs e)
        {

            int color;
            for (int i = 0; i < _crossroad.Lights.Count; i++)
            {
                color = GetColor(_crossroad.Lights[i]);
                (_groupBoxes[i].Controls[color] as RadioButton).Checked = true;
                if (_crossroad.Lights[i] is TwoDirectionalTrafficLight)
                {
                    (_groupBoxes[i].Controls[_groupBoxes[i].Controls.Count - 1] as CheckBox).Checked
                        = (_crossroad.Lights[i] as TwoDirectionalTrafficLight).IsSideDirectionEnabled;
                }
            }

        }

        private void setTimerInterval_Click(object sender, EventArgs e)
        {
            try
            {
                intervalTimer.Interval = int.Parse(timerIntervalText.Text) * 1000;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(timerIntervalText, "Wrong input!");
            }
        }

        private void startTimerButton_Click(object sender, EventArgs e)
        {
            _stopwatch.Start();
            intervalTimer.Start();
            generalTimer.Start();
        }

        private void generalTimer_Tick(object sender, EventArgs e)
        {
            Controller.CheckState((int)(_stopwatch.ElapsedMilliseconds / 1000));
        }

        private void stopTimerButton_Click(object sender, EventArgs e)
        {
            intervalTimer.Stop();
            generalTimer.Stop();
            _stopwatch.Stop();
            _stopwatch.Reset();
        }
    }
}
