namespace EX8
{
    partial class TrafficLightsFillerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            trafficLightBackButton = new Button();
            hasSideSignalCheckBox = new CheckBox();
            isSignalEnabledCheckBox = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            directionTextBox = new TextBox();
            sideDirectionTextBox = new TextBox();
            addTrafficLightButton = new Button();
            groupBox1 = new GroupBox();
            greenRadio = new RadioButton();
            yellowRadio = new RadioButton();
            redRadio = new RadioButton();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // trafficLightBackButton
            // 
            trafficLightBackButton.Location = new Point(299, 334);
            trafficLightBackButton.Name = "trafficLightBackButton";
            trafficLightBackButton.Size = new Size(206, 55);
            trafficLightBackButton.TabIndex = 0;
            trafficLightBackButton.Text = "Back to crossroad form";
            trafficLightBackButton.UseVisualStyleBackColor = true;
            trafficLightBackButton.Click += trafficLightBackButton_Click;
            // 
            // hasSideSignalCheckBox
            // 
            hasSideSignalCheckBox.AutoSize = true;
            hasSideSignalCheckBox.Location = new Point(589, 71);
            hasSideSignalCheckBox.Name = "hasSideSignalCheckBox";
            hasSideSignalCheckBox.Size = new Size(130, 24);
            hasSideSignalCheckBox.TabIndex = 1;
            hasSideSignalCheckBox.Text = "Has side signal";
            hasSideSignalCheckBox.UseVisualStyleBackColor = true;
            hasSideSignalCheckBox.CheckedChanged += hasSideSignalCheckBox_CheckedChanged;
            // 
            // isSignalEnabledCheckBox
            // 
            isSignalEnabledCheckBox.AutoSize = true;
            isSignalEnabledCheckBox.Location = new Point(589, 101);
            isSignalEnabledCheckBox.Name = "isSignalEnabledCheckBox";
            isSignalEnabledCheckBox.Size = new Size(126, 24);
            isSignalEnabledCheckBox.TabIndex = 2;
            isSignalEnabledCheckBox.Text = "SignalEnabled";
            isSignalEnabledCheckBox.UseVisualStyleBackColor = true;
            isSignalEnabledCheckBox.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 72);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 3;
            label1.Text = "Direction";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 72);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 4;
            label2.Text = "Side direction";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 158);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 5;
            label3.Text = "Color";
            // 
            // directionTextBox
            // 
            directionTextBox.Location = new Point(148, 69);
            directionTextBox.Name = "directionTextBox";
            directionTextBox.Size = new Size(125, 27);
            directionTextBox.TabIndex = 6;
            // 
            // sideDirectionTextBox
            // 
            sideDirectionTextBox.Location = new Point(406, 68);
            sideDirectionTextBox.Name = "sideDirectionTextBox";
            sideDirectionTextBox.Size = new Size(125, 27);
            sideDirectionTextBox.TabIndex = 8;
            sideDirectionTextBox.Visible = false;
            // 
            // addTrafficLightButton
            // 
            addTrafficLightButton.Location = new Point(299, 235);
            addTrafficLightButton.Name = "addTrafficLightButton";
            addTrafficLightButton.Size = new Size(206, 71);
            addTrafficLightButton.TabIndex = 9;
            addTrafficLightButton.Text = "Add traffic light";
            addTrafficLightButton.UseVisualStyleBackColor = true;
            addTrafficLightButton.Click += addTrafficLightButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(greenRadio);
            groupBox1.Controls.Add(yellowRadio);
            groupBox1.Controls.Add(redRadio);
            groupBox1.Location = new Point(120, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(153, 125);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // greenRadio
            // 
            greenRadio.AutoSize = true;
            greenRadio.Location = new Point(6, 81);
            greenRadio.Name = "greenRadio";
            greenRadio.Size = new Size(69, 24);
            greenRadio.TabIndex = 2;
            greenRadio.TabStop = true;
            greenRadio.Text = "Green";
            greenRadio.UseVisualStyleBackColor = true;
            // 
            // yellowRadio
            // 
            yellowRadio.AutoSize = true;
            yellowRadio.Location = new Point(6, 51);
            yellowRadio.Name = "yellowRadio";
            yellowRadio.Size = new Size(73, 24);
            yellowRadio.TabIndex = 1;
            yellowRadio.TabStop = true;
            yellowRadio.Text = "Yellow";
            yellowRadio.UseVisualStyleBackColor = true;
            // 
            // redRadio
            // 
            redRadio.AutoSize = true;
            redRadio.Location = new Point(6, 26);
            redRadio.Name = "redRadio";
            redRadio.Size = new Size(56, 24);
            redRadio.TabIndex = 0;
            redRadio.TabStop = true;
            redRadio.Text = "Red";
            redRadio.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // TrafficLightsFillerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(addTrafficLightButton);
            Controls.Add(sideDirectionTextBox);
            Controls.Add(directionTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(isSignalEnabledCheckBox);
            Controls.Add(hasSideSignalCheckBox);
            Controls.Add(trafficLightBackButton);
            Name = "TrafficLightsFillerForm";
            Text = "TrafficLightsFillerForm";
            FormClosed += TrafficLightsFillerForm_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button trafficLightBackButton;
        private CheckBox hasSideSignalCheckBox;
        private CheckBox isSignalEnabledCheckBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox directionTextBox;
        private TextBox sideDirectionTextBox;
        private Button addTrafficLightButton;
        private GroupBox groupBox1;
        private RadioButton greenRadio;
        private RadioButton yellowRadio;
        private RadioButton redRadio;
        private ErrorProvider errorProvider1;
    }
}