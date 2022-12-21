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
    public class acoesAtend
    {
        ConexaoVET con = new ConexaoVET();

        public void inserirAtendimento(ModelVETAtendimento cm)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tbatendimento values(default, @dataAtendimento, @horaAtendimento, @fkcodAnimal, @fkcodVeterinario, @diagnostico)", con.MyConectarBD());

            cmd.Parameters.Add("@dataAtendimento", MySqlDbType.VarChar).Value = cm.dataAtendimento;
            cmd.Parameters.Add("@horaAtendimento", MySqlDbType.VarChar).Value = cm.horaAtendimento;
            cmd.Parameters.Add("@fkcodAnimal", MySqlDbType.VarChar).Value = cm.fkcodAnimal;
            cmd.Parameters.Add("@fkcodVeterinario", MySqlDbType.VarChar).Value = cm.fkcodVeterinario;
            cmd.Parameters.Add("@diagnostico", MySqlDbType.VarChar).Value = cm.diagnostico;
            cmd.ExecuteNonQuery();
            con.MyDesconectarBD();
        }

        public List<ModelVETAtendimento> GetAtendimento()
        {
            List<ModelVETAtendimento> AtendimentoList = new List<ModelVETAtendimento>();

            MySqlCommand cmd = new MySqlCommand("select * from tbatendimento", con.MyConectarBD());
            MySqlDataAdapter sd = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sd.Fill(dt);
            con.MyDesconectarBD();

            foreach (DataRow dr in dt.Rows)
            {
                AtendimentoList.Add(
                    new ModelVETAtendimento
                    {
                        codAtendimento = Convert.ToString(dr["codAtendimento"]),
                        dataAtendimento = Convert.ToString(dr["dataAtendimento"]),
                        horaAtendimento = Convert.ToString(dr["horaAtendimento"]),
                        fkcodAnimal = Convert.ToString(dr["fkcodAnimal"]),
                        fkcodVeterinario = Convert.ToString(dr["fkcodVeterinario"]),
                        diagnostico = Convert.ToString(dr["diagnostico"]),
                    });
            }
            return AtendimentoList;
        }

        public bool DeleteAtendimento(int id)
        {
            MySqlCommand cmd = new MySqlCommand("delete from tbatendimento where codAtendimento=@id", con.MyConectarBD());

            cmd.Parameters.AddWithValue("@id", id);

            int i = cmd.ExecuteNonQuery();
            con.MyDesconectarBD();

            if (i >= 1)
                return true;
            else
                return false;
        }

        public bool atualizaAtendimento(ModelVETAtendimento cm)
        {
            MySqlCommand cmd = new MySqlCommand("update tbatendimento set dataAtendimento=@dataAtendimento, horaAtendimento=@horaAtendimento ,diagnostico=@diagnostico  where codAtendimento=@cod", con.MyConectarBD());

            cmd.Parameters.AddWithValue("@dataAtendimento", cm.dataAtendimento);
            cmd.Parameters.AddWithValue("@horaAtendimento", cm.horaAtendimento);
            cmd.Parameters.AddWithValue("@diagnostico", cm.diagnostico);
            cmd.Parameters.AddWithValue("@cod", cm.codAtendimento);


            int i = cmd.ExecuteNonQuery();
            con.MyDesconectarBD();

            if (i >= 1)
                return true;
            else
                return false;
        }
    }
}