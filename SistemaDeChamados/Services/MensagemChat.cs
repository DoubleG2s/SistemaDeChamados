using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeChamados.Services
{
    public class MensagemChat
    {

        public int id { get; set; }
        public int id_chamado { get; set; }
        public int remetente_id { get; set; }
        public string remetente_nome { get; set; }
        public int destinatario_id { get; set; }
        public string destinatario_nome { get; set; }
        public string mensagem { get; set; }
        public DateTime data_envio { get; set; }

    }
}
