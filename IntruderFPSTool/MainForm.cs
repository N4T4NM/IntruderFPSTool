using IntruderFPSTool.UI;

namespace IntruderFPSTool
{
    public partial class MainForm : Form
    {
        public static MainForm Instance { get; private set; }
        public static NotifyIcon Notifier => Instance.roomNotifier;
        public MainForm()
        {
            InitializeComponent();
            Instance = this;

            SetControl(RoomsView.Instance);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            roomNotifier.Icon = Icon;
            roomNotifier.Visible = true;
        }

        public void SetControl(UserControl control)
        {
            control.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(control);
        }

        private void roomNotifier_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.Hide();
        }
    }
}