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
using iTextSharp.text.pdf;
using System.Resources;


namespace Solicitudes
{
    public partial class frm_Kups : Form
    {
        #region Variables Globales

        clsINFOMADE infomade = new clsINFOMADE();      
        
        
        #endregion

        public frm_Kups()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                //dataGridView1.Rows.Insert(dataGridView1.Rows.Count, mtb_fExamen.Text, cb_grado.Text, tb_nombre.Text, mtb_fNacimiento.Text, calcular_edad(mtb_fNacimiento.Text), mtb_fExamenAnterior.Text, mtb_fIngreso.Text);
                dataGridView1.Rows.Insert(dataGridView1.Rows.Count, mtb_fExamen.Text, cb_grado.Text, tb_nombre.Text, mtb_fNacimiento.Text, infomade.calcular_edad(Convert.ToDateTime(mtb_fNacimiento.Text)), mtb_fExamenAnterior.Text, mtb_fIngreso.Text);
                tb_nombre.Clear();                
                mtb_fIngreso.Clear();
                mtb_fNacimiento.Clear();
                tb_nombre.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }            
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_grado.Text = "PRINCIPIANTE";
            tb_nombre.Focus();
            string dia = DateTime.Today.Day.ToString(), mes= DateTime.Today.Month.ToString();

            if (DateTime.Today.Day<10)
            {
                dia = "0" + DateTime.Today.Day.ToString();
            }
            if (DateTime.Today.Month < 10)
            {
                mes ="0"+ DateTime.Today.Month.ToString();
            }

            string fecha = dia + "/" + mes + "/" + DateTime.Today.Year.ToString();

