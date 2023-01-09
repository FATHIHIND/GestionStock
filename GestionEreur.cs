using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace gestion_stock
{
    public class GestionEreur
    {
        public static void logger(Exception ex, object cls)
        {
            using (StreamWriter sw = new StreamWriter(Application.StartupPath + "/log.txt", append: true))
            {
                var st = new StackTrace(ex, true);
                var line = st.GetFrame(0).GetFileLineNumber();
                sw.WriteLine("/*********************" + DateTime.Now + "***************************/");
                sw.WriteLine("erreur" + ex.Message);
                sw.WriteLine("erreur type" + ex.GetType().Name);
                sw.WriteLine("detail" + ex.TargetSite.ToString() + "class:" + cls.GetType());
                sw.WriteLine("/***********************name space" + ex.GetType().Namespace + "/*------------------*******************/");

            }
        }
    }
}
