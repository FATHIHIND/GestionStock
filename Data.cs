using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
namespace gestion_stock
{
   public  class Data:DemendeAchat
    {
        private string num;
        public static List<Data> i = new List<Data>();
        public static List<produit> g = new List<produit>();
        public static List<triercs> gg = new List<triercs>();
        public static List<DemendeAchat> r = new List<DemendeAchat>();

        public static void serialiserclsproduit()
        {
            XmlSerializer xml = new XmlSerializer(gg.GetType());
            using (StreamWriter st = new StreamWriter(File.CreateText("System.IO.StreamWriter.xml").ToString()))
            {
                xml.Serialize(st, gg);

            }

        }
        //public static void serialiserclsproduit1()
        //{
        //    XmlSerializer j = new XmlSerializer(gg.GetType());
        //    using (StreamWriter jj = new StreamWriter(File.CreateText("hind.xml").ToString()))
        //    {
        //        j.Serialize(jj, gg);

        //    }

        //}
        //public static void Dserialiserclsproduit1()
        //{
        //    if (File.Exists("System.IO.StreamWriter"))
        //    {
        //        XmlSerializer xml = new XmlSerializer(gg.GetType());
        //    using (StreamReader st = File.OpenText("System.IO.StreamWriter"))
        //    {
        //        gg = (List<triercs>)xml.Deserialize(st);

        //    }
        //}
        public static void Dserialiserclsproduit()
        {
            if (File.Exists("System.IO.StreamWriter"))
            {
                XmlSerializer xml = new XmlSerializer(gg.GetType());
            using (StreamReader st = File.OpenText("System.IO.StreamWriter"))
            {
                gg = (List<triercs>)xml.Deserialize(st);

            }
            }

        }
    }
        
       
    }

