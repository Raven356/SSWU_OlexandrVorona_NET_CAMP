namespace EX8
{
    partial class ChoosedCrossroadForm
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
            backToSelectionButton = new Button();
            intervalTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            timerIntervalText = new TextBox();
            setTimerInterval = new Button();
            errorProvider1 = new ErrorProvider(components);
            startTimerButton = new Button();
            generalTimer = new System.Windows.Forms.Timer(components);
            stopTimerButton = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // backToSelectionButton
            // 
            backToSelectionButton.Location = new Point(314, 332);
            backToSelectionButton.Name = "backToSelectionButton";
            backToSelectionButton.Size = new Size(148, 71);
            backToSelectionButton.TabIndex = 0;
            backToSelectionButton.Text = "Back to selection";
            backToSelectionButton.UseVisualStyleBackColor = true;
            backToSelectionButton.Click += backToSelectionButton_Click;
            // 
            // intervalTimer
            // 
            intervalTimer.Tick += intervalTimer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 248);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 1;
            label1.Text = "Set timer interval(s)";
            // 
            // timerIntervalText
            // 
            timerIntervalText.Location = new Point(173, 245);
            timerIntervalText.Name = "timerIntervalText";
            timerIntervalText.Size = new Size(125, 27);
            timerIntervalText.TabIndex = 2;
            // 
            // setTimerInterval
            // 
            setTimerInterval.Location = new Point(67, 303);
            setTimerInterval.Name = "setTimerInterval";
            setTimerInterval.Size = new Size(142, 52);
            setTimerInterval.TabIndex = 3;
            setTimerInterval.Text = "Set interval";
            setTimerInterval.UseVisualStyleBackColor = true;
            setTimerInterval.Click += setTimerInterval_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // startTimerButton
            // 
            startTimerButton.Location = new Point(555, 222);
            startTimerButton.Name = "startTimerButton";
            startTimerButton.Size = new Size(188, 73);
            startTimerButton.TabIndex = 4;
            startTimerButton.Text = "Start timer";
            startTimerButton.UseVisualStyleBackColor = true;
            startTimerButton.Click += startTimerButton_Click;
            // 
            // generalTimer
            // 
            generalTimer.Interval = 1000;
            generalTimer.Tick += generalTimer_Tick;
            // 
            // stopTimerButton
            // 
            stopTimerButton.Location = new Point(555, 332);
            stopTimerButton.Name = "stopTimerButton";
            stopTimerButton.Size = new Size(188, 71);
            stopTimerButton.TabIndex = 5;
            stopTimerButton.Text = "Stop timer";
            stopTimerButton.UseVisualStyleBackColor = true;
            stopTimerButton.Click += stopTimerButton_Click;
            // 
            // ChoosedCrossroadForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(stopTimerButton);
            Controls.Add(startTimerButton);
            Controls.Add(setTimerInterval);
            Controls.Add(timerIntervalText);
            Controls.Add(label1);
            Controls.Add(backToSelectionButton);
            Name = "ChoosedCrossroadForm";
            Text = "ChoosedCrossroadForm";
            FormClosed += ChoosedCrossroadForm_FormClosed;
            Load += ChoosedCrossroadForm_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backToSelectionButton;
        private System.Windows.Forms.Timer intervalTimer;
        private Label label1;
        private TextBox timerIntervalText;
        private Button setTimerInterval;
        private ErrorProvider errorProvider1;
        private Button startTimerButton;
        private System.Windows.Forms.Timer generalTimer;
        private Button stopTimerButton;
    }
}