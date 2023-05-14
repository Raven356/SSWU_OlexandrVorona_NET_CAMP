namespace EX8
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            crossroadFillerButton = new Button();
            showCrossroadsButton = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // crossroadFillerButton
            // 
            crossroadFillerButton.Location = new Point(50, 158);
            crossroadFillerButton.Name = "crossroadFillerButton";
            crossroadFillerButton.Size = new Size(152, 29);
            crossroadFillerButton.TabIndex = 0;
            crossroadFillerButton.Text = "Add crossroads";
            crossroadFillerButton.UseVisualStyleBackColor = true;
            crossroadFillerButton.Click += crossroadFillerButton_Click;
            // 
            // showCrossroadsButton
            // 
            showCrossroadsButton.Location = new Point(448, 158);
            showCrossroadsButton.Name = "showCrossroadsButton";
            showCrossroadsButton.Size = new Size(252, 29);
            showCrossroadsButton.TabIndex = 1;
            showCrossroadsButton.Text = "See crossroads";
            showCrossroadsButton.UseVisualStyleBackColor = true;
            showCrossroadsButton.Click += showCrossroadsButton_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(showCrossroadsButton);
            Controls.Add(crossroadFillerButton);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.CodeDom.CodeTypeReference timer1;
        private Button crossroadFillerButton;
        private Button showCrossroadsButton;
        private ErrorProvider errorProvider1;
    }
}