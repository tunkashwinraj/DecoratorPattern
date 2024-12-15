using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecoratorPattern_1262774
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDecoratorSimple_Click(object sender, EventArgs e)
        {
            IComponent cmp = new Component();
            // base system object - undecorated
            MessageBox.Show("Orig component:\n" + cmp.Welcome("Bill"));

            // after decoration by DecoratorTime
            DecoratorTime dect = new DecoratorTime(cmp);
            // decorates cmp with time info
            MessageBox.Show("Time decoration:\n" + dect.Welcome("Bill"));

            // base component after decoration by DecoratorBday only
            DecoratorBday decb = new DecoratorBday(cmp);
            MessageBox.Show("Bday decoration:\n" + decb.Welcome("Bill"));

            // after decoration by both time and bday
            DecoratorBday decTimeBday = new DecoratorBday(dect);
            MessageBox.Show("Time, Bday decoration:\n" + decTimeBday.Welcome("Bill"));
        }

        private void btnSubClassing_Click(object sender, EventArgs e)
        {
            // Create instances of the derived classes
            ComponentDerivedTime cdt = new ComponentDerivedTime();
            MessageBox.Show("Time decoration:\n" + cdt.Welcome());

            ComponentDerivedBday cdb = new ComponentDerivedBday();
            MessageBox.Show("Birthday decoration:\n" + cdb.Welcome());

            // Attempt to combine effects (not working as intended)
            MessageBox.Show("Combined decoration:\n" + cdt.Welcome() + cdb.Welcome());
        }

    }
}
