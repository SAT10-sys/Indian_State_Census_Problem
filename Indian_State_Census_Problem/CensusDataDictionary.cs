using Indian_State_Census_Problem.DTO;
using System.IO;
using System.Collections.Generic;
using CsvHelper;
using System.Globalization;
using System.Linq;

namespace Indian_State_Census_Problem
{
    public class CensusDataDictionary
    {
        public Dictionary<string, CensusDTO> censusDataMap;
        public Dictionary<string, CensusDTO> LoadDictionary(string path, StateCensusAnalyser.Country country, string header)
        {
            if (country == StateCensusAnalyser.Country.INDIA)            
                censusDataMap = new IndianCensusDictionary().GetDictionary(path, header);            
            return censusDataMap;
        }
    }
}
