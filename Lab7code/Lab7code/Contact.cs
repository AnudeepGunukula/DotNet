using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7code
{
    class Contact
    {
        private int contactNo;
        private string contactName;
        private string cellNo;

        public int ContactNo { get => contactNo; set => contactNo = value; }
        public string ContactName { get => contactName; set => contactName = value; }
        public string CellNo { get => cellNo; set => cellNo = value; }
    }
}
