using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingWithDatabase
{
    public class Controller
    {
        public Model Model { get; set; }


        public Controller()
        {
            Model = new Model();

            Model.AddUser("ASK");

            Application.Run(new Form1(this));
            
        }

    }
}
