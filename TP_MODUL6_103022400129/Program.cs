using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MODUL6_103022400129
{
    public class SayaMusicTrack
    {
        private int id;
        private int playCount;
        private string title;

        public SayaMusicTrack(string title)
        {
            this.title = title;
            Random rand = new Random();
            this.id = rand.Next(10000, 99999); 
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            this.playCount += count;
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine($"ID: {this.id}, Title: {this.title}, PlayCount: {this.playCount}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SayaMusicTrack lagu = new SayaMusicTrack("TEst");
            lagu.PrintTrackDetails();

            Console.WriteLine("\nMenambah play count normal");
            lagu.IncreasePlayCount(1000000);
            lagu.PrintTrackDetails();

            Console.WriteLine("\nSimulasi Overflow :");
            for (int i = 0; i < 220; i++)
            {
                lagu.IncreasePlayCount(10000000);
            }

            lagu.PrintTrackDetails();
            Console.WriteLine("\nSelesai.");
        }
    }
}