            mtb_fExamen.Text = fecha;
            mtb_fExamenAnterior.Text = fecha;            
        }

        public void ReplacePdfForm(string outputhpath, string newGrado, string fExamen, string gActual, string nombre, string fNacimiento, string edad, string examenAnterior, string fIngreso)
        {

            try
            {               

                String strAppPath = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
                String strFilePath = Path.Combine(strAppPath, "Resources");
                String strFullFilename = Path.Combine(strFilePath, "Solicitud.pdf");

                //string fileNameExisting = System.AppDomain.CurrentDomain.BaseDirectory + "/Resources/Solicitud.pdf";               
                string fileNameExisting = strFullFilename;
                //string fileNameNew = @"C:\Users\Victor\Downloads\new" + filename + ".pdf";               
                string fileNameNew = @""+outputhpath+"/" + nombre + ".pdf";

                using (var existingFileStream = new FileStream(fileNameExisting, FileMode.Open))
                using (var newFileStream = new FileStream(fileNameNew, FileMode.Create))
                {
                    // Open existing PDF
                    var pdfReader = new PdfReader(existingFileStream);

                    // PdfStamper, which will create
                    var stamper = new PdfStamper(pdfReader, newFileStream);

                    var form = stamper.AcroFields;
                    var fieldKeys = form.Fields.Keys;
                    int x = 1;
                    foreach (string fieldKey in fieldKeys)
                    {
                        //form.SetField(fieldKey, x.ToString());                        
                        
                        switch (x)
                        {
                            case (1):
                                form.SetField(fieldKey, "");
                                break;
                            case (2):
                                form.SetField(fieldKey,infomade.gradoActual(gActual,Convert.ToInt16( edad)));
                                break;
                            case (3):
                                form.SetField(fieldKey, newGrado );
                                break;
                            case (4):
                                form.SetField(fieldKey, nombre);
                                break;
                            case (5):
                                form.SetField(fieldKey,infomade.fechaLarga(fNacimiento));
                                break;
                            case (6):
                                form.SetField(fieldKey,edad);
                                break;
                            case (7):
                                form.SetField(fieldKey,infomade.fechaLarga( examenAnterior ));
                                break;
                            case (8):
                                form.SetField(fieldKey,infomade.fechaLarga( fIngreso));
                                break;
                            case (9):
                                form.SetField(fieldKey,infomade.fechaLarga( fExamen));
                                break;
                            default:
                                break;
                        }                        
                        x++;
                    }

                    // "Flatten" the form so it wont be editable/usable anymore
                    stamper.FormFlattening = true;

                    // You can also specify fields to be flattened, which
                    // leaves the rest of the form still be editable/usable
                    stamper.PartialFormFlattening("field1");

                    stamper.Close();
                    pdfReader.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }

        public void ReplacePdfForm(string outputhpath)
        {

            try
            {
                String strAppPath = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
                String strFilePath = Path.Combine(strAppPath, "Resources");
                String strFullFilename = Path.Combine(strFilePath, "Solicitud.pdf");

                //string fileNameExisting = System.AppDomain.CurrentDomain.BaseDirectory + "/Resources/Solicitud.pdf";               
                string fileNameExisting = strFullFilename;
                //string fileNameNew = @"C:\Users\Victor\Downloads\new" + filename + ".pdf";               
                string fileNameNew = @"" + outputhpath + "";

                using (var existingFileStream = new FileStream(fileNameExisting, FileMode.Open))
                using (var newFileStream = new FileStream(fileNameNew, FileMode.Create))
                {
                    // Open existing PDF
                    var pdfReader = new PdfReader(existingFileStream);

                    // PdfStamper, which will create
                    var stamper = new PdfStamper(pdfReader, newFileStream);

                    var form = stamper.AcroFields;
                    var fieldKeys = form.Fields.Keys;
                    int x = 1;
                    foreach (string fieldKey in fieldKeys)
                    {
                        // form.SetField(fieldKey, x.ToString());
                        switch (x)
                        {
                            case (1):
                                form.SetField(fieldKey, "");
                                break;
                            case (2):
                                form.SetField(fieldKey, infomade.gradoActual(cb_grado.Text,Convert.ToInt16(infomade.calcular_edad(Convert.ToDateTime(mtb_fNacimiento.Text)))));
                                break;
                            case (3):
                                form.SetField(fieldKey, infomade.nuevogrado(cb_grado.Text, Convert.ToInt16(infomade.calcular_edad(Convert.ToDateTime(mtb_fNacimiento.Text)))));
                                break;
                            case (4):
                                form.SetField(fieldKey, tb_nombre.Text);
                                break;
                            case (5):
                                form.SetField(fieldKey,infomade.fechaLarga(mtb_fNacimiento.Text));
                                break;
                            case (6):
                                form.SetField(fieldKey, infomade.calcular_edad(Convert.ToDateTime(mtb_fNacimiento.Text)));
                                break;
                            case (7):
                                form.SetField(fieldKey,infomade.fechaLarga( mtb_fExamenAnterior.Text));
                                break;
                            case (8):
                                form.SetField(fieldKey,infomade.fechaLarga( mtb_fIngreso.Text));
                                break;
                            case (9):
                                form.SetField(fieldKey,infomade.fechaLarga( mtb_fExamen.Text));
                                break;
                            default:
                                break;
                        }
                                x++;
                    }

                    // "Flatten" the form so it wont be editable/usable anymore
                    stamper.FormFlattening = true;

                    // You can also specify fields to be flattened, which
                    // leaves the rest of the form still be editable/usable
                    stamper.PartialFormFlattening("field1");

                    stamper.Close();
                    pdfReader.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string pathString = System.IO.Path.Combine(path,mtb_fExamen.Text.Substring(6)+"/"+ mtb_fExamen.Text.Substring(3,2));            

            if (Directory.Exists(pathString))
            {
                
            }
            else
            {
                Directory.CreateDirectory(pathString);
            }

            int ti = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //(string outputhpath, string newGrado, string fExamen, string gActual, string nombre, string fNacimiento, string edad, string examenAnterior, string fIngreso)
                //ReplacePdfForm(pathString, "1","2","3","4","5","6","7","8", "9");
                ReplacePdfForm(pathString,infomade.nuevogrado(row.Cells[1].Value.ToString(),Convert.ToInt16(row.Cells[4].Value)), row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString());
                //ReplacePdfForm( pathString,row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString(), "8","9");                                
            }

            dataGridView1.Rows.Clear();
            MessageBox.Show("Solicitudes creadas");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Files|*.pdf";
            sfd.ValidateNames = true;
            sfd.FileName = tb_nombre.Text;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ReplacePdfForm(sfd.FileName);
            }
            tb_nombre.Clear();
            mtb_fIngreso.Clear();
            mtb_fNacimiento.Clear();
            tb_nombre.Focus();
            MessageBox.Show("Archivo Creado");
        }                
        
    }
}
