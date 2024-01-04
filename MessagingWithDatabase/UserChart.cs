using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessagingWithDatabase
{
    public partial class UserChart : UserControl
    {

        public Controller controller { get; set; }

        public UserChart()
        {
            InitializeComponent();
        }

        public UserChart(Controller cntrl)
        {
            InitializeComponent();
            controller = cntrl;

        }

        public void ConfigureChart(string text)
        {
            label1.Text = text;
        }

    }
}
