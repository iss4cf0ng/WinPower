using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;

namespace WinPowerC2
{
    internal class clsSqlConn
    {
        public SQLiteConnection m_sqlConn { get; set; }

        private Dictionary<string, string[]> m_dicDbTable = new Dictionary<string, string[]>
        {
            {
                "Logs",
                new string[]
                {

                }
            },
            {
                "Listener",
                new string[]
                {

                }
            }
        };

        public string m_szDbFileName { get; set; }
        public string m_szConnString { get; set; }
        public bool m_bIsOpen { get { return m_sqlConn != null && m_sqlConn.State == System.Data.ConnectionState.Open; } }

        public clsSqlConn(string szDbFileName)
        {
            m_szDbFileName = szDbFileName;
        }

        public bool fnbIsValidDbFile()
        {

            return true;
        }
    }
}
