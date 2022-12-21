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
    public class acoesVETCliente
    {

        ConexaoVET con = new ConexaoVET();

        public void inserirCliente(ModelVETCliente cm)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tbcliente values(default, @nomeCliente, @telefone, @email)", con.MyConectarBD());

            cmd.Parameters.Add("@nomeCliente", MySqlDbType.VarChar).Value = cm.nomeCliente;
            cmd.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = cm.telefoneCliente;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = cm.emailCliente;
            cmd.ExecuteNonQuery();
            con.MyDesconectarBD();
        }

        public List<ModelVETCliente> GetCliente()
        {
            List<ModelVETCliente> ClienteList = new List<ModelVETCliente>();

            MySqlCommand cmd = new MySqlCommand("select * from tbcliente", con.MyConectarBD());
            MySqlDataAdapter sd = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sd.Fill(dt);
            con.MyDesconectarBD();

            foreach (DataRow dr in dt.Rows)
            {
                ClienteList.Add(
                    new ModelVETCliente
                    {
                        codCliente = Convert.ToString(dr["codCliente"]),
                        nomeCliente = Convert.ToString(dr["nomeCliente"]),
                        telefoneCliente = Convert.ToString(dr["telefoneCliente"]),
                        emailCliente = Convert.ToString(dr["emailCliente"]),
                    });
            }
            return ClienteList;
        }

        public bool DeleteCliente(int id)
        {
            MySqlCommand cmd = new MySqlCommand("delete from tbcliente where codCliente=@id", con.MyConectarBD());

            cmd.Parameters.AddWithValue("@id", id);

            int i = cmd.ExecuteNonQuery();
            con.MyDesconectarBD();

            if (i >= 1)
                return true;
            else
                return false;
        }

        public bool atualizaCliente(ModelVETCliente cm)
        {
            MySqlCommand cmd = new MySqlCommand("update tbcliente set nomeCliente=@nomeCliente, telefoneCliente=@telefone, emailCliente=@emailCliente where codCliente=@cod", con.MyConectarBD());


            cmd.Parameters.AddWithValue("@nomeCliente", cm.nomeCliente);
            cmd.Parameters.AddWithValue("@telefone", cm.telefoneCliente);
            cmd.Parameters.AddWithValue("@emailCliente", cm.emailCliente);
            cmd.Parameters.AddWithValue("@cod", cm.codCliente);


            int i = cmd.ExecuteNonQuery();
            con.MyDesconectarBD();

            if (i >= 1)
                return true;
            else
                return false;
        }

    }
}