using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bimteam.Logic
{
    [Serializable]
   public class ViewBatFile
    {
        public string Path { get; set; }

        public string Seccion { get; set; }

        public string FileName { get; set; }
    }
}
