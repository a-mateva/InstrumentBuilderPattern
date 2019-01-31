using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalInstrumentBuilderPattern
{
    public class GuitarBuilder : MusicalInstrumentBuilder
    {
        // Constructor
        public GuitarBuilder()
        {
            // Makes a new instance of MusicalInstrument
            instrument = new MusicalInstrument();
            instrument.Type = "Guitar";
        }

        public override void SetNumberOfStrings()
        {
            instrument.NumberOfStrings = 6;
        }

        public override void SetWoodTypeForBody()
        {
            instrument.WoodOfBody = MusicalInstrument.Wood.Mahogany;
        }

        public override void SetWoodTypeForNeck()
        {
            instrument.WoodOfNeck = MusicalInstrument.Wood.Spruce;
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
