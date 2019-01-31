using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalInstrumentBuilderPattern
{
    public class MusicalInstrumentMaker
    {
        //Uses the builder's methods to create the instrument
        public void CreateInstrument(MusicalInstrumentBuilder builder)
        {
            builder.SetNumberOfStrings();
            builder.SetWoodTypeForNeck();
            builder.SetWoodTypeForBody();
        }
    }
}
