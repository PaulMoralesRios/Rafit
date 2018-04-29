using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Reflection;
using System.Windows.Forms;



namespace RafitNewFace
{
    class Conexion
    {
        public SqlConnection oCon = new SqlConnection();
        public SqlCommand oComando = new SqlCommand();


        string Servidor = @".\SQLEXPRESS;";
        public String Database = "Datarafit;";


        public void Conector()
        {
            try
            {
                if (ConnectionState.Closed == oCon.State)
                {

                    oCon.ConnectionString = "Data Source=" + Servidor
                   + "Initial catalog =" + Database + "User ID=sa;Password=Ashleylove2016;";
                

                    try
                    {
                        oCon.Open();

                    }
                    catch 
                    {
                        throw;

                    }

                    

                }
            }
            catch (SqlException Ex) { MessageBox.Show("Error: " + Ex + "\n Datos de Conexion: " + oCon.ConnectionString); }
        }

        //ADO.net

        private object missing = Missing.Value;

        public class Item
        {
            public string Key { get; set; }
            public string Value { get; set; }
        }


        public void CargarCombo(ComboBox CBBOX, String Procedure, String Mostrar,String Mostrar2, String Valor)
        {
            this.Conector();

            try
            {
                SqlCommand Comando = new SqlCommand(Procedure, this.oCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlDataReader DataReader = Comando.ExecuteReader();
                List<Item> listItems = new List<Item>();
                while (DataReader.Read())
                {
                    Item item = new Item();
                    if (Mostrar2 != "") { 
                    item.Value = DataReader[Mostrar].ToString()+" "+DataReader[Mostrar2].ToString();
                    item.Key = DataReader[Valor].ToString();
                    listItems.Add(item);
                    }
                    else { 
                    item.Value = DataReader[Mostrar].ToString();
                    item.Key = DataReader[Valor].ToString();
                    listItems.Add(item);
                    }
                }

                DataReader.Close();
                CBBOX.DisplayMember = "Value";
                CBBOX.ValueMember = "Key";
                CBBOX.DataSource = listItems;

            }

            catch (SqlException ex) { MessageBox.Show(ex.Message); }

        }



        public void ReiniciarCampos(GroupBox grp)
        {

            foreach (Control obj in grp.Controls)
            {
                switch (obj.GetType().ToString())
                {
                    case "System.Windows.Forms.TextBox":
                        (obj as TextBox).Text = "";
                        break;
                    case "System.Windows.Forms.ComboBox":
                        (obj as ComboBox).SelectedIndex = -1;
                        break;
                }
            }
        }

        public int EjecutarProcedure(String Procedure, string[] NombreParametro, string[] ValorParametro)
        {
            int Resultado = 0;
            this.Conector();
            SqlCommand Comando = new SqlCommand(Procedure, this.oCon);
            Comando.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < NombreParametro.Length; i++)
            {
                Comando.Parameters.AddWithValue(NombreParametro[i], ValorParametro[i]);
            }

            try
            {
                Resultado = Comando.ExecuteNonQuery();
              
            }
            catch (SqlException ex) { MessageBox.Show("El Error Es el Siguiente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); };
            return Resultado;
        }

        //Especializado para insertar Imagenes
        public int InsertarconImagen(String Procedure, string[] NombreParametro, string[] ValorParametro, string image, byte[] Foto)
        {
            this.Conector();
            int Resultado = 0;
            //SqlDataReader Data;
            SqlCommand Comando = new SqlCommand(Procedure, this.oCon);
            Comando.CommandType = CommandType.StoredProcedure;

            //Recolecta de Datos
            for (int i = 0; i < NombreParametro.Length; i++)
            {
                Comando.Parameters.AddWithValue(NombreParametro[i], ValorParametro[i]);
            }


            Comando.Parameters.AddWithValue(image, Foto);

            try
            {
                Resultado = Comando.ExecuteNonQuery();

            }
            catch (SqlException ex) { MessageBox.Show("El Error Es el Siguiente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
           
            return Resultado;
            

        }


        public void CargarComboConParametro(ComboBox CBBOX, String Procedure, int Valor_Depart, String Mostrar, String Valor)
        {
            this.Conector();
            SqlCommand Comando = new SqlCommand(Procedure, this.oCon);
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Iddepart", Valor_Depart);
            SqlDataReader DataReader = Comando.ExecuteReader();

            List<Item> listItems = new List<Item>();
            while (DataReader.Read())
            {
                Item item = new Item();

                item.Value = DataReader[Mostrar].ToString();
                item.Key = DataReader[Valor].ToString();

                listItems.Add(item);
            }

            DataReader.Close();
            CBBOX.DisplayMember = "Value";
            CBBOX.ValueMember = "Key";
            CBBOX.DataSource = listItems;
        }


        public SqlDataReader ProcedureObtenerDatos(String Procedure, string[] NombreParametro, string[] ValorParametro)
        {
            this.Conector();
            SqlDataReader DataReader;
            SqlCommand Comando = new SqlCommand(Procedure, this.oCon);
            Comando.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < NombreParametro.Length; i++)
            {
                Comando.Parameters.AddWithValue(NombreParametro[i], ValorParametro[i]);
            }
            DataReader = Comando.ExecuteReader();
            
            return DataReader;
            DataReader.Close();

        }


        public void LLenarDataGrid(String Procedure, DataGridView GridView, String[] NombreParametro, String[] ValorParametro)
        {   //Retirado para Pruebas
            //string[] NombreParametro, string[] ValorParametro;

            this.Conector();
            DataTable Table;
            SqlDataAdapter Adaptar;
            SqlCommand Comando = new SqlCommand(Procedure, this.oCon);
            Comando.CommandType = CommandType.StoredProcedure;
            Adaptar = new SqlDataAdapter(Comando);
            Table = new DataTable();
            for (int i = 0; i < NombreParametro.Length; i++)
            {
                Comando.Parameters.AddWithValue(NombreParametro[i], ValorParametro[i]);
            }
            try
            {
                Adaptar.Fill(Table);
                GridView.DataSource = Table;
                GridView.AutoGenerateColumns = false;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public int ValidarDatos(String Procedure, string NombreParametro, string ValorParametro)
        {
            this.Conector();
            //SqlDataReader DataReader;
            SqlCommand Comando = new SqlCommand(Procedure, this.oCon);
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue(NombreParametro, ValorParametro);
            int Rows;
            Rows = Convert.ToInt32(Comando.ExecuteScalar());
            return Rows;
        }


  


        public void CargarBD(ListBox List, String sql, String mostrar)
        {
            this.Conector();
            DataTable Lista = new DataTable();
            SqlDataAdapter adaptar = new SqlDataAdapter(sql, this.oCon);
            adaptar.Fill(Lista);
            if (Lista.Rows.Count == 0)
            {
                List.Text = "No Hay Datos Creados";
            }
            else
            {

                List.DataSource = Lista;
                List.DisplayMember = mostrar;
            }

        }

        public SqlDataReader ObtenerDatosSinParametros(String Procedure)
        {

            this.Conector();
            SqlDataReader DataReader;

            SqlCommand Comando = new SqlCommand(Procedure, this.oCon);
            Comando.CommandType = CommandType.StoredProcedure;
            DataReader = Comando.ExecuteReader();
            return DataReader;
            
        }

        public bool ProbarConexion()
        {
            WebRequest Peticion = default(WebRequest);
            HttpWebResponse Respuesta = default(HttpWebResponse);
            try
            {
                Peticion = WebRequest.Create("https://www.google.com.co") as System.Net.HttpWebRequest;
                Respuesta = Peticion.GetResponse() as System.Net.HttpWebResponse;
                return true;
            }
            catch (System.Net.WebException ex)
            {
                if (ex.Status == WebExceptionStatus.NameResolutionFailure)
                {
                    MessageBox.Show("No Se Encontro Una Conexion Establecida", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return false;
                }
                return false;
            }


        }

        // Metodo Nuevo
        public void CargarChecklist(CheckedListBox CBBOX, String Procedure, String Mostrar, String Mostrar2, String Mostrar3, String Valor)
        {
            this.Conector();

            try
            {
                SqlCommand Comando = new SqlCommand(Procedure, this.oCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlDataReader DataReader = Comando.ExecuteReader();
                List<Item> listItems = new List<Item>();
                while (DataReader.Read())
                {
                    Item item = new Item();
                    item.Value = DataReader[Mostrar].ToString() +" "+ DataReader[Mostrar2].ToString() + " (" + DataReader[Mostrar3].ToString() + ")";
                    item.Key = DataReader[Valor].ToString();
                    listItems.Add(item);
                }

                DataReader.Close();
                CBBOX.DataSource = listItems;
                CBBOX.DisplayMember = "Value";
                CBBOX.ValueMember = "Key";


            }

            catch (SqlException ex) { MessageBox.Show(ex.Message); }

        }


    }
}
