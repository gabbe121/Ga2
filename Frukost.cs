using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tastify_4
{
    public partial class Frukost : Form
    {
        public Frukost()
        {
            InitializeComponent();
        }
        private void Stäng_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lunch_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lunch lunch = new Lunch();
            lunch.ShowDialog();
            this.Close();
        }

        private void Middag_Click(object sender, EventArgs e)
        {
            this.Hide();
            Middag middag = new Middag();
            middag.ShowDialog();
            this.Close();
        }

        private void Kylskåp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kylskåp kylskåp = new Kylskåp();
            kylskåp.ShowDialog();
            this.Close();
        }

        private void Hem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
            this.Close();
        }
    }
}
