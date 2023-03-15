using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectExtra.Domain;
using ProiectExtra.service;

namespace ProiectExtra.UI
{
    public class CNS
    {
        private Service service;
        public CNS(Service service)
        {
            this.service = service;
        }
        public void run_ui()
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine("1. Sa se afiseze toti jucatorii unei echipe date ->");
            Console.WriteLine("2. Sa se afiseze toti jucatorii activi ai unei echipe de la un anumit meci ->");
            Console.WriteLine("3. Sa se afiseze toate meciurile dintr-o anumita perioada calendaristica ->");
            Console.WriteLine("4. Sa se determine si sa se afiseze scorul de la un anumit meci  ->");       

            while (true)
            {
                Console.WriteLine(">>>");
                String cmd = Console.ReadLine();
                if (cmd == "1")
                {
                    Console.WriteLine("Scrieti numele echipei: ");
                    String echipa = Console.ReadLine();
                    List<Jucator> jucatori = service.JucatoriiUneiEchipe(echipa);
                    jucatori.ForEach(j => Console.WriteLine(j));

                }
                else if (cmd == "2")
                {
                    Console.WriteLine("Scrieti numele echipei1: ");
                    String echipa1 = Console.ReadLine(); 
                    Console.WriteLine("Scrieti numele echipei2: ");
                    String echipa2 = Console.ReadLine();
                    List<Jucator> jucatori = service.JucatoriActiviMeci(echipa1, echipa2);
                    jucatori.ForEach(j => Console.WriteLine(j));
                }
                else if (cmd == "3")
                {
                    Console.WriteLine("Scrieti data de inceput a cautarii: ");
                    String data1 = Console.ReadLine();
                    Console.WriteLine("Scrieti data de final a cautarii: ");
                    String data2 = Console.ReadLine();
                    DateTime dt1 = DateTime.Parse(data1);
                    DateTime dt2 = DateTime.Parse(data2);
                    List<Meci> meciuri = service.MeciuriPerioada(dt1, dt2);
                    meciuri.ForEach(m => Console.WriteLine(m));
                }
                else if (cmd == "4")
                {
                    Console.WriteLine("Scrieti numele echipei1: ");
                    String echipa1 = Console.ReadLine();
                    Console.WriteLine("Scrieti numele echipei2: ");
                    String echipa2 = Console.ReadLine();
                    Console.WriteLine(service.ScorMeci(echipa1, echipa2));

                }
                else if (cmd == "0")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("COMANDA INVALIDA!");
                }
            }
        }
    }
}
