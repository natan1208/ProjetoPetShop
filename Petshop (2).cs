using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projeto
{
    class Petshop
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string celular { get; set; }
        public string genero { get; set; }
        public string data_admissao { get; set; }
        public string login { get; set; }
        public string senha { get; set; }


        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\ProjetoPetShop\\Projeto\\dbPetshop.mdf;Integrated Security=True");

        public void InserirFunc(string nome, string celular, string genero,  string data_admissao,string login, string senha)
        {
            string sql = "INSERT INTO Funcionarios(nome,celular,genero,data_admissao,login,senha) VALUES('" + nome + "','" + celular + "','" + genero + "','" + data_admissao + "','"+login+"','"+senha+"')";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void ExcluirFunc(int id)
        {
            string sql = "DELETE FROM Funcionarios WHERE Id = '" + id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void LocalizaFunc(int id)
        {
            con.Open();
            string sql = "SELECT * FROM Funcionarios WHERE Id = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nome = dr["nome"].ToString();
                celular = dr["celular"].ToString();
                genero = dr["genero"].ToString();
                data_admissao = dr["data_admissao"].ToString();
                login = dr["login"].ToString();
                senha = dr["senha"].ToString();
            }
            dr.Close();
            con.Close();
        }
        public void AtualizarFunc(int id,string nome, string celular, string genero, string data_admissao, string login, string senha)
        {
            
            string sql = "UPDATE Funcionarios SET nome='" + nome + "',genero='" + genero + "',data_admissao='" + data_admissao + "',login='"+login+"',senha='"+senha+"' WHERE Id='"+ id +"'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public List<Petshop> listafuncionario()
        {
            List<Petshop> li = new List<Petshop>();
            string sql = "SELECT * FROM Funcionarios";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Petshop f = new Petshop();
                f.Id = Convert.ToInt32(dr["Id"]);
                f.nome = dr["nome"].ToString();
                f.celular = dr["celular"].ToString();
                f.genero = dr["genero"].ToString();
                f.data_admissao = dr["data_admissao"].ToString();
                f.login = dr["login"].ToString();
                f.senha = dr["senha"].ToString();
                li.Add(f);
            }
            return li;
        }
        public int NFuncionario()
        {
            int total = 0;
            string sql = "SELECT COUNT(*) AS total FROM Funcionarios";
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                total = Convert.ToInt32(dr["total"]);
            }
            dr.Close();
            con.Close();
            return total;
        }
        
    }
}
