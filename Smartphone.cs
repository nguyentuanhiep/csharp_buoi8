using System.Collections.Generic;

namespace csharp_buoi8
{
    public interface Smartphone
    {
        void Info();

    }

    class Samsung:Smartphone
    {
        private string OS;
        private string Camera;
        private string Call;
        public Samsung()
        {
            OS="";
            Camera="";
            Call="";

        }

        public Samsung(string a, string b, string c)
        {
            OS = a;
            Camera = b;
            Call = c;
        }

        public void Info()
        {
            System.Console.WriteLine("He dieu hanh {0}. {1}. {2}", OS,Camera,Call);
        }
    }

    class Iphone:Smartphone
    {
        private string OS;
        private string Camera;
        private string Call;
        public Iphone()
        {
            OS="";
            Camera="";
            Call="";

        }

        public Iphone(string a, string b, string c)
        {
            OS = a;
            Camera = b;
            Call = c;
        }

        public void Info()
        {
            System.Console.WriteLine("He dieu hanh {0}. {1}. {2}", OS,Camera,Call);
        }
    }
}