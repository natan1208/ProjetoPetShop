using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projeto
{
    class PetCli
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string  endereco { get; set; }
        public string  cidade { get; set; }
        public string celular { get; set; }
        public string  email { get; set; }
        public string data_nascimento{ get; set; }


        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Programas\\ProjetoPetshop\\Projeto\\dbPetshop.mdf;Integrated Security=True");

        public void InserirCli(string nome, string endereco, string cidade,string celular, string email, string data_nascimento)
        {
            string sql = "INSERT INTO Clientes(nome,endereco,cidade,celular,email,data_nascimento) VALUES ('" + nome + "','" + endereco + "','" + cidade + "','" + celular+ "','" + email + "','" + data_nascimento + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public List<PetCli> listacli()
        {
            List<PetCli> li = new List<PetCli>();
            string sql = "SELECT * FROM Clientes";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PetCli f = new PetCli();
                f.Id = Convert.ToInt32(dr["Id"]);
                f.nome = dr["nome"].ToString();
                f.endereco = dr["endereco"].ToString();
                f.cidade = dr["cidade"].ToString();
                f.celular = dr["celular"].ToString();
                f.email= dr["email"].ToString();
                f.data_nascimento = dr["data_nascimento"].ToString();
                li.Add(f);
            }
            dr.Close();
            con.Close();
            return li;
        }

        public void ExcluirCli(int id)
        {
            string sql = "DELETE FROM Clientes WHERE Id = '" + id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void LocalizaCli(int id)
        {
            con.Open();
            string sql = "SELECT * FROM Clientes WHERE Id = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nome = dr["nome"].ToString();
                endereco = dr["cpf"].ToString();
                cidade = dr["cidade"].ToString();
                celular = dr["celular"].ToString();
                email = dr["email"].ToString();
                data_nascimento = dr["data_nascimento"].ToString();
            }
            dr.Close();
            con.Close();
        }
        public void AtualizaCli(int id,string nome, string endereco, string cidade, string celular, string email, string data_nascimento)
        {
            string sql = "UPDATE Clientes SET nome='" + nome + "',endereco='" + endereco+ "',cidade='" + cidade + "',celular='" + celular +"' email='"+ email+"',data_nascimento='" + data_nascimento +"' WHERE Id='"+ id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
