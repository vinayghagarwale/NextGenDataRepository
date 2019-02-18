using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextGen.DataRepository.Models
{
    public class EncounterDiagnosis
    {
        public string seq_nbr { get; set; }
        public string enc_id { get; set; }
        public string practice_id { get; set; }
        public string icd9cm_code_id { get; set; }
        public string icd9cm_code_desc { get; set; }
    }
}
