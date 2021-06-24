using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMonser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            int  DealerShip1V, DealerShip2V , DealerShip3V, DealerShip4V, DealerShip5V, TotalCars;
           DealerShip1V= int.Parse(DealerShip1.Text);
           DealerShip2V= int.Parse(DealerShip2.Text);
           DealerShip3V= int.Parse(DealerShip3.Text);
           DealerShip4V= int.Parse(DealerShip4.Text);
           DealerShip5V= int.Parse(DealerShip5.Text);
         

         TotalCars = DealerShip1V + DealerShip2V + DealerShip3V + DealerShip4V + DealerShip5V;
            label7.Text = "The total cars are " + TotalCars;
         }
    }
}
