using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projeto
{
    class PetServ
    {
        public int id { get; set; }
        public string  servico { get; set; }
        public string preco { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Programas\\ProjetoPetshop\\Projeto\\dbPetshop.mdf;Integrated Security=True");


        public void LocalizaServ(int id) 
        {
            con.Open();
            string sql = "SELECT * FROM Servicos  WHERE Id = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                servico = dr["servico"].ToString();
                preco = dr["preco"].ToString();
            }
            dr.Close();
            con.Close();
        }

        public void InserirServ(string servico,string preco)
        {
            string sql = "INSERT INTO Servicos(servico,preco) VALUES ('"+servico+"','"+preco+"')";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void AtualizaServ(int id, string servico, string preco)
        {
            string sql = "UPDATE Servicos SET servico='" + servico + "',preco='" + preco + "' WHERE Id ='"+id+"'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ExcluirServ(int id)
        {
            string sql = "DELETE FROM Servicos WHERE Id ='" + id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public List<PetServ>listaservicos()
        {
            List<PetServ> li = new List<PetServ>();
            string sql = "SELECT * FROM Servicos";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql,con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PetServ petserv = new PetServ();
                petserv.id = Convert.ToInt32(dr["id"]);
                petserv.servico = dr["servico"].ToString();
                petserv.preco = dr["preco"].ToString();
            }
            dr.Close();
            con.Close();
            return li;
        }

    }
}
