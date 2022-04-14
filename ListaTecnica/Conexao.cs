
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTecnica {
    public class Conexao {

        string strConec = @"Data Source=DSK83CWB92\SQLEXPRESS;Initial Catalog=DBListaTecnica;Integrated Security=True";
        public SqlConnection con = null;

        public void AbrirConexao() {
			try {
                con = new SqlConnection(strConec);
                con.Open();
			}
			catch (Exception ex) {

				throw ex;
			}
        }

        public void FecharConexao() {
            try {
                con = new SqlConnection(strConec);
                con.Close();
            }
            catch (Exception ex) {

                throw ex;
            }
        }


    }
}
