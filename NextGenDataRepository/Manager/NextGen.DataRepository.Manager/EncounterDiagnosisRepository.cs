using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NextGen.DataRepository.Contract;
using NextGen.DataRepository.DataAccess.Encounter;

namespace NextGen.DataRepository.Manager
{
    public class EncounterDiagnosisRepository : IEncounterDiagnosisRepository
    {
        public void GetEncounterDiag(string EncounterID)
        {
            (new EncounterDiagnosisDataAccess()).GetEncounterDiag(EncounterID);
        }
    }
}
