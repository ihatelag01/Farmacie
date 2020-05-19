using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Farmacie;
using Interfata;

namespace Interfata
{
    public partial class Edit : Form
    {
        private const int LATIME_CONTROL = 150;
        private const int INALTIME_CONTROL = 20;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 170;
        public int b = 10;
        private Label sel = new Label();
        private Button btnSel = new Button();
        public Edit()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(500, 500);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(700, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.Black;
            this.Text = "Editare";

            sel.Width = LATIME_CONTROL + 120;
            sel.Top = 10;
            sel.Text = "Selectati medicamentul din lista:";
            sel.ForeColor = Color.Black;
            this.Controls.Add(sel);

            Op_Text y = new Op_Text("abc.txt");
            ArrayList y1 = y.GetMedicamente();





            ComboBox c1 = new ComboBox();
            c1.Location = new Point(15, DIMENSIUNE_PAS_Y * 2);
            c1.Width = LATIME_CONTROL + 120;
            c1.DropDownHeight = 100;
            foreach (Medicamente l in y1)
            {
                c1.Items.Add(l);
                c1.Text = l.infoComplet;






            }




            this.Controls.Add(c1);


            btnSel.Text = "Selectati";
            btnSel.Width = LATIME_CONTROL;
            btnSel.Location = new Point(300, DIMENSIUNE_PAS_Y * 2);
            this.Controls.Add(btnSel);
            btnSel.Click += OnButtonSelClicked;
            void OnButtonSelClicked(object sender, EventArgs e)
            {
                Label NewDen = new Label();
                NewDen.Width = LATIME_CONTROL - 20;
                NewDen.Text = "Denumire:";
                NewDen.BackColor = Color.Transparent;
                NewDen.Top = DIMENSIUNE_PAS_Y * 3;
                this.Controls.Add(NewDen);

                Label NewPrice = new Label();
                NewPrice.Width = LATIME_CONTROL - 20;
                NewPrice.Text = "Pret:";
                NewPrice.BackColor = Color.Transparent;
                NewPrice.Top = DIMENSIUNE_PAS_Y * 4;
                this.Controls.Add(NewPrice);

                TextBox txtNewDen = new TextBox();
                txtNewDen.Width = LATIME_CONTROL;
                txtNewDen.Location = new Point(DIMENSIUNE_PAS_X - 35, DIMENSIUNE_PAS_Y * 3);
                this.Controls.Add(txtNewDen);

                TextBox txtNewPrice = new TextBox();
                txtNewPrice.Width = LATIME_CONTROL;
                txtNewPrice.Location = new Point(DIMENSIUNE_PAS_X - 35, DIMENSIUNE_PAS_Y * 4);
                this.Controls.Add(txtNewPrice);

                Label newTip = new Label();
                newTip.Width = LATIME_CONTROL - 20;
                newTip.Text = "Tip:";
                newTip.Top = DIMENSIUNE_PAS_Y * 5;
                newTip.BackColor = Color.Transparent;
                this.Controls.Add(newTip);

                RadioButton comp = new RadioButton();
                comp.Top = DIMENSIUNE_PAS_Y * 5;
                
                
                this.Controls.Add(comp);


            }
        }
    }
}
