using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GryFilmy
{
    public class Video : Product // Video dziedziczy z Product
    {
        public string Direction { get; set; } // Reżyseria
        public string Scenario { get; set; } // Scenariusz
    }
}
