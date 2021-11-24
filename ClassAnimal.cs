using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projeto
{
    class ClassAnimal
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

    }
}
