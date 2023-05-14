namespace EX8
{
    partial class CrossroadSelectionForm
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
            backToMainButton = new Button();
            crossroadNumber = new NumericUpDown();
            label1 = new Label();
            selectCrossroadButton = new Button();
            ((System.ComponentModel.ISupportInitialize)crossroadNumber).BeginInit();
            SuspendLayout();
            // 
            // backToMainButton
            // 
            backToMainButton.Location = new Point(290, 363);
            backToMainButton.Name = "backToMainButton";
            backToMainButton.Size = new Size(156, 42);
            backToMainButton.TabIndex = 0;
            backToMainButton.Text = "Back to main";
            backToMainButton.UseVisualStyleBackColor = true;
            backToMainButton.Click += backToMainButton_Click;
            // 
            // crossroadNumber
            // 
            crossroadNumber.Location = new Point(503, 73);
            crossroadNumber.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            crossroadNumber.Name = "crossroadNumber";
            crossroadNumber.Size = new Size(150, 27);
            crossroadNumber.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(379, 75);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 2;
            label1.Text = "# of crossroad";
            // 
            // selectCrossroadButton
            // 
            selectCrossroadButton.Location = new Point(503, 157);
            selectCrossroadButton.Name = "selectCrossroadButton";
            selectCrossroadButton.Size = new Size(132, 65);
            selectCrossroadButton.TabIndex = 3;
            selectCrossroadButton.Text = "Select crossroad";
            selectCrossroadButton.UseVisualStyleBackColor = true;
            selectCrossroadButton.Click += selectCrossroadButton_Click;
            // 
            // CrossroadSelectionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(selectCrossroadButton);
            Controls.Add(label1);
            Controls.Add(crossroadNumber);
            Controls.Add(backToMainButton);
            Name = "CrossroadSelectionForm";
            Text = "CrossroadSelectionForm";
            FormClosed += CrossroadSelectionForm_FormClosed;
            Load += CrossroadSelectionForm_Load;
            ((System.ComponentModel.ISupportInitialize)crossroadNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backToMainButton;
        private NumericUpDown crossroadNumber;
        private Label label1;
        private Button selectCrossroadButton;
    }
}