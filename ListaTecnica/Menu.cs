using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ListaTecnica
{
    public partial class frmListaTecnica : Form
    {




        public frmListaTecnica()
        {
            InitializeComponent();
        }


        private void frmListaTecnica_Load(object sender, EventArgs e)
        {
            txtTiragem.Enabled = false;
            cbVersao.Enabled = false;
            cbTipoMaterial.Enabled = false;
            txtElementos.Enabled = false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=DSK83CWB92\SQLEXPRESS;Initial Catalog=DBListaTecnica;User ID=sa;Password=x";
            SqlConnection con = new SqlConnection(connectionString);

            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "INSERT INTO ciclos (ciclo) VALUES(@CICLO)";
                cmd.Parameters.AddWithValue("ciclo", cbCiclo.Text);


                con.Open();
                cmd.ExecuteNonQuery();

                grid.Rows.Clear();
                txtTiragem.Enabled = true;
                cbVersao.Enabled = true;
                cbTipoMaterial.Enabled = true;
                txtElementos.Enabled = true;


                string ciclo = cbCiclo.Text;

                string selectAll = "SELECT * FROM ciclos WHERE ciclo = '" + ciclo + "'";

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(selectAll, connectionString);

                //adaptador preenchendo o DataTable
                adapter.Fill(dt);

                foreach (DataRow linha in dt.Rows) //para cada linha do DataTable..
                {
                    grid.Rows.Add(linha.ItemArray);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }


        }

        private void btnAdicionarVersao_Click(object sender, EventArgs e)
        {
            grid.Enabled = true;

            string connectionString = @"Data Source=DSK83CWB92\SQLEXPRESS;Initial Catalog=DBListaTecnica;User ID=sa;Password=x";
            SqlConnection con = new SqlConnection(connectionString);

            try
            {

                string id = grid[0, 0].Value.ToString();

                for (int i = 0; i < int.Parse(txtElementos.Text); i++)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();

                    cmd.CommandText = "INSERT INTO cadernos (caderno, qtd_pgs, tipo_papel, gramatura, tipo_material, versao, tiragem, bobina, id_ciclo) " +
                  "VALUES (NULL, NULL, NULL, NULL, @tipo_material, @versao, @tiragem, NULL, @id_ciclo)";


                    cmd.Parameters.AddWithValue("tipo_material", cbTipoMaterial.Text);
                    cmd.Parameters.AddWithValue("versao", cbVersao.Text);
                    cmd.Parameters.AddWithValue("tiragem", txtTiragem.Text);
                    cmd.Parameters.AddWithValue("id_ciclo", id);


                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                grid.Rows.Clear();
                string ciclo = cbCiclo.Text;
                string versao = cbVersao.Text;

                string selectAll = "SELECT B.id, C.ciclo, B.tiragem, B.tipo_material, B.versao, B.caderno, B.qtd_pgs, B.tipo_papel, B.gramatura, B.bobina FROM ciclos AS C " +
                    "INNER JOIN cadernos AS B " +
                    "ON C.id = B.id_ciclo " +
                    "WHERE C.ciclo = '" + ciclo + "' AND B.versao = '" + versao + "'";

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(selectAll, connectionString);

                //adaptador preenchendo o DataTable
                adapter.Fill(dt);

                foreach (DataRow linha in dt.Rows) //para cada linha do DataTable..
                {
                    grid.Rows.Add(linha.ItemArray);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection con;
            connectionString = @"Data Source=DSK83CWB92\SQLEXPRESS;Initial Catalog=DBListaTecnica;User ID=sa;Password=x";
            con = new SqlConnection(connectionString);


            try
            {
                grid.Rows.Clear();
                string ciclo = cbCicloPesquisa.Text;
                string versao = cbVersaoPesquisa.Text;
                string tipo = cbTipoMaterialPesquisa.Text;

                string selectAll = "SELECT B.id, C.ciclo, B.tiragem, B.tipo_material, B.versao, B.caderno, B.qtd_pgs, B.tipo_papel, B.gramatura, B.bobina " +
                    "FROM ciclos AS C " +
                    "INNER JOIN cadernos AS B " +
                    "ON C.id = B.id_ciclo " +
                    "WHERE C.ciclo = '" + ciclo + "' AND B.versao = '" + versao + "' AND B.tipo_material = '" + tipo + "'";

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(selectAll, connectionString);

                con.Open();

                //adaptador preenchendo o DataTable
                adapter.Fill(dt);

                foreach (DataRow linha in dt.Rows) //para cada linha do DataTable..
                {
                    grid.Rows.Add(linha.ItemArray);
                }

            }
            catch (Exception ex)
            {
                grid.Rows.Clear();
                MessageBox.Show(ex.Message);
            }
            finally
            {

                con.Close();
            }
            return;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DSK83CWB92\SQLEXPRESS;Initial Catalog=DBListaTecnica;User ID=sa;Password=x";
            SqlConnection con = new SqlConnection(connectionString);

            try
            {
               
                foreach (DataGridViewRow item in grid.Rows)
                {
                    
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();

                    string caderno = item.Cells[5].Value.ToString();
                    string paginas = item.Cells[6].Value.ToString();
                    string tipoPapel = item.Cells[7].Value.ToString();
                    string gramatura = item.Cells[8].Value.ToString();
                    string bobina = item.Cells[9].Value.ToString();
                    string id = item.Cells[0].Value.ToString();

                    cmd.CommandText = "UPDATE cadernos SET caderno = '" + caderno + "', qtd_pgs = " + paginas + ", tipo_papel = '" + tipoPapel + "', gramatura = '" + gramatura + "', bobina = " + bobina + " " +
                        "WHERE id = '" + id + "'";

                    cmd.ExecuteNonQuery();
                    con.Close();

                }

                MessageBox.Show("Registro inserido com sucesso!", "Lista técnica", MessageBoxButtons.OK, MessageBoxIcon.Information);

                grid.Enabled = false;
                cbVersao.Text = "";
                cbTipoMaterial.Text = "";
                txtTiragem.Text = "";
                txtElementos.Text = "";
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return;


        }


    }

}
