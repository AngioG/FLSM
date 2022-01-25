using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLSM
{
    public class Sottorete
    {
        [DisplayName("IP Sottorete")]
        public string ip { get; set; }

        [DisplayName("Subnet Mask")]
        public string subnet { get; set; }
        
        [DisplayName("Numero hosts")]
        public int hosts { get; set; }
        
        [DisplayName("Primo IP")]
        public string primoIp { get; set; }
        
        [DisplayName("Ultimo IP")]
        public string ultimoIp { get; set; }
        
        [DisplayName("Default Gateway")]
        public string defaultGateway { get; set; }
        
        [DisplayName("IP Broadcast")]
        public string ipBroadcast { get; set; }
    }
}
