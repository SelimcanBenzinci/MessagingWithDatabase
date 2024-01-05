namespace MessagingWithDatabase
{
    public partial class Form1 : Form
    {
        public Controller controller { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Controller cntrl)
        {
            InitializeComponent();
            controller = cntrl;

            Login login = new Login(controller);
            controller.mainForm = this;

            panel1.Controls.Add(login);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            AccountSetting accountSetting = new AccountSetting(controller);

            panel1.Controls.Add(accountSetting);
        }
    }
}