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
    public class acoesCliente
    {
        Conexao con = new Conexao();

        public void inserirCliente(ModelCliente cm)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tbCliente values(default, @nomeCliente, @usuario, @senha)", con.MyConectarBD());

            cmd.Parameters.Add("@nomeCliente", MySqlDbType.VarChar).Value = cm.nomeCli;
            cmd.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = cm.usuario;
            cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = cm.senha;
            cmd.ExecuteNonQuery();
            con.MyDesconectarBD();
        }

        public List<ModelCliente> GetCliente()
        {
            List<ModelCliente> ClienteList = new List<ModelCliente>();

            MySqlCommand cmd = new MySqlCommand("select * from tbCliente", con.MyConectarBD());
            MySqlDataAdapter sd = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sd.Fill(dt);
            con.MyDesconectarBD();

            foreach (DataRow dr in dt.Rows)
            {
                ClienteList.Add(
                    new ModelCliente
                    {
                        codCli = Convert.ToString(dr["codCli"]),
                        nomeCli = Convert.ToString(dr["nomeCli"]),
                        usuario = Convert.ToString(dr["usuario"]),
                        senha = Convert.ToString(dr["senha"]),
                    });
            }
            return ClienteList;
        }

        public bool DeleteCliente(int id)
        {
            MySqlCommand cmd = new MySqlCommand("delete from tbCliente where codCli=@id", con.MyConectarBD());

            cmd.Parameters.AddWithValue("@id", id);

            int i = cmd.ExecuteNonQuery();
            con.MyDesconectarBD();

            if (i >= 1)
                return true;
            else
                return false;
        }

        public bool atualizaCliente(ModelCliente cm)
        {
            MySqlCommand cmd = new MySqlCommand("update tbCliente set nomeCli=@nomeCli, usuario=@usuario, senha=@senha where codCli=@cod", con.MyConectarBD());


            cmd.Parameters.AddWithValue("@nomeCli", cm.nomeCli);
            cmd.Parameters.AddWithValue("@usuario", cm.usuario);
            cmd.Parameters.AddWithValue("@senha", cm.senha);
            cmd.Parameters.AddWithValue("@cod", cm.codCli);


            int i = cmd.ExecuteNonQuery();
            con.MyDesconectarBD();

            if (i >= 1)
                return true;
            else
                return false;
        }

    }
}