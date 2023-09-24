using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeList
{
    internal class Globais
    {
        public static int connect;

        public static Image Image;
        public static string Name;
        public static long id;

        public static string NomeUtilizador;
        public static string NomeID;
        public static string Nome;
        public static string pass;
        public static string desc;
        public static int nfav;
        public static int nvistos;
        private string nomeConta;
        private string PassWord;

        public string NomeConta { get => nomeConta; set => nomeConta = value; }
        public string Password { get => PassWord; set => PassWord = value; }
    }
}
