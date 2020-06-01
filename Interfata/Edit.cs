//Vizitiu Alexandru 3123b
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
        private const int LUNGIME_MAX = 15;
        private const int PRET_MIN = 1;
        private const int TIP_MIN = 0;
        private const int TIP_MAX = 3;
        private const int PRES_MIN = 0;
        private const int PRES_MAX = 1;

        public int b = 10;
        private Label sel = new Label();
        private Button btnSel = new Button();
        public Edit( ArrayList w)
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
            w = y.GetMedicamente();
            




            ComboBox c1 = new ComboBox();
            c1.Location = new Point(15, DIMENSIUNE_PAS_Y * 2);
            c1.Text = "Alegeti...";
            c1.Width = LATIME_CONTROL + 150;
            c1.DropDownHeight = 100;
            
            //c1.DataSource = w;
            foreach (Medicamente l in w)
            {
                c1.Items.Add(l.infoComplet);
               
               
                
                






            }






            this.Controls.Add(c1);


            btnSel.Text = "Selectati";
            btnSel.Width = LATIME_CONTROL;
            btnSel.Location = new Point(320, DIMENSIUNE_PAS_Y * 2);
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

                CheckBox comp = new CheckBox();
                comp.Location = new Point(DIMENSIUNE_PAS_X - 35, DIMENSIUNE_PAS_Y * 5);
                comp.Text = "Comprimat";
                comp.Width = LATIME_CONTROL;
                this.Controls.Add(comp);

                CheckBox sir = new CheckBox();
                sir.Location = new Point(DIMENSIUNE_PAS_X - 35, DIMENSIUNE_PAS_Y * 6);
                sir.Text = "Sirop";
                comp.Width = LATIME_CONTROL;
                this.Controls.Add(sir);

                CheckBox ung = new CheckBox();
                ung.Location = new Point(DIMENSIUNE_PAS_X - 35, DIMENSIUNE_PAS_Y * 7);
                ung.Text = "Unguent";
                ung.Width = LATIME_CONTROL;
                this.Controls.Add(ung);

                Label newPres = new Label();
                newPres.Width = LATIME_CONTROL - 20;
                newPres.Top = DIMENSIUNE_PAS_Y * 8;
                newPres.Text = "Prescriptie:";
                newPres.BackColor = Color.Transparent;
                this.Controls.Add(newPres);

                RadioButton Y = new RadioButton();
                Y.Location = new Point(DIMENSIUNE_PAS_X - 35, DIMENSIUNE_PAS_Y * 8);
                Y.Text = "Da";
                Y.Width = LATIME_CONTROL - 100;
                this.Controls.Add(Y);

                RadioButton N = new RadioButton();
                N.Location = new Point(DIMENSIUNE_PAS_X + 15, DIMENSIUNE_PAS_Y * 8);
                N.Text = "Nu";
                N.Width = LATIME_CONTROL;
                this.Controls.Add(N);

                Button btnSave = new Button();
                btnSave.Text = "Salvati modificarile!";

                btnSave.Width = LATIME_CONTROL;
                btnSave.Location = new Point(DIMENSIUNE_PAS_X - 35, DIMENSIUNE_PAS_Y * 9);
                this.Controls.Add(btnSave);
                btnSave.Click +=    OnButtonSaveClicked;
                void OnButtonSaveClicked(object sender,EventArgs e)
                {
                    int v = ValidareEdit();
                    if (v == 0)
                    {
                        string s1 = txtNewDen.Text;
                        double p = Convert.ToDouble(txtNewPrice.Text);
                        int t = 0;
                        int pr = 0;
                        if (comp.Checked == true)
                            t = 1;
                        else if (sir.Checked == true)
                            t = 2;
                        else if (ung.Checked == true)
                            t = 3;
                        if (Y.Checked == true)
                            pr = 1;
                        else if (N.Checked == true)
                            pr = 0;
                        Medicamente x = new Medicamente(s1, p, t, pr);
                        foreach (Medicamente q in w)
                        {
                            if (c1.SelectedIndex==w.IndexOf(q))
                            {
                                q.nume = x.nume;
                                q.pret = x.pret;
                                q.TIP = x.TIP;
                                q.PRES = x.PRES;
                            }

                        }
                       
                    }
                    else
                    {
                        switch(v)
                        {
                            case 1:
                                NewDen.ForeColor = Color.Red;
                                break;
                            case 2:
                                NewPrice.ForeColor = Color.Red;
                                break;
                            case 3:
                                newTip.ForeColor = Color.Red;
                                break;
                            case 4:
                                newPres.ForeColor = Color.Red;
                                break;
                                
                        }
                        
                    }
                     
                    
                    
                }
                 int ValidareEdit()
                {
                    if(txtNewDen.Text==string.Empty|| txtNewDen.Text.Length>LUNGIME_MAX)
                    {
                        
                        return 1; 

                    }
                    else if(txtNewPrice.Text==string.Empty||Convert.ToDouble(txtNewPrice.Text)<PRET_MIN)
                    {
                        
                        return 2;
                    }
                    else if ((comp.Checked == true && sir.Checked == true && ung.Checked == true) || (sir.Checked == false && ung.Checked == false && comp.Checked == false))
                    {
                        

                        return 3;
                    }

                    else if (Y.Checked == false && N.Checked == false)
                    {
                        
                        return 4;
                    }


                    return 0;


                }
                 
            }
            

            

                
            }
        }
    }

