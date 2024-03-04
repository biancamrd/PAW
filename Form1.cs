using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectMardaleBiancaElena
{
    public partial class Form1 : Form
    {
        Utilizator u;
        List<Utilizator> listaU;
        Grup grup;
        List<string> listaDrepturi;
        List<Grup> listaGrupuri;

        public Form1()
        {
            InitializeComponent();
            u = new Utilizator();
            listaU = new List<Utilizator>();
            grup = new Grup();
            listaDrepturi = new List<string>();
            listaGrupuri = new List<Grup>();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string[] items = { "Owner", "Full Control", "Read-Write", "Read", "Write", "Create", "Delete" };
            tbDrepturi.Items.AddRange(items);
        }
        private string creazaAfisareLB(Grup g)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(g.IdGrup);
            sb.Append(g.ListaUtilizatori);
            sb.Append(g.ListaDrepturi);
            return sb.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fd = new Form2(u);
            //Form3 ft = new Form3(listaU);

            if (fd.ShowDialog() == DialogResult.OK)
            {
                // int idGrup = Int32.Parse(tbIdGrup.Text);
                int id = Int32.Parse(fd.tbID.Text);
                string nume = fd.tbNume.Text;
                string numeUtilizator = fd.tbNumeU.Text;
                string parola = fd.tbParola.Text;
                u = new Utilizator(id, nume, numeUtilizator, parola);
                listaU.Add(u);
                grup.ListaUtilizatori = listaU;


                ListViewItem listViewItem = new ListViewItem(id.ToString());
                listViewItem.SubItems.Add(nume);
                listViewItem.SubItems.Add(numeUtilizator);
                lvU.Items.Add(listViewItem);

                //ListViewItem listViewItem2 = new ListViewItem(id.ToString());
                //listViewItem2.SubItems.Add(nume);
                //listViewItem2.SubItems.Add(numeUtilizator);
                //ft.lvModifica.Items.Add(listViewItem2);


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string mesajAfisare = "";
            foreach (Grup g in listaGrupuri)
            {
                mesajAfisare += g.ToString() + Environment.NewLine;
            }
            textBox1.Text = mesajAfisare;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var grup1 = grup;
            listaGrupuri.Add(grup1);
            tbIdGrup.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grup = new Grup();
            listaDrepturi = new List<string>();
            listaU = new List<Utilizator>();
            nrDreputri = 0;
            label4.Text = "Drepturi adaugate pana acum: " + nrDreputri;
            grup.IdGrup = Int32.Parse(tbIdGrup.Text);

        }



        int nrDreputri = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            string drept = tbDrepturi.Text;
            listaDrepturi.Add(drept);
            nrDreputri++;
            label4.Text = "Drepturi adaugate pana acum: " + nrDreputri;
            grup.ListaDrepturi = listaDrepturi;
        }



        private void bexit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programul se va inchide!");
            Application.Exit();
        }

        private void salvareTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                foreach (Grup g in listaGrupuri)
                {
                    sw.WriteLine(g.ToString());
                }
                sw.Close();
            }
        }


        private void deschidereTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                textBox1.Clear();
                textBox1.Text += sr.ReadToEnd();
                sr.Close();
            }
        }

        private void salvareBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Grupuri.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, listaGrupuri);
            fs.Close();
            textBox1.Clear();
            MessageBox.Show("S-a salvat fisierul serializat!");
        }

        private void deschidereBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Grupuri.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            List<Grup> listaGrupuriD = (List<Grup>)bf.Deserialize(fs);
            foreach (Grup s in listaGrupuriD)
            {
                textBox1.Text += s.ToString() + Environment.NewLine;
            }
            fs.Close();
        }


        //STERGERE: se poate folosi doar atunci cand in lista de grupuri este doar un grup
        private void bStergere_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Utilizatorul va fi sters!");
            for (int i = 0; i < lvU.SelectedItems.Count; i++)
            {
                int index = lvU.SelectedItems[i].Index;
                listaU.RemoveAt(index);
                lvU.Items.Remove(lvU.SelectedItems[i]);
            }
        }

        private void lvU_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(u);
            foreach (ListViewItem item in lvU.SelectedItems)
            {
                form2.tbID.Text = lvU.SelectedItems[0].Text;
                form2.tbNume.Text = lvU.SelectedItems[0].SubItems[1].Text;
                form2.tbNumeU.Text = lvU.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void tbIdGrup_Validating(object sender, CancelEventArgs e)
        {
            int a = Int32.Parse(tbIdGrup.Text);
            if (a <= 0 || a >= 999)
            {
                errP1.SetError(tbIdGrup, "Valoare invalida. ID-ul grupului trebuie sa fie intre 1 si 999");
                e.Cancel = true;
            }
            else
            {
                errP1.SetError(tbIdGrup, null);
            }
        }

        //MODIFICARE: se poate folosi doar atunci cand in lista de grupuri este doar un grup
        private void bModificare_Click(object sender, EventArgs e)
        {
            DialogResult rezultat = MessageBox.Show("Doriti sa modificati imobilul selectat? ", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            Form3 form3 = new Form3(u);
            //  lvU.SelectedItems[0].Text = tb
            if (form3.ShowDialog() == DialogResult.OK)
            {

                
                    lvU.SelectedItems[0].Text = form3.tbID.Text;
                    lvU.SelectedItems[0].SubItems[1].Text = form3.tbNume.Text;
                    lvU.SelectedItems[0].SubItems[2].Text = form3.tbNumeU.Text;
                    for (int i = 0; i < listaU.Count; i++)
                    {
                    for (int j = 0; j < lvU.SelectedItems.Count; j++)
                    {
                        int index = lvU.SelectedItems[j].Index;
                       
                        listaU[index].Id = Convert.ToInt32(lvU.SelectedItems[0].Text);
                        listaU[index].Nume = lvU.SelectedItems[0].SubItems[1].Text;
                        listaU[index].NumeUtilizator = lvU.SelectedItems[0].SubItems[2].Text;
                        //listaU.RemoveAt(index);
                        //u = new Utilizator(listaU[index].Id, listaU[index].Nume, listaU[index].NumeUtilizator, "-");
                        // listaU[index] = u;
                        // listaGrupuri.RemoveAt(index);
                        //  grup.ListaUtilizatori[index] = listaU[index];

                        //  listaGrupuri.Add(grup);
                    } 
                }
            }
        }
    }
}
