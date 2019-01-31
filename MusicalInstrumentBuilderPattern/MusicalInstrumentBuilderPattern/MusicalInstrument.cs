using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalInstrumentBuilderPattern
{
    public class MusicalInstrument
    {
        public int NumberOfStrings { get; set; }
        public Wood WoodOfBody { get; set; }
        public Wood WoodOfNeck { get; set; }
        public string Type { get; set; }
        
        // Sets 3 choices for wood type for the musical instrument
        public enum Wood
        {
            Mahogany,
            Rosewood, 
            Spruce
        }

    }
}
