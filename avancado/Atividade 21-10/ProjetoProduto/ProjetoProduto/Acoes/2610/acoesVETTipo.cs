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
    public class acoesVETTipo
    {
        ConexaoVET con = new ConexaoVET();

        public void inserirTipo(ModelVETTipo cm)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tbtipoanimal values(default, @tipoAnimal)", con.MyConectarBD());

            cmd.Parameters.Add("@tipoAnimal", MySqlDbType.VarChar).Value = cm.tipoAnimal;
            cmd.ExecuteNonQuery();
            con.MyDesconectarBD();
        }

        public List<ModelVETTipo> GetTipo()
        {
            List<ModelVETTipo> TipoList = new List<ModelVETTipo>();

            MySqlCommand cmd = new MySqlCommand("select * from tbtipoanimal", con.MyConectarBD());
            MySqlDataAdapter sd = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sd.Fill(dt);
            con.MyDesconectarBD();

            foreach (DataRow dr in dt.Rows)
            {
                TipoList.Add(
                    new ModelVETTipo
                    {
                        codTipoAnimal = Convert.ToString(dr["codTipoAnimal"]),
                        tipoAnimal = Convert.ToString(dr["tipoAnimal"]),
                    });
            }
            return TipoList;
        }

        public bool DeleteTipo(int id)
        {
            MySqlCommand cmd = new MySqlCommand("delete from tbtipoanimal where codTipoAnimal=@id", con.MyConectarBD());

            cmd.Parameters.AddWithValue("@id", id);

            int i = cmd.ExecuteNonQuery();
            con.MyDesconectarBD();

            if (i >= 1)
                return true;
            else
                return false;
        }

        public bool atualizaTipo(ModelVETTipo cm)
        {
            MySqlCommand cmd = new MySqlCommand("update tbtipoanimal set tipoAnimal=@tipoAnimal where codTipoAnimal=@cod", con.MyConectarBD());


            cmd.Parameters.AddWithValue("@tipoAnimal", cm.tipoAnimal);
            cmd.Parameters.AddWithValue("@cod", cm.codTipoAnimal);


            int i = cmd.ExecuteNonQuery();
            con.MyDesconectarBD();

            if (i >= 1)
                return true;
            else
                return false;
        }
    }
}