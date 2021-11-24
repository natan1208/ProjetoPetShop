using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projeto
{
    class PetAnimal
    {
        public int id { get; set; }
        public int id_proprietario { get; set; }
        public string nome { get; set; }
        public string raca { get; set; }
        public string data_nascimento { get; set; }
        public string especie { get; set; }
        public string pelagem { get; set; }
        public string peso { get; set; }
        public string porte { get; set; }
        public string sexo { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Programas\\ProjetoPetshop\\Projeto\\dbPetshop.mdf;Integrated Security=True");

        public void InserirAnimal(string nome,string raca,string data_nascimento,string especie,string pelagem,string peso,string porte,string sexo)
        {
            string sql = "INSERT INTO Animais(nome,raca,data_nascimento,especie,pelagem,peso,porte,sexo) VALUES ('" + nome + "','" + raca+ "','" + data_nascimento+ "','" + especie + "','" + pelagem+ "','" + peso + "',,'" + porte + "''" + sexo+ "')";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public List<PetAnimal> listaanimal()
        {
            List<PetAnimal> li = new List<PetAnimal>();
            string sql = "SELECT * FROM Animais";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PetAnimal f = new PetAnimal();
                f.id = Convert.ToInt32(dr["Id"]);
                f.id_proprietario = Convert.ToInt32(dr["id_proprietario"]);
                f.nome = dr["nome"].ToString();
                f.raca = dr["raca"].ToString();
                f.data_nascimento = dr["data_nascimento"].ToString();
                f.especie = dr["especie"].ToString();
                f.pelagem = dr["pelagem"].ToString();
                f.peso = dr["peso"].ToString();
                f.porte = dr["porte"].ToString();
                f.sexo = dr["sexo"].ToString();
                li.Add(f);
            }
            dr.Close();
            con.Close();
            return li;
        }
        public void ExcluirAnimal(int id)
        {
            string sql = "DELETE FROM Clientes WHERE Id = '" + id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void LocalizaAnimal(int id)
        {
            con.Open();
            string sql = "SELECT * FROM Clientes WHERE Id = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nome = dr["nome"].ToString();
                raca = dr["raca"].ToString();
                data_nascimento = dr["data_nascimento"].ToString();
                especie = dr["especie"].ToString();
                pelagem = dr["pelagem"].ToString();
                peso = dr["peso"].ToString();
                porte = dr["porte"].ToString();
                sexo = dr["sexo"].ToString();
            }
            dr.Close();
            con.Close();
        }

        public void AtualizaAnimal(int id,int id_proprietario,string nome, string raca, string data_nascimento, string especie, string pelagem, string peso, string porte, string sexo)
        {
            string sql = "UPDATE Clientes SET nome='" + nome + "',raca='" + raca+ "',data_nascimento='" + data_nascimento+ "',especie='" + especie+ "' ,pelagem='" + pelagem + "',peso='" + peso + "',porte='" + porte+ "',sexo='" + sexo+ "' WHERE Id='" + id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}
