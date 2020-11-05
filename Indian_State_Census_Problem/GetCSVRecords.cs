using System.IO;

namespace Indian_State_Census_Problem
{
    public class GetCSVRecords
    {
        string[] records;
        public string[] GetRecords(string path, string header)
        {
            records = File.ReadAllLines(path);
            if(records[0]!=header)
                throw new CensusAnalyserException("Header is Invalid", CensusAnalyserException.ExceptionType.INCORRECT_HEADER);
            return records;
        }
    }
}
