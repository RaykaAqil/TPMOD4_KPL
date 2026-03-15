using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL4_103022400020
{
    public class KodePos
    {
        public enum Kelurahan
        {
            Batununggal, Kujangsari, Mengger, Wates, Cijaura,
            Jatisari, Margasari, Sekejati, Kebonwaru, Maleer
        }

        public static int GetKodePos(Kelurahan kel)
        {
            int[] tabelKodePos = {
            40266, 40287, 40267, 40256, 40287,
            40286, 40286, 40286, 40272, 40274
            };

            return tabelKodePos[(int)kel];
        }
    }
}
