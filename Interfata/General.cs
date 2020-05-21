using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmacie;

namespace Interfata
{
    public partial class General : Form
    {
        
       
        public int nrMed = 0;

        private TextBox txtDenumire;
        private TextBox txtPret;
        
        private TextBox txtCautNume;
        private Label CautNume;
        
        private Label Denumire;
        private Label Pret;
        private Label Tip;
        private Label Pres;
        private Button btnAdaugare;
        private Button btnCautaNume;
        private Button btnEditare;
        private Button btnAfisare;
        private ListBox lstAfisare;
        private CheckBox comp1;
        private CheckBox sir1;
        private CheckBox ung1;
        private RadioButton Y1;
        private RadioButton N1;




        private const int LATIME_CONTROL = 150;
        private const int INALTIME_CONTROL = 20;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 170;
        private const int LUNGIME_MAX = 15;
        private const int PRET_MIN = 1;
        private const int TIP_MIN = 0;
        private const int TIP_MAX = 3;
        private const int PRES_MIN = 0;
        private const int PRES_MAX = 1;


        public General()

        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1000, 500);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.Black;
            this.Text = "Farmacie";


            Denumire = new Label();
            Denumire.Width = LATIME_CONTROL;
            Denumire.Text = "Denumire:";
            Denumire.BackColor = Color.Transparent;
            this.Controls.Add(Denumire);

            Pret = new Label();
            Pret.Width = LATIME_CONTROL;
            Pret.Text = "Pret:";
            Pret.Top = DIMENSIUNE_PAS_Y;
            Pret.BackColor = Color.Transparent;
            this.Controls.Add(Pret);

            Tip = new Label();
            Tip.Width = LATIME_CONTROL-50 ;
            Tip.Text = "Tip:";
            Tip.Top = DIMENSIUNE_PAS_Y * 2;
            Tip.BackColor = Color.Transparent;
            this.Controls.Add(Tip);

            Pres = new Label();
            Pres.Width = LATIME_CONTROL -50;
            Pres.Text = "Prescriptie:";
            Pres.Top = DIMENSIUNE_PAS_Y * 3;
            Pres.BackColor = Color.Transparent;
            this.Controls.Add(Pres);

            /*Info = new Label();
            Info.Width = LATIME_CONTROL * 3;
            Info.Height = INALTIME_CONTROL * 3;
            Info.Top = DIMENSIUNE_PAS_Y * 7;
            Info.BackColor = Color.Green;
            Info.ForeColor = Color.White;
            this.Controls.Add(Info)*/


