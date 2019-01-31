using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalInstrumentBuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicalInstrumentBuilder builder;
            MusicalInstrumentMaker maker = new MusicalInstrumentMaker();
            builder = new GuitarBuilder();

            maker.CreateInstrument(builder);
            builder.DisplayProperties();

            Console.WriteLine("-------------------------------");

            builder = new ViolinBuilder();
            maker.CreateInstrument(builder);
            builder.DisplayProperties();

            // Waits for user input
            Console.ReadKey(true);
        }
    }
}
