using iTextSharp.text.pdf;
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

namespace Solicitudes
{
    public partial class frm_CintasNegras : Form
    {
        public frm_CintasNegras()
        {
            InitializeComponent();
        }

        clsINFOMADE INFOMADE = new clsINFOMADE();

        private void LimpiarCampos()
        {
            txt_nombre.Clear();
            txt_Ocupacion.Clear();
            mtb_fIngreso.Clear();
            mtb_f_nacimiento.Clear();
            mtb_f_ExamenAnterior.Clear();

            txt_nombre.Focus();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //dataGridView1.Rows.Insert(dataGridView1.Rows.Count, mtb_fExamen.Text, cb_grado.Text, tb_nombre.Text, mtb_fNacimiento.Text, calcular_edad(mtb_fNacimiento.Text), mtb_fExamenAnterior.Text, mtb_fIngreso.Text);
                dataGridView1.Rows.Insert(dataGridView1.Rows.Count, cb_GradoActual.Text,nud_Parciales.Value.ToString(), txt_nombre.Text, mtb_f_nacimiento.Text, INFOMADE.calcular_edad(Convert.ToDateTime(mtb_f_nacimiento.Text)), txt_Ocupacion.Text, mtb_f_ExamenAnterior.Text,mtb_fIngreso.Text,txt_Comentarios.Text);
                LimpiarCampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();     
            sfd.Filter = "PDF Files|*.pdf";
            sfd.ValidateNames = true;
            sfd.FileName = txt_nombre.Text;
            
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                splashScreenManager1.ShowWaitForm();
                ReplacePdfForm(sfd.FileName);
                splashScreenManager1.CloseWaitForm();
                MessageBox.Show("Archivo Creado");
            }
            LimpiarCampos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string pathString = System.IO.Path.Combine(path, "CintasNegras\\" + DateTime.Now.Year.ToString());

            if (!Directory.Exists(pathString))            
                Directory.CreateDirectory(pathString);        
            
            //int ti = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {                
                ReplacePdfForm(pathString, INFOMADE.nuevogrado(row.Cells[0].Value.ToString(), Convert.ToInt16(row.Cells[4].Value),true), INFOMADE.gradoActual(row.Cells[0].Value.ToString(), Convert.ToInt16(row.Cells[4].Value), true), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString(), row.Cells[7].Value.ToString(), row.Cells[8].Value.ToString());                    
                                
            }

            dataGridView1.Rows.Clear();
            splashScreenManager1.CloseWaitForm();
            MessageBox.Show("Solicitudes creadas");
        }

        public void ReplacePdfForm(string outputhpath)
        {

            try
            {
                String strAppPath = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
                String strFilePath = Path.Combine(strAppPath, "Resources");
                String strFullFilename = Path.Combine(strFilePath, "SolicitudCN.pdf");

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
                                form.SetField(fieldKey, INFOMADE.gradoActual(cb_GradoActual.Text, Convert.ToInt16(INFOMADE.calcular_edad(Convert.ToDateTime(mtb_f_nacimiento.Text))),true));
                                break;
                            case (2):
                                form.SetField(fieldKey, INFOMADE.nuevogrado(cb_GradoActual.Text, Convert.ToInt16(INFOMADE.calcular_edad(Convert.ToDateTime(mtb_f_nacimiento.Text))),true));
                                break;
                            case (3):
                                form.SetField(fieldKey, nud_Parciales.Text);
                                break;
                            case (4):
                                form.SetField(fieldKey, txt_nombre.Text);
                                break;
                            case (5):
                                form.SetField(fieldKey, INFOMADE.fechaLarga(mtb_f_nacimiento.Text));
                                break;
                            case (6):
                                form.SetField(fieldKey, INFOMADE.calcular_edad(Convert.ToDateTime(mtb_f_nacimiento.Text)));
                                break;
                            case (7):
                                form.SetField(fieldKey, txt_Ocupacion.Text);
                                break;
                            case (8):
                                form.SetField(fieldKey, INFOMADE.fechaLarga(mtb_f_ExamenAnterior.Text));
                                break;
                            case (9):
                                form.SetField(fieldKey, INFOMADE.fechaLarga(mtb_fIngreso.Text));
                                break;
                            case (10):
                                form.SetField(fieldKey, txt_Comentarios.Text);
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

        public void ReplacePdfForm(string outputhpath, string newGrado, string gActual,string parciales, string nombre, string fNacimiento, string edad, string ocupacion, string fExamenAnterior, string f_Ingreso, string comentarios)
        {

            try
            {

                String strAppPath = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
                String strFilePath = Path.Combine(strAppPath, "Resources");
                String strFullFilename = Path.Combine(strFilePath, "SolicitudCN.pdf");

                //string fileNameExisting = System.AppDomain.CurrentDomain.BaseDirectory + "/Resources/Solicitud.pdf";               
                string fileNameExisting = strFullFilename;
                //string fileNameNew = @"C:\Users\Victor\Downloads\new" + filename + ".pdf";               
                string fileNameNew = @"" + outputhpath + "/" + nombre + ".pdf";

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
                                form.SetField(fieldKey, gActual);
                                break;
                            case (2):
                                form.SetField(fieldKey, newGrado);
                                break;
                            case (3):
                                form.SetField(fieldKey, parciales);
                                break;
                            case (4):
                                form.SetField(fieldKey, nombre);
                                break;
                            case (5):
                                form.SetField(fieldKey, INFOMADE.fechaLarga(fNacimiento));
                                break;
                            case (6):
                                form.SetField(fieldKey, INFOMADE.calcular_edad(Convert.ToDateTime(fNacimiento)));
                                break;
                            case (7):
                                form.SetField(fieldKey, ocupacion);
                                break;
                            case (8):
                                form.SetField(fieldKey, INFOMADE.fechaLarga(fExamenAnterior));
                                break;
                            case (9):
                                form.SetField(fieldKey, INFOMADE.fechaLarga(f_Ingreso));
                                break;
                            case (10):
                                form.SetField(fieldKey, comentarios);
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

        private void frm_CintasNegras_Load(object sender, EventArgs e)
        {
            cb_GradoActual.Text = "IEBY DAN/POOM";
            nud_Parciales.Value = 1;
        }
    }
}
