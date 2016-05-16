using System;

namespace P02_CompanyInfo
{
    class Info
    {
        static void Main(string[] args)
        {
            string Cname = Console.ReadLine();
            string Caddress = Console.ReadLine();
            string Cphone = Console.ReadLine();
            string fax = Console.ReadLine();
            string site = Console.ReadLine();
            string Mname = Console.ReadLine();
            string MLname = Console.ReadLine();
            string Mage = Console.ReadLine();
            string Mphone = Console.ReadLine();

            Console.WriteLine(Cname);
            Console.WriteLine("Address: "+Caddress);
            Console.WriteLine("Tel. "+Cphone);
            if (fax=="")
            {
                Console.WriteLine("Fax: (no fax)");
            }
            else
            {
                Console.WriteLine("Fax: "+fax);
            }
            Console.WriteLine("Web site: "+site);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})",Mname,MLname,Mage,Mphone);
        }
    }
}
