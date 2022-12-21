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
    public class acoesVETVet
    {
        ConexaoVET con = new ConexaoVET();

        public void inserirVet(ModelVETVet cm)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tbveterinario values(default, @nomeVet)", con.MyConectarBD());

            cmd.Parameters.Add("@nomeVet", MySqlDbType.VarChar).Value = cm.nomeVet;
            cmd.ExecuteNonQuery();
            con.MyDesconectarBD();
        }

        public List<ModelVETVet> GetVet()
        {
            List<ModelVETVet> VetList = new List<ModelVETVet>();

            MySqlCommand cmd = new MySqlCommand("select * from tbveterinario", con.MyConectarBD());
            MySqlDataAdapter sd = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sd.Fill(dt);
            con.MyDesconectarBD();

            foreach (DataRow dr in dt.Rows)
            {
                VetList.Add(
                    new ModelVETVet
                    {
                        codVet = Convert.ToString(dr["codVet"]),
                        nomeVet = Convert.ToString(dr["nomeVet"]),
                    });
            }
            return VetList;
        }

        public bool DeleteVet(int id)
        {
            MySqlCommand cmd = new MySqlCommand("delete from tbveterinario where codVet=@id", con.MyConectarBD());

            cmd.Parameters.AddWithValue("@id", id);

            int i = cmd.ExecuteNonQuery();
            con.MyDesconectarBD();

            if (i >= 1)
                return true;
            else
                return false;
        }

        public bool atualizaVet(ModelVETVet cm)
        {
            MySqlCommand cmd = new MySqlCommand("update tbveterinario set nomeVet=@nomeVet where codVet=@cod", con.MyConectarBD());


            cmd.Parameters.AddWithValue("@nomeVet", cm.nomeVet);
            cmd.Parameters.AddWithValue("@cod", cm.codVet);


            int i = cmd.ExecuteNonQuery();
            con.MyDesconectarBD();

            if (i >= 1)
                return true;
            else
                return false;
        }
    }
}