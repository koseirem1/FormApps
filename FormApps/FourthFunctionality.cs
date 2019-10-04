using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApps
{
    public partial class FourthFunctionality : Form
    {
        public FourthFunctionality()
        {
            InitializeComponent();
        }

      

        public void BtnSort_Click(object sender, EventArgs e)
        {
            //OpenFileDialog dialog = new OpenFileDialog();
            //StreamReader reader;
            //string line;
           
            //if (dialog.ShowDialog() == DialogResult.OK)
            //{
            //    FileInfo file = new FileInfo(dialog.FileName);
            //    dialog.Filter = "Text|*.txt";
            //    lblFile.Text = file.FullName.ToString();

            //}


            //var filePath = lblFile.Text;
            //reader = File.OpenText(filePath);
            //byte i;
            //string[] dizi = Regex.Split(reader.ReadLine()," ");
            //for (i = 0; i <= dizi.Length - 1; i++)
            //    listFile.Items.Add(dizi[i]);

            OpenFileDialog dialog = new OpenFileDialog();  
            StreamReader reader;                           

            string line;                         
            string[] ReadText;                   //dosyadaki tüm satırların tutulacağı dizi
            int count = 0;                       //  satır sayısı
            int count2 = 0;                      // toplam sayı adedi
            int ValueCount = 0;                 //Value dizisi için index değerleri olacaktır.
            float[] Value;                       //dosyadaki tüm sayıların tutulacağı dizi




            //dosya seçim ekranı

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo dosyabilgisi = new FileInfo(dialog.FileName);
                dialog.Filter = "Text|*.txt";
                lblFile.Text = dosyabilgisi.FullName.ToString();   // dosya ismini yazar
                
               
            }  

                                 

            try
            {
                var filePath = lblFile.Text;
                reader = File.OpenText(filePath);

                
                while ((line = reader.ReadLine()) != null)
                {
                    count++;   //satır sayısı

                }

                reader.Close();



               
                   ReadText = System.IO.File.ReadAllLines(filePath, System.Text.Encoding.Default);

                for (int i = 0; i < count; i++)
                {
                    string[] temp; 

                    temp = ReadText[i].Split(' '); 

                    for (int a = 0; a < temp.Length; a++)  // tüm satırlardaki toplam sayı adedi
                    {
                        count2++;          //dosyadaki toplam sayı adedi

                    } 

                } 


                //toplam sayı dizisini value değişkenine atıyorum

                Value = new float[count2];



              

                for (int i = 0; i < count; i++)
                {
                    string[] temp2;  

                    temp2 = ReadText[i].Split(' '); 

                    for (int a = 0; a < temp2.Length; a++)  
                    {

                        Value[ValueCount] = float.Parse(temp2[a]);

                        ValueCount++;

                    } 
                } 





                Array.Sort(Value);  
                Array.Reverse(Value); // diziyi tersine çevirme,  yani büyükten küçüğe sıralanır.


                // bulduğum diziyi listview e atıyorum.
                for (int i = 0; i < ValueCount; i++)
                {
                    listFile.Items.Add(Value[i].ToString());

                }

            } //end try
            catch
            {
               
                MessageBox.Show("Beklenmeyen bir durum oluştu.");
            }





        }
    }
}
