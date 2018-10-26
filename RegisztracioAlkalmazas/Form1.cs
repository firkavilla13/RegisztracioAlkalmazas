using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            saveButton.Click += (sender, e) =>
            {
                Mentes();
            };
            
                 

        }

     
        private void Mentes()
        {
            List<string> adatok = new List<string>();
            string nev = "Név: " + tb_name.Text;
            string datum="Születési dátum: "+ Convert.ToString(dtp_date.Value);
            string nem=" Nem: ";
            if (rb_f.Checked)
            {
                nem += "Férfi\r\nKedvenc Hobbi:\r\n";
            }
            else
            {
                nem += "Nő\r\nKedvenc Hobbi:\r\n";
            }
            adatok.Add(nev);
            adatok.Add(datum);
            adatok.Add(nem);
            string hobbik = "";          
            for (int i = 0; i < lb_hobbi.Items.Count; i++)
            {
                if (i == lb_hobbi.Items.Count - 1)
                {
                    hobbik += lb_hobbi.Items[i].ToString();
                }
                 else
	            {
                    hobbik += lb_hobbi.Items[i].ToString() + ";";

	            }
        
                      
            }
            adatok.Add(hobbik);

            string adat = "";
            for (int i = 0; i <adatok.Count ; i++)
            {
                adat += adatok[i];
            }
                  


            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(saveFileDialog.FileName));

                write.Write(adat); 
                write.Dispose();
            }
        }



        private void hozzaadButton_Click(object sender, EventArgs e)
        {
            lb_hobbi.Items.Add(tb_ujhobbi.Text);
            tb_ujhobbi.Clear();


        }
        

        private void buttonTallozas_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.ShowDialog();
                if (op.ShowDialog() == DialogResult.OK)
                {
                    tb_path.Text = op.FileName;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void openButton_Click(object sender,EventArgs e)
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(tb_path.Text);
                string hobbi = lines[2];
                string[] hobbik = hobbi.Split(';');

                for (int i = 3; i <hobbik.Length; i++)
                {
                    lb_hobbi.Items.Add(hobbik[i]);

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
    

