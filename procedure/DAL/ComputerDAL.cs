using procedure.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace procedure.DAL
{
  public class ComputerDAL
  {
    string conString = ConfigurationManager.ConnectionStrings["adConnectionstring"].ToString();


    //Get All computer
    public List<Computer> GetAllComputer()
    {
      List<Computer> computerlist = new List<Computer>();

      using (SqlConnection connection = new SqlConnection(conString))
      {
        SqlCommand command = connection.CreateCommand();
        command.CommandType = CommandType.StoredProcedure;
        command.CommandText = "COMPUTER_APP.P_Computer_Select";
        command.Parameters.AddWithValue("@a_i_id_User", -1);
        command.Parameters.AddWithValue("@a_bi_id_Alert", -1);
        command.Parameters.AddWithValue("@a_smi_id_Severity_Alert ", -1);
        command.Parameters.AddWithValue("@a_vc_Alert_Message ", " ");
        SqlDataAdapter sqlDA = new SqlDataAdapter(command);
        DataTable dtcomputer = new DataTable();

        connection.Open();
        sqlDA.Fill(dtcomputer);
        connection.Close();
        foreach(DataRow dr in dtcomputer.Rows)
        {
          computerlist.Add(new Computer
          {
            id_Computer = Convert.ToInt32(dr["id_computer"]),
            ComputerName = dr["Nom"].ToString(),
            id_ConnectionState = (byte)Convert.ToInt32(dr["Etat connexion"]),
            LastConnectionStateChangeDateTime = Convert.ToDateTime(dr["Date dernière connexion"]),
            SendConnectionStateChangeEvent = (byte)Convert.ToInt32(dr["Alerte"]),
            id_Computer_Type = Convert.ToInt32(dr["Type ordinateur"]),
            id_Server_Type = dr["Type serveur"].ToString(),
            id_ProductionEnvironment = (byte)Convert.ToInt32(dr["Environnement production"]),
            id_Site = (byte)Convert.ToInt32(dr["Site"]),
            IP_Address = dr["Adresse IP"].ToString(),
            SMTP_Get_Queue_Webservice_Address = dr["Adresse SMTP / Post mail"].ToString(),
            SMTP_Post_Mail_Webservice_Address =dr["Adresse SMTP / Get Queue"].ToString(),

          });
        } 
      }
      return computerlist;

    }
  }
}