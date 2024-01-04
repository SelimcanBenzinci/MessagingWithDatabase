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
    public partial class MessageChart : UserControl
    {
        public Controller controller { get; set; }

        public MessageChart()
        {
            InitializeComponent();
        }

        public MessageChart(Controller cntrl, Message item)
        {
            InitializeComponent();
            controller = cntrl;

            label1.Text = item.MessageText;
        }

    }
}
