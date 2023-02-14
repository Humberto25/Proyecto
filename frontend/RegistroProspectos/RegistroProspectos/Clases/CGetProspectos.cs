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
    public class CGetProspectos
    {
        
        public DataTable getProspectos()
        {
            DataTable dt = new DataTable();
            try 
            {
                using (SqlConnection cn = GetConnection())
                {
                    string queryGetProspectos = "select  id,nombreProspecto,primerAp,segundoAp,calle,numero,colonia,codigoPostal,telefono,rfc,estatus as Estatus,Observaciones FROM fnGetProspectos()";
                    SqlDataAdapter adp = new SqlDataAdapter(queryGetProspectos, cn);
                    adp.Fill(dt);
                    
                    return dt;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Atencion");
                return dt;
            }
        }
        public DataTable getDocumentos(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection cn = GetConnection())
                {
                    string queryGetProspectos = "SELECT id,idProspecto,documento,extension,nombreDocumento FROM dbo.fnGetDocumentos("+id+")";
                    SqlDataAdapter adp = new SqlDataAdapter(queryGetProspectos, cn);

                    adp.Fill(dt);

                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Atencion");
                return dt;
            }
        }
        public DataTable getProspectosEvaluar()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection cn = GetConnection())
                {
                    string queryGetProspectos = "select  id,nombreProspecto,primerAp,segundoAp,calle,numero,colonia,codigoPostal,telefono,rfc,estatus as Estatus,Observaciones FROM fnGetProspectosEvaluar()";
                    SqlDataAdapter adp = new SqlDataAdapter(queryGetProspectos, cn);
                    adp.Fill(dt);

                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Atencion");
                return dt;
            }
        }
        private SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data source=localhost;Database=Promotores;Integrated Security=true;");
        }
    }
}
