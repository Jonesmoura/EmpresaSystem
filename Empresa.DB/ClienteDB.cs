using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Empresa.Models;

namespace Empresa.DB
{
    public class ClienteDB
    {
        public void Incluir(cliente cliente)
        {
            string sql = "INSERT INTO Cliente(Id, Nome, Email, Telefone) Values(@Id, @Nome, @Email, @Telefone)";
            var cn = new SqlConnection(DB.Connection);
            var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@Id", cliente.Id);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
            cmd.Parameters.AddWithValue("@Email", cliente.Email);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void Alterar(cliente cliente)
        {
            string sql = @"UPDATE Cliente SET Nome=@Nome, Telefone=@Telefone, Email=@Email WHERE Id=@Id";
            var cn = new SqlConnection(DB.Connection);
            var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@Id", cliente.Id);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
            cmd.Parameters.AddWithValue("@Email", cliente.Email);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void Excluir(int Id)
        {
            string sql = @"DELETE Cliente WHERE Id=@Id";
            var cn = new SqlConnection(DB.Connection);
            var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@Id", Id);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public cliente ObterPorId(int Id)
        {
            string sql = @"SELECT Id, Nome, Telefone, Email FROM Cliente WHERE Id=@Id";
            var cn = new SqlConnection(DB.Connection);
            var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@Id", Id);

            cliente cli = null;
            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                cli = new cliente();
                cli.Id = Convert.ToInt32(reader["Id"]);
                cli.Nome = reader["Nome"].ToString();
                cli.Telefone = reader["Telefone"].ToString();
                cli.Email = reader["Email"].ToString();

            }
            reader.Close();
            cn.Close();

            return cli;
        }
        public List<cliente> Listar()
        {
            string sql = "SELECT Id, Nome, Telefone, Email FROM Cliente";
            var cn = new SqlConnection(DB.Connection);
            var cmd = new SqlCommand(sql, cn);

            List<cliente> lista = new List<cliente>();
            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var cliente = new cliente();
                cliente.Id = Convert.ToInt32(reader["id"]);
                cliente.Nome = reader["Nome"].ToString();
                cliente.Telefone = reader["Telefone"].ToString();
                cliente.Email = reader["Email"].ToString();

                lista.Add(cliente);
            }
            reader.Close();
            cn.Close();

            return lista;
        }




    }
}
