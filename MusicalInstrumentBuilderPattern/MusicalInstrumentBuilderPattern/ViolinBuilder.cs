using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalInstrumentBuilderPattern
{
    public class ViolinBuilder : MusicalInstrumentBuilder
    {
        public ViolinBuilder()
        {
            instrument = new MusicalInstrument();
            instrument.Type = "Violin";
        }

        public override void SetNumberOfStrings()
        {
            instrument.NumberOfStrings = 4;
        }

        public override void SetWoodTypeForBody()
        {
            instrument.WoodOfBody = MusicalInstrument.Wood.Spruce;
        }

        public override void SetWoodTypeForNeck()
        {
            instrument.WoodOfNeck = MusicalInstrument.Wood.Rosewood;
        }

        public override void DisplayProperties()
        {
            Console.WriteLine("This is a " + instrument.Type);
            Console.WriteLine("Number of strings: " + instrument.NumberOfStrings);
            Console.WriteLine("Wood of body: " + instrument.WoodOfBody);
            Console.WriteLine("Wood of neck: " + instrument.WoodOfNeck);
        }
    }
}
