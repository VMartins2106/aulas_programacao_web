using MySql.Data.MySqlClient;
using ProjetoProduto.Dados._2610;
using ProjetoProduto.Models._2610;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjetoProduto.Acoes._2610
{
    public class acoesVETAnimal
    {
        ConexaoVET con = new ConexaoVET();

        public void inserirAnimal(ModelVETAnimal cm)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tbanimal values(default, @nomeAnimal, @fotoAnimal, @fkcodtipoanimal, @fkcodcliente)", con.MyConectarBD());

            cmd.Parameters.Add("@nomeAnimal", MySqlDbType.VarChar).Value = cm.nomeAnimal;
            cmd.Parameters.Add("@fotoAnimal", MySqlDbType.VarChar).Value = cm.fotoAnimal;
            cmd.Parameters.Add("@fkcodtipoanimal", MySqlDbType.VarChar).Value = cm.fkcodtipoanimal;
            cmd.Parameters.Add("@fkcodcliente", MySqlDbType.VarChar).Value = cm.fkcodcliente;
            cmd.ExecuteNonQuery();
            con.MyDesconectarBD();
        }

        public List<ModelVETAnimal> GetAnimal()
        {
            List<ModelVETAnimal> AnimalList = new List<ModelVETAnimal>();

            MySqlCommand cmd = new MySqlCommand("select * from tbanimal", con.MyConectarBD());
            MySqlDataAdapter sd = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sd.Fill(dt);
            con.MyDesconectarBD();

            foreach (DataRow dr in dt.Rows)
            {
                AnimalList.Add(
                    new ModelVETAnimal
                    {
                        codAnimal = Convert.ToString(dr["codAnimal"]),
                        nomeAnimal = Convert.ToString(dr["nomeAnimal"]),
                        fotoAnimal = Convert.ToString(dr["fotoAnimal"]),
                        fkcodtipoanimal = Convert.ToString(dr["fkcodtipoanimal"]),
                        fkcodcliente = Convert.ToString(dr["fkcodcliente"]),
                    });
            }
            return AnimalList;
        }

        public bool DeleteAnimal(int id)
        {
            MySqlCommand cmd = new MySqlCommand("delete from tbanimal where codAnimal=@id", con.MyConectarBD());

            cmd.Parameters.AddWithValue("@id", id);

            int i = cmd.ExecuteNonQuery();
            con.MyDesconectarBD();

            if (i >= 1)
                return true;
            else
                return false;
        }

        public bool atualizaAnimal(ModelVETAnimal cm)
        {
            MySqlCommand cmd = new MySqlCommand("update tbanimal set nomeAnimal=@nomeanimal where codAnimal=@cod", con.MyConectarBD());


            cmd.Parameters.AddWithValue("@nomeanimal", cm.nomeAnimal);
            cmd.Parameters.AddWithValue("@cod", cm.codAnimal);


            int i = cmd.ExecuteNonQuery();
            con.MyDesconectarBD();

            if (i >= 1)
                return true;
            else
                return false;
        }
    }
}