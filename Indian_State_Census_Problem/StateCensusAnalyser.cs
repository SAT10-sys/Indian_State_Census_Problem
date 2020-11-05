using System.IO;
using System.Collections.Generic;
using Indian_State_Census_Problem.DTO;

namespace Indian_State_Census_Problem
{
    public class StateCensusAnalyser
    {
        public enum Country
        {
            INDIA
        }
        Dictionary<string, CensusDTO> censusDataMap;
        public Dictionary<string, CensusDTO> LoadCensusData(string csvPath, Country country, string csvHeader)
        {
            CheckFileException.CheckExceptions(csvPath);
            censusDataMap = new CensusDataDictionary().LoadDictionary(csvPath, country, csvHeader);
            return censusDataMap;
        }
    }
}
