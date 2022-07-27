using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace procedure.Models
{
  public class Computer
  {
    public int id_Computer { get; set; }
    public string ComputerName { get; set; }
    public byte id_ConnectionState { get; set; }

    public DateTime LastConnectionStateChangeDateTime { get; set; }
    public byte SendConnectionStateChangeEvent { get; set; }

    public int id_Computer_Type { get; set; }

    [Required]
    public String id_Server_Type { get; set; }

    [Required]
    public byte id_ProductionEnvironment { get; set; }

    [Required]
    public byte id_Site { get; set; }

    [Required]
    public string IP_Address { get; set; }

    [Required]
    public string SMTP_Post_Mail_Webservice_Address { get; set; }

    [Required]
    public string SMTP_Get_Queue_Webservice_Address { get; set; }
  }
}