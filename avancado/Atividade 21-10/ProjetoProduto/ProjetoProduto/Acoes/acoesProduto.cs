using MySql.Data.MySqlClient;
using ProjetoProduto.Dados;
using ProjetoProduto.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjetoProduto.Acoes
{
    public class acoesProduto
    {

        Conexao con = new Conexao();
        public void inserirProduto(ModelProduto cm)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tbProduto values(default, @NomeProd, @DescricaoProd, @precoProduto , @EstoqueProd, @imagemProduto)", con.MyConectarBD());

            cmd.Parameters.Add("@NomeProd", MySqlDbType.VarChar).Value = cm.NomeProd;
            cmd.Parameters.Add("@DescricaoProd", MySqlDbType.VarChar).Value = cm.DescricaoProd;
            cmd.Parameters.Add("@precoProduto", MySqlDbType.VarChar).Value = cm.PrecoProd;
            cmd.Parameters.Add("@EstoqueProd", MySqlDbType.VarChar).Value = cm.EstoqueProd;
            cmd.Parameters.Add("@imagemProduto", MySqlDbType.VarChar).Value = cm.FotoProd;
            cmd.ExecuteNonQuery();
            con.MyDesconectarBD();
        }



        public List<ModelProduto> GetProd()
        {
            List<ModelProduto> Produtoslist = new List<ModelProduto>();

            MySqlCommand cmd = new MySqlCommand("select * from tbProduto", con.MyConectarBD());
            MySqlDataAdapter sd = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sd.Fill(dt);
            con.MyDesconectarBD();

            foreach (DataRow dr in dt.Rows)
            {
                Produtoslist.Add(
                    new ModelProduto
                    {
                        codProd = Convert.ToString(dr["codProd"]),
                        NomeProd = Convert.ToString(dr["NomeProd"]),
                        DescricaoProd = Convert.ToString(dr["descProduto"]),
                        PrecoProd = Convert.ToString(dr["precoProd"]),
                        EstoqueProd = Convert.ToString(dr["estoque"]),
                        FotoProd = Convert.ToString(dr["imagemProd"])
                    });
            }
            return Produtoslist;
        }

    }
}