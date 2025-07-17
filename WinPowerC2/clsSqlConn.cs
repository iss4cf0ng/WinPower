using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPowerC2
{
    internal class clsSqlConn
    {
        public string m_szDbFileName { get; set; }

        public clsSqlConn(string szDbFileName)
        {
            m_szDbFileName = szDbFileName;
        }


    }
}
