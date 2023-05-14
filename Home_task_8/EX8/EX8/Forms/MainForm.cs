namespace EX8
{
    enum Color
    {
        Red,
        Yellow,
        Green
    }
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void crossroadFillerButton_Click(object sender, EventArgs e)
        {
            CrossroadFillerForm crossroadFillerForm = new CrossroadFillerForm();
            crossroadFillerForm.Show();
            this.Visible = false;
        }

        private void showCrossroadsButton_Click(object sender, EventArgs e)
        {
            if(Controller.Crossroads.Count > 0)
            {
                CrossroadSelectionForm crossroadSelectionForm = new CrossroadSelectionForm();
                crossroadSelectionForm.Show();
                this.Visible = false;
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(showCrossroadsButton, "No crossroads to be seen!");
            }
        }
    }
}