namespace EX8
{
    partial class CrossroadFillerForm
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
            crossroadBackButton = new Button();
            addTraficLightsButton = new Button();
            redText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            yellowText = new TextBox();
            label4 = new Label();
            greenText = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // crossroadBackButton
            // 
            crossroadBackButton.Location = new Point(245, 325);
            crossroadBackButton.Name = "crossroadBackButton";
            crossroadBackButton.Size = new Size(230, 52);
            crossroadBackButton.TabIndex = 0;
            crossroadBackButton.Text = "Back to main form";
            crossroadBackButton.UseVisualStyleBackColor = true;
            crossroadBackButton.Click += crossroadBackButton_Click;
            // 
            // addTraficLightsButton
            // 
            addTraficLightsButton.Location = new Point(66, 260);
            addTraficLightsButton.Name = "addTraficLightsButton";
            addTraficLightsButton.Size = new Size(150, 58);
            addTraficLightsButton.TabIndex = 1;
            addTraficLightsButton.Text = "Add traffic lights";
            addTraficLightsButton.UseVisualStyleBackColor = true;
            addTraficLightsButton.Click += addTraficLightsButton_Click;
            // 
            // redText
            // 
            redText.Location = new Point(89, 78);
            redText.Name = "redText";
            redText.Size = new Size(125, 27);
            redText.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 81);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 3;
            label1.Text = "Red";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 35);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 4;
            label2.Text = "Enter time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 130);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 6;
            label3.Text = "Yellow";
            // 
            // yellowText
            // 
            yellowText.Location = new Point(89, 127);
            yellowText.Name = "yellowText";
            yellowText.Size = new Size(125, 27);
            yellowText.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 176);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 8;
            label4.Text = "Green";
            // 
            // greenText
            // 
            greenText.Location = new Point(89, 173);
            greenText.Name = "greenText";
            greenText.Size = new Size(125, 27);
            greenText.TabIndex = 7;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(redText);
            groupBox1.Controls.Add(greenText);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(yellowText);
            groupBox1.Location = new Point(25, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(274, 233);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // CrossroadFillerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(addTraficLightsButton);
            Controls.Add(crossroadBackButton);
            Name = "CrossroadFillerForm";
            Text = "CrossroadFillerForm";
            FormClosed += CrossroadFillerForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button crossroadBackButton;
        private Button addTraficLightsButton;
        private TextBox redText;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox yellowText;
        private Label label4;
        private TextBox greenText;
        private ErrorProvider errorProvider1;
        private GroupBox groupBox1;
    }
}