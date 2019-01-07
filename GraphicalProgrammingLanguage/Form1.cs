using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Text;
using System.IO;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace GraphicalProgrammingLanguage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open File You Want TO Open";
            //string text = File.ReadAllText(file);
            // ofd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            // ofd.Filter = "BackUp File(*.bak)|*.bak|All Files(*.*)|(*.*)";
           ofd.Filter = "All Files (*.docx;*.Pdf;*.txt;)|*.docx;*.Pdf;*.txt;";
            //           (*.BMP; *.JPG; *.GIF,*.PNG,*.TIFF)| *.BMP; *.JPG; *.GIF; *.PNG; *.TIFF | " +  
            //"All files (*.*)|*.*";
            ofd.FilterIndex = 0;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtLoadFile.Text = ofd.FileName;
            }
        
    }

        private void btnopen_Click(object sender, EventArgs e)
        {
            //Stream mystream;
            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Title = "Open File you want to Open";
            //ofd.Filter = "All Files (*.docx;*.Pdf;*.txt;)|*.docx;*.Pdf;*.txt;";
            //if (ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            //{
            //    if((mystream=ofd.OpenFile())!=null)
            //    {

            //        string kedar = ofd.FileName;
            //        string filetextupload = File.ReadAllText(kedar);
            //        txtrun.Text = filetextupload;
            //    }
            //}
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Word Documents|*.doc; *.docx;*.txt;*.pdf";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
                object miss = System.Reflection.Missing.Value;
                object path = ofd.FileName;
                object readOnly = true;
                Microsoft.Office.Interop.Word.Document docs = word.Documents.Open(ref path, ref miss, ref readOnly,
                    ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss,
                    ref miss, ref miss, ref miss, ref miss);
                var totaltextBuilder = new StringBuilder();

                for (int i = 0; i < docs.Paragraphs.Count; i++)
                {
                    totaltextBuilder.Append( docs.Paragraphs[i + 1].Range.Text.ToString());
                }

               txtLoadFile.Text = totaltextBuilder.ToString();
            }







        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    myStream.Close();

                }


                    //// Displays a SaveFileDialog so the user can save the Image  
                    //// assigned to Button2.  
                    //SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    //saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
                    //saveFileDialog1.Title = "Save an Image File";
                    //saveFileDialog1.ShowDialog();

                    //// If the file name is not an empty string open it for saving.  
                    //if (saveFileDialog1.FileName != "")
                    //{
                    //    // Saves the Image via a FileStream created by the OpenFile method.  
                    //    System.IO.FileStream fs =
                    //       (System.IO.FileStream)saveFileDialog1.OpenFile();
                    //    // Saves the Image in the appropriate ImageFormat based upon the  
                    //    // File type selected in the dialog box.  
                    //    // NOTE that the FilterIndex property is one-based.  
                    //    switch (saveFileDialog1.FilterIndex)
                    //    {
                    //        case 1:
                    //            this.btnSave.Image.Save(fs,
                    //               System.Drawing.Imaging.ImageFormat.Jpeg);
                    //            break;

                    //        case 2:
                    //            this.btnSave.Image.Save(fs,
                    //               System.Drawing.Imaging.ImageFormat.Bmp);
                    //            break;

                    //        case 3:
                    //            this.btnSave.Image.Save(fs,
                    //               System.Drawing.Imaging.ImageFormat.Gif);
                    //            break;
                    //    }

                    //    fs.Close();
                }
        }  
    }
}
