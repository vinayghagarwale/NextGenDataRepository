using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using NextGen.Data;
using NextGen.Core;
using NextGen.DataRepository.Models;

namespace NextGen.DataRepository.DataAccess.Encounter
{
    public class EncounterDiagnosisDataAccess
    {
        EncounterDiagnosis encounterDiagnosis;

        public EncounterDiagnosisDataAccess()
        {
            encounterDiagnosis = new EncounterDiagnosis();
        }
        
        public void GetEncounterDiag(string EncounterID)
        {
            try
            {
                string PracticeID = "0003";
                List<SmartParam> parameters = new List<SmartParam>();

                parameters.Add(new SmartParam("@EncID", EncounterID, DBCommand.DbDataTypes.VarChar, ParameterDirection.Input));
                parameters.Add(new SmartParam("@PracticeID", PracticeID, DBCommand.DbDataTypes.VarChar, ParameterDirection.Input));

                string ssql = @"Select icd9cm_code_id, icd9cm_code_desc from encounter_diags WHERE practice_id = @PracticeID AND enc_id = @EncID AND seq_nbr<> '00'";

                using (var dbClient = new DatabaseClient(InstanceMgr.ProcessInstance))
                {
                    if (dbClient != null)
                    {
                        using (SmartDataReader reader = new SmartDataReader(ssql, dbClient))
                        {
                            if (reader.Read())
                            {
                                encounterDiagnosis.icd9cm_code_id = Convert.ToString(reader[0].Value);
                                encounterDiagnosis.icd9cm_code_desc = Convert.ToString(reader[1].Value);
                            }
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                throw;
            }
        }
    }
}
