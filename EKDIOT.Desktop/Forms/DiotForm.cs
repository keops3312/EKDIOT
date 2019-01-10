using DevComponents.DotNetBar;
using EKDIOT.LCommon.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EKDIOT.Desktop.Forms
{
    public partial class DiotForm : Office2007Form
    {


        string conexion;
        string letra;
        string NoEmpresa;




        diotClass diot;
        DataTable Empresas;










        #region Methods (Metodos)
        
        
        //Initialize
        public DiotForm()
        {
            InitializeComponent();
            diot = new diotClass();
            Empresas = new DataTable();
        }
        //Charge list tables
        private void LoadList()
        {
            if (!string.IsNullOrEmpty(cmbEmpresas.SelectedValue.ToString()))
            {

                try
                {
                    ClearList();

                    letra = cmbEmpresas.SelectedValue.ToString();
                    NoEmpresa = Convert.ToString (diot.EmpresaId(letra, conexion));

                    DataTable list = new DataTable();
                    list = diot.ToListDTB(letra.Trim(), conexion);

                    listEjercicios.Items.Clear();

                    foreach (DataRow item in list.Rows)
                    {
                        listEjercicios.Items.Add(item[0].ToString(), 1);
                    }
                }
                catch (Exception ex)
                {

                    Console.Write(ex.Message);
                }

            }
        }


        //Clear ListEjercicios
        private void ClearList()
        {
            if (listEjercicios.Items.Count > 0)
            {
                for (int i = listEjercicios.Items.Count - 1; i >= 0; i--)
                {
                    listEjercicios.Items.RemoveAt(i);

                }



            }
        }

        #endregion


        #region Events (Eventos)

        private void DiotForm_Load(object sender, EventArgs e)
        {

            conexion = diot.CheckDataConection();
            Empresas = diot.Empresas(conexion);
            cmbEmpresas.DataSource = Empresas;
            cmbEmpresas.DisplayMember = "Empresa";
            cmbEmpresas.ValueMember = "Letra";

            listEjercicios.View = View.Details;
            listEjercicios.MultiSelect = false;
            listEjercicios.Columns.Add("Ejercicio", 150);
            listEjercicios.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listEjercicios.SmallImageList = imageList1;

        }
        private void cmbEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {

            LoadList();

           
        }





        #endregion
      
        private void listEjercicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEjercicio.Text = "";

            // Added to prevent errors when nothing was selected
            if (listEjercicios.SelectedItems.Count > 0)
            {

                ListViewItem listitem = listEjercicios.SelectedItems[0];
                txtEjercicio.Text = listitem.Text;



            }


        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            MessageBoxEx.EnableGlass = false;

           


            DialogResult result = MessageBoxEx.Show("¿Generar Diot del Mes?", "EKDIOT", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    {

                        BeginDiot();

                        break;
                    }
                case DialogResult.No:
                    {

                        break;
                    }
            }
        }

        private void BeginDiot()
        {
            DataTable resultados = new DataTable();
            resultados = diot.ToListPRV(txtEjercicio.Text, conexion, txtIVA.Text, NoEmpresa, txtEjercicio.Text.Substring(4, 3), txtEjercicio.Text.Substring(7, 4));


           dataGridViewX1.DataSource= diot.DIOT(resultados, txtEjercicio.Text, conexion, txtIVA.Text, NoEmpresa, txtEjercicio.Text.Substring(4, 3), txtEjercicio.Text.Substring(7, 4));


        }
    }
}
