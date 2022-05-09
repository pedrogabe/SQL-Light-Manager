using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace DB
{
    public static class DBManager
    {
        public static string connString = "";
        
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connString);
        }

        private static SqlCommand GetCommand(in string query, in object[] parameters)
        {
            var cmd = new SqlCommand(query, GetConnection());
            AddParameters(ref cmd, parameters);
            return cmd;
        }

        public static void AddParameters(ref SqlCommand cmd, in object[] parameters)
        {
            int i = 0;
            foreach(string param in parameters)
            {
                cmd.Parameters.AddWithValue("@" + i, parameters[i]);
                i++;
            }
        }

        /// <summary>
        /// Ejecuta consultas en la base de datos.
        /// </summary>
        /// <param name="query">Consulta a la base de datos</param>
        /// <param name="parameters">Valores de los parámetros</param>
        /// <returns>DataSet con los resultados de la consulta o null falla la operación.</returns>
        public static DBResponse Query(string query, params object[] parameters)
        {
            try
            {
                var cmd = GetCommand(query, parameters);
                var adapter = new SqlDataAdapter(cmd);
                var ds = new DataSet();
                adapter.Fill(ds);
                return new DBResponse(ds);
            }
            catch (Exception ex)
            {
                return new DBResponse(ex.Message);
            }
        }


        /// <summary>
        /// Ejecuta operaciones en la base de datos que no sean de selección.
        /// </summary>
        /// <param name="query">Consulta a la base de datos</param>
        /// <param name="parameters">Valores de los parámetros</param>
        /// <returns>Cantidad de filas afectadas o null si falla la operación</returns>
        public static DBResponse NonQuery(string query, params object[] parameters)
        {
            try
            {
                var cmd = GetCommand(query, parameters);
                cmd.Connection.Open();
                int affected = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return new DBResponse(affected);                
            }
            catch(Exception ex)
            {
                return new DBResponse(ex.Message);
            }
        }
    }

    public class DBResponse
    {
        public bool Successful { get { return Error == null; }}
        public DataSet DataSet { get; private set; }
        public DataTableCollection Tables { get { return DataSet?.Tables; } }
        public bool HasTables { get { return Tables.Count > 0; } }
        public int AffectedRows { get; private set; }
        public string Error { get; private set; }

        public DBResponse(DataSet data)
        {
            DataSet = data;
            foreach(DataTable table in data.Tables)
            {
                AffectedRows += table.Rows.Count;
            }
        }
        public DBResponse(int affectedRows)
        {
            AffectedRows = affectedRows;
        }

        public DBResponse(string error)
        {
            Error = error;
        }
    }
}