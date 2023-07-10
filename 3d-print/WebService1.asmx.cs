using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace _3d_print
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public double sqr(int x)
        {
            double z = 4 * x / 2;
            return Math.Round(z);

        }
        [WebMethod]
        public double sqrV(int x)
        {
            double z = 4 * x / 2;
            double v = z * 2 * 3.14 * 0.05 * 0.05 * 0.05 / 3;
            return v;

        }
        [WebMethod]
        public double rect(int x, int y)
        {
            double z = 2 * (x + y) / 2;
            return Math.Round(z);
        }
        [WebMethod]
        public double rectV(int x, int y)
        {
            double z = 2 * (x + y) / 2;
            double v = z * 2 * 3.14 * 0.05 * 0.05 * 0.05 / 3;
            return v;

        }
        [WebMethod]
        public double cir(int r, int g)
        {
            double z = 2 * 3.14 * r / g;
            return Math.Round(z);

        }
        [WebMethod]
        public double cirV(int r, int g)
        {
            double z = 2 * 3.14 * r / g;
            double v = z * 2 * 3.14 * 0.05 * 0.05 * 0.05 / 3;
            return v;

        }
        
        [WebMethod]
        public double tri(int a, int b, int c)
        {
            double d = (a + b + c) / 2;
            return Math.Round(d);

        }
        [WebMethod]
        public double triV(int a, int b, int c)
        {
            double d = (a + b + c) / 2;
            double v = d * 2 * 3.14 * 0.05 * 0.05 * 0.05 / 3;
            return v;

        }
        [WebMethod]
        public String abc(string inputText)
        {
            Dictionary<char, string> brailleMap = new Dictionary<char, string>()
            {
                {'a', "⠇"},
                {'b', "⠃"},
                {'c', "⠉"},
                {'d', "⠙"},
                {'e', "⠑"},
                {'f', "⠋"},
                {'g', "⠛"},
                {'h', "⠓"},
                {'i', "⠊"},
                {'j', "⠚"},
                {'k', "⠅"},
                {'l', "⠇"},
                {'m', "⠍"},
                {'n', "⠝"},
                {'o', "⠕"},
                {'p', "⠏"},
                {'q', "⠟"},
                {'r', "⠗"},
                {'s', "⠎"},
                {'t', "⠞"},
                {'u', "⠥"},
                {'v', "⠧"},
                {'w', "⠺"},
                {'x', "⠭"},
                {'y', "⠽"},
                {'z', "⠵"}
            };
            String text = " ";
            
            foreach (char c in inputText)
            {
                if (brailleMap.ContainsKey(c))
                {
                    text = text + brailleMap[c];
                }
                else
                {
                    text = text + " ";
                }

            }
            return text;
        }
        
    }
}
