using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectMardaleBiancaElena
{
    public partial class Form2 : Form
    {
        Utilizator u;
        public Form2(Utilizator u)
        {
            InitializeComponent();
            this.u = u;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void tbID_Validating(object sender, CancelEventArgs e)
        {
            int a = Int32.Parse(tbID.Text);
            if (a < 1000)
            {
                errP1.SetError(tbID, "Valoare invalida. Id-ul utilizatorului trebuie sa fie >= 1000");
                e.Cancel = true;
            }
            else
            {
                errP1.SetError(tbID, null);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
