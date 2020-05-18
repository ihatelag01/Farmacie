using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private TextBox txtTip;
        private TextBox txtPres;
        private TextBox txtCautNume;
        private Label CautNume;
        private Label Info;
        private Label Denumire;
        private Label Pret;
        private Label Tip;
        private Label Pres;
        private Button btnAdaugare;
        private Button btnCautaNume;
        private Button btnEditare;





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
            this.Size = new System.Drawing.Size(500, 500);
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
            Tip.Width = LATIME_CONTROL + 120;
            Tip.Text = "Tip(1.Comprimat/2.Sirop/3.Unguent):";
            Tip.Top = DIMENSIUNE_PAS_Y * 2;
            Tip.BackColor = Color.Transparent;
            this.Controls.Add(Tip);

            Pres = new Label();
            Pres.Width = LATIME_CONTROL + 20;
            Pres.Text = "Prescriptie(0.Nu/1.Da):";
            Pres.Top = DIMENSIUNE_PAS_Y * 3;
            Pres.BackColor = Color.Transparent;
            this.Controls.Add(Pres);

            Info = new Label();
            Info.Width = LATIME_CONTROL * 3;
            Info.Height = INALTIME_CONTROL * 3;
            Info.Top = DIMENSIUNE_PAS_Y * 7;
            Info.BackColor = Color.Green;
            Info.ForeColor = Color.White;
            this.Controls.Add(Info);


            txtDenumire = new TextBox();
            txtDenumire.Width = LATIME_CONTROL;
            txtDenumire.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X + 110, 0);
            this.Controls.Add(txtDenumire);

            txtPret = new TextBox();
            txtPret.Width = LATIME_CONTROL;
            txtPret.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X + 110, DIMENSIUNE_PAS_Y);
            this.Controls.Add(txtPret);

            txtTip = new TextBox();
            txtTip.Width = LATIME_CONTROL;
            txtTip.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X + 110, DIMENSIUNE_PAS_Y * 2);
            this.Controls.Add(txtTip);

            txtPres = new TextBox();
            txtPres.Width = LATIME_CONTROL;
            txtPres.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X + 110, DIMENSIUNE_PAS_Y * 3);
            this.Controls.Add(txtPres);

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

                Medicamente m = new Medicamente(txtDenumire.Text, Convert.ToDouble(txtPret.Text), Convert.ToInt32(txtTip.Text), Convert.ToInt32(txtPres.Text));
                Info.Text = nrMed + "." + m.Afisare();
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
                    Info.Text = y.infoComplet;
                    break;
                }
                else
                {
                    Info.Text = "Medicamentul nu a fost gasit!";
                    continue;
                }


            }


















        }
        private void OnButtonEditareClicked(object sender,EventArgs e)
        {
          
        }


        private int Validare()
        {
            if (txtDenumire.Text == string.Empty || txtDenumire.Text.Length > LUNGIME_MAX)
            {
                Info.Text = "Date invalide,reintroduceti.";
                Info.BackColor = Color.Red;
                Info.ForeColor = Color.White;

                return 1;
            }
            else if (txtPret.Text == string.Empty || Convert.ToDouble(txtPret.Text) < PRET_MIN)

            {
                Info.Text = "Date invalide,reintroduceti.";
                Info.BackColor = Color.Red;
                Info.ForeColor = Color.White;
                return 2;
            }
            else if (txtTip.Text == string.Empty || (Convert.ToInt32(txtTip.Text) < TIP_MIN || Convert.ToInt32(txtTip.Text) > TIP_MAX))
            {
                Info.Text = "Date invalide,reintroduceti.";
                Info.BackColor = Color.Red;
                Info.ForeColor = Color.White;
                return 3;
            }

            else if (txtPres.Text == string.Empty || (Convert.ToInt32(txtPres.Text) != PRES_MIN && Convert.ToInt32(txtPres.Text) != PRES_MAX))
            {
                Info.Text = "Date invalide,reintroduceti.";
                Info.BackColor = Color.Red;
                Info.ForeColor = Color.White;
                return 4;
            }


            return 0;
        }
    }

    }

    


