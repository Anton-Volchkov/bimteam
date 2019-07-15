using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bimteam.Logic
{
    [Serializable]
    public class View
    {
        public int ID { get; set; }
        public string PhotoPath { get; set; } = "Res/Img/nophoto.png";
        public string Text { get; set; } = "Описание отсутствует.";

        public  List<ViewBatFile> BatFiles = new List<ViewBatFile>();
    }
}
