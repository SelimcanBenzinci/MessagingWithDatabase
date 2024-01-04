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

    }
}