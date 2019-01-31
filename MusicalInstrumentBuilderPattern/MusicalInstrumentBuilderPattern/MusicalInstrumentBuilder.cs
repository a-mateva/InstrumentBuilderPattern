using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalInstrumentBuilderPattern
{
    public abstract class MusicalInstrumentBuilder
    {
        protected MusicalInstrument instrument;

        public MusicalInstrument GetInstrument { get { return instrument; } }

        public abstract void SetWoodTypeForBody();
        public abstract void SetWoodTypeForNeck();
        public abstract void SetNumberOfStrings();
        public abstract void DisplayProperties();
    }
}
