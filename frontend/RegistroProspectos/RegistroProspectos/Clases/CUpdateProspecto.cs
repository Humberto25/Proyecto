using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroProspectos.Clases
{
    public class CUpdateProspecto
    {
        public int updateProspecto(int nId,string sEstatus, string sObservaciones)
        {
            try
            {
                string queryProspectos = "spUpdatePromotores @id,@estatus,@observaciones";
               
                using (SqlConnection cn = GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(queryProspectos, cn);
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = nId;
                    cmd.Parameters.Add("@estatus", SqlDbType.VarChar).Value = sEstatus;
                    cmd.Parameters.Add("@observaciones", SqlDbType.VarChar).Value = sObservaciones;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Atencion");
                return 0;
            }
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data source=localhost;Database=Promotores;Integrated Security=true;");
        }
    }
}
