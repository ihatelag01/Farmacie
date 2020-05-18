 
using System;
using System.Collections;
using System.IO;

namespace Farmacie
{
    //clasa AdministrareStudenti_FisierText implementeaza interfata IStocareData
    public class Op_Text
    {
        
        private const int PAS_ALOCARE = 1; 

        string NumeFisier { get; set; }
        public Op_Text(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            sFisierText.Close();

            //liniile de mai sus pot fi inlocuite cu linia de cod urmatoare deoarece
            //instructiunea 'using' va apela sFisierText.Close();
            //using (Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate)) { }
        }
        public void AddMedicament(Medicamente m)
        {
            //student.IdStudent = GetId();
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'true' al constructorului StreamWriter indica modul 'append' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
                {

                    swFisierText.WriteLine(m.ConversieLaSir_PentruFisier());
                }
               
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }

        public ArrayList GetMedicamente()
        {
            ArrayList medicamente = new ArrayList();

            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line=string.Empty;

                    
                    while ((line=sr.ReadLine())!= null)
                    {
                         

                            Medicamente m = new Medicamente(line);
                            medicamente.Add(m);
                         
                         
                    }
                    
                    sr.Close();
                    
                    
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return medicamente;
        }
        public Medicamente[] GetMed(out int nrMed)
        {
            Medicamente[] medicamente = new Medicamente[PAS_ALOCARE];

            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;
                    nrMed = 0;

                    //citeste cate o linie si creaza un obiect de tip Medicamente pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        nrMed++;

                        medicamente[nrMed] = new Medicamente(line);


                        if (nrMed == PAS_ALOCARE)
                        {
                            Array.Resize(ref medicamente, nrMed + PAS_ALOCARE);
                        }
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return medicamente;
        }


    }
}
