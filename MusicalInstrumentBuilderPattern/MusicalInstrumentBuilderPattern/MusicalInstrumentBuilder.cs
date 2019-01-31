using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalInstrumentBuilderPattern
{
    public abstract class MusicalInstrumentBuilder
    {
        // Field which is initiallized in the descendants of this class - respectively GuitarBuilder and ViolinBuilder
        protected MusicalInstrument instrument;

        // Sets the way in which the musical instrument will be constructed
        public abstract void SetWoodTypeForBody();
        public abstract void SetWoodTypeForNeck();
        public abstract void SetNumberOfStrings();
        public abstract void DisplayProperties();
    }
}