            txtDenumire = new TextBox();
            txtDenumire.Width = LATIME_CONTROL;
            txtDenumire.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X + 110, 0);
            this.Controls.Add(txtDenumire);

            txtPret = new TextBox();
            txtPret.Width = LATIME_CONTROL;
            txtPret.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X + 110, DIMENSIUNE_PAS_Y);
            this.Controls.Add(txtPret);

            comp1 = new CheckBox();
            comp1.Location = new Point(DIMENSIUNE_PAS_X -70, DIMENSIUNE_PAS_Y * 2);
            comp1.Text = "Comprimat";
            comp1.Width = LATIME_CONTROL;
            this.Controls.Add(comp1);

             sir1 = new CheckBox();
            sir1.Location = new Point(DIMENSIUNE_PAS_X+110 , DIMENSIUNE_PAS_Y * 2);
            sir1.Text = "Sirop";
            sir1.Width = LATIME_CONTROL-50;
            this.Controls.Add(sir1);

            ung1 = new CheckBox();
            ung1.Location = new Point(DIMENSIUNE_PAS_X+220, DIMENSIUNE_PAS_Y * 2);
            ung1.Text = "Unguent";
            ung1.Width = LATIME_CONTROL;
            this.Controls.Add(ung1);

            

             Y1 = new RadioButton();
            Y1.Location = new Point(DIMENSIUNE_PAS_X - 35, DIMENSIUNE_PAS_Y * 3);
            Y1.Text = "Da";
            Y1.Width = LATIME_CONTROL - 100;
            this.Controls.Add(Y1);

            N1 = new RadioButton();
            N1.Location = new Point(DIMENSIUNE_PAS_X + 15, DIMENSIUNE_PAS_Y * 3);
            N1.Text = "Nu";
            N1.Width = LATIME_CONTROL;
            this.Controls.Add(N1);

            /*txtTip = new TextBox();
            txtTip.Width = LATIME_CONTROL;
            txtTip.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X + 110, DIMENSIUNE_PAS_Y * 2);
            this.Controls.Add(txtTip);*/

            /*txtPres = new TextBox();
            txtPres.Width = LATIME_CONTROL;
            txtPres.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X + 110, DIMENSIUNE_PAS_Y * 3);
            this.Controls.Add(txtPres);*/

            btnAdaugare = new Button();
            btnAdaugare.Width = LATIME_CONTROL;
            btnAdaugare.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X + 110, 4 * DIMENSIUNE_PAS_Y);
            btnAdaugare.BackColor = Color.Transparent;
            btnAdaugare.ForeColor = Color.Black;
            btnAdaugare.Text = "Adauga Medicament";
            this.Controls.Add(btnAdaugare);



            btnCautaNume = new Button();
            btnCautaNume.Width = LATIME_CONTROL;
            btnCautaNume.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X + 115, 10 * DIMENSIUNE_PAS_Y);
            btnCautaNume.BackColor = Color.Transparent;
            btnCautaNume.ForeColor = Color.Black;
            btnCautaNume.Text = "Cautare nume";
            this.Controls.Add(btnCautaNume);







            btnAdaugare.Click += OnButtonAdaugaClicked;
            this.Controls.Add(btnAdaugare);
            btnCautaNume.Click += OnButtonCautaNumeClicked;
            this.Controls.Add(btnCautaNume);
            txtCautNume = new TextBox();
            txtCautNume.Width = LATIME_CONTROL;
            txtCautNume.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X + 115, DIMENSIUNE_PAS_Y * 9);

            this.Controls.Add(txtCautNume);

            CautNume = new Label();
            CautNume.Width = LATIME_CONTROL + 50;
            CautNume.Text = "Medicamentul cautat:";
            CautNume.Top = DIMENSIUNE_PAS_Y * 9;
            CautNume.BackColor = Color.Transparent;
            CautNume.ForeColor = Color.Black;
            this.Controls.Add(CautNume);

            btnEditare = new Button();
            btnEditare.Text = "Editare";
            btnEditare.Width = LATIME_CONTROL;
            btnEditare.Location = new Point(DIMENSIUNE_PAS_X+110, DIMENSIUNE_PAS_Y * 5);
            btnEditare.BackColor = Color.Transparent;
            btnEditare.ForeColor = Color.Black;
            this.Controls.Add(btnEditare);
            btnEditare.Click += OnButtonEditareClicked;

            btnAfisare = new Button();
            btnAfisare.Text = "Afiasare";
            btnAfisare.Width = LATIME_CONTROL;
            btnAfisare.Location = new Point(DIMENSIUNE_PAS_X + 110, DIMENSIUNE_PAS_Y * 6);
            btnAfisare.BackColor = Color.Transparent;
            btnAfisare.ForeColor = Color.Black;
            this.Controls.Add(btnAfisare);
            btnAfisare.Click += OnButtonAfisareClicked;

            lstAfisare = new ListBox();
            lstAfisare.Location = new Point(DIMENSIUNE_PAS_X + 400, DIMENSIUNE_PAS_Y-20);
            lstAfisare.Size = new Size(460, 300);
            this.Controls.Add(lstAfisare);






        }

        private void OnButtonAdaugaClicked(object sender, EventArgs e)
        {

            int validare = Validare();
            nrMed++;

            Denumire.ForeColor = Color.LimeGreen;
            Pret.ForeColor = Color.LimeGreen;
            Tip.ForeColor = Color.LimeGreen;
            Pres.ForeColor = Color.LimeGreen;
           


            if (validare == 0)

            {
                int ty = 0, prt = 0;
                if (comp1.Checked == true)
                    ty = 1;
                else if (sir1.Checked == true)
                    ty = 2;
                else if (ung1.Checked == true)
                    ty = 3;
                if (Y1.Checked == true)
                    prt = 1;
                else if (N1.Checked == true)
                    prt = 0;


                Medicamente m = new Medicamente(txtDenumire.Text, Convert.ToDouble(txtPret.Text), ty, prt);
                lstAfisare.Items.Clear();
                lstAfisare.Items.Add(nrMed + "." + m.Afisare());
                Op_Text x1 = new Op_Text("abc.txt");
                x1.AddMedicament(m);







            }
            else
            {

                switch (validare)
                {
                    case 1:
                        Denumire.ForeColor = Color.Red;
                        break;
                    case 2:
                        Pret.ForeColor = Color.Red;
                        break;
                    case 3:
                        Tip.ForeColor = Color.Red;
                        break;
                    case 4:
                        Pres.ForeColor = Color.Red;
                        break;

                    default:
                        break;
                }

            }
        }
        private void OnButtonCautaNumeClicked(object sender, EventArgs e)
        {

            int validare = Validare();

            Denumire.ForeColor = Color.LimeGreen;
            Pret.ForeColor = Color.LimeGreen;
            Tip.ForeColor = Color.LimeGreen;
            Pres.ForeColor = Color.LimeGreen;
            Op_Text x2 = new Op_Text("abc.txt");
            System.Collections.ArrayList k = new System.Collections.ArrayList();
            k = x2.GetMedicamente();
            foreach (Medicamente y in k)
            {
                if (y.nume == txtCautNume.Text.ToUpper())

                {
                    lstAfisare.Items.Clear();
                    lstAfisare.Items.Add(y.infoComplet);
                    break;
                }
                else
                {
                    lstAfisare.Items.Clear();
                    lstAfisare.Items.Add("Medicamentul nu a fost gasit!");
                    continue;
                }


            }


           















        }
        private void OnButtonAfisareClicked(object sender, EventArgs e)
        {
            lstAfisare.Items.Clear();
            Op_Text ad = new Op_Text("abc.txt");
            ArrayList r = ad.GetMedicamente();
            foreach(Medicamente m in r)
            {
                lstAfisare.Items.Add(m.Afisare());
            }
        }
        private void OnButtonEditareClicked(object sender,EventArgs e)
        {
            Op_Text abc = new Op_Text("abc.txt");
            ArrayList w = abc.GetMedicamente();
            
            Edit e1 = new Edit(w);
            e1.Show();
            
        }


        private int Validare()
        {
            if (txtDenumire.Text == string.Empty || txtDenumire.Text.Length > LUNGIME_MAX)
            {
                lstAfisare.Items.Clear();
                lstAfisare.Items.Add("Date invalide,reintroduceti.");


                return 1;
            }
            else if (txtPret.Text == string.Empty || Convert.ToDouble(txtPret.Text) < PRET_MIN)

            {
                lstAfisare.Items.Clear();
                lstAfisare.Items.Add("Date invalide,reintroduceti.");

                return 2;
            }
            else if ((comp1.Checked==true&&sir1.Checked==true&&ung1.Checked==true)||(sir1.Checked==false&&ung1.Checked==false&&comp1.Checked==false))
            {
                lstAfisare.Items.Clear();
                lstAfisare.Items.Add("Date invalide,reintroduceti.");
                 
                return 3;
            }

            else if (Y1.Checked==false && N1.Checked==false)
            {
                lstAfisare.Items.Clear();
                lstAfisare.Items.Add("Date invalide,reintroduceti.");
                return 4;
            }


            return 0;
        }
    }

    }

    


