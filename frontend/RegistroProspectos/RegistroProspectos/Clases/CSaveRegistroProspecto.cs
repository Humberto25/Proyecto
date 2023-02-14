using RegistroProspectos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroProspectos.Clases
{
    public class CSaveRegistroProspecto
    {
        public int saveProspecto(MdlRegistroProspectos infoProspecto,List<MdlRegistroDocumentos> docs)
        {
            try
            {
                string queryProspectos = "dbo.spInsertPromotores @nombreProspecto,@primerAp,@segundoAp,@calle,@numero,@colonia,@codigoPostal,@telefono,@rfc,@estatus";
                string queryDocs = "dbo.spInsert_Documentos @idProspecto,@documento,@extension,@nombreDocumento";
                using (SqlConnection cn = GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(queryProspectos, cn);
                    cmd.Parameters.Add("@nombreProspecto", SqlDbType.VarChar).Value = infoProspecto.nombreProspecto;
                    cmd.Parameters.Add("@primerAp", SqlDbType.VarChar).Value = infoProspecto.primerAp;
                    cmd.Parameters.Add("@segundoAp", SqlDbType.VarChar).Value = infoProspecto.segundoAp;
                    cmd.Parameters.Add("@calle", SqlDbType.VarChar).Value = infoProspecto.calle;
                    cmd.Parameters.Add("@numero", SqlDbType.VarChar).Value = infoProspecto.numero;
                    cmd.Parameters.Add("@colonia", SqlDbType.VarChar).Value = infoProspecto.colonia;
                    cmd.Parameters.Add("@codigoPostal", SqlDbType.Int).Value = infoProspecto.codigoPostal;
                    cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = infoProspecto.telefono;
                    cmd.Parameters.Add("@rfc", SqlDbType.VarChar).Value = infoProspecto.rfc;
                    cmd.Parameters.Add("@estatus", SqlDbType.VarChar).Value = infoProspecto.estatus;
                    cn.Open();
                    int id = 0;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id = Convert.ToInt32(String.Format("{0}", reader[0]));
                        }
                    }
                    foreach (MdlRegistroDocumentos item in docs)
                    {
                        cmd = new SqlCommand(queryDocs, cn);
                        cmd.Parameters.Add("@idProspecto", SqlDbType.Int).Value = id;
                        cmd.Parameters.Add("@documento", SqlDbType.VarBinary).Value = item.documento;
                        cmd.Parameters.Add("@extension", SqlDbType.VarChar).Value = item.extension;
                        cmd.Parameters.Add("@nombreDocumento", SqlDbType.VarChar).Value = item.nombreDocumento;
                        cmd.ExecuteNonQuery();
                    }
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
