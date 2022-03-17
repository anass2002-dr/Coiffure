using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Coiffure
{
    static class Program
    {
        public static List<string> cr = new List<string>
        {
            "AntiqueWhite","MediumTurquoise","DarkCyan","LightSalmon","Aquamarine"
            ,"SeaGreen","DarkSlateGray","LightCoral","Salmon","DodgerBlue","Orange"

        };

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Accueil());
        }
    }
}
