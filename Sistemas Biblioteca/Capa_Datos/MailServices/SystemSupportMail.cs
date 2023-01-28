using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.MailServices
{
    class SystemSupportMail:MasterMailServer
    {
       
             public SystemSupportMail() {
                 senderMail = "practicaprofesional38@gmail.com";
                 password = "wcvlhegsusoodzgg";
                 host = "smtp.gmail.com";
                 port = 587;
                 ssl = true;
                 initializeSmtpClient();
  
        }


    }
}
