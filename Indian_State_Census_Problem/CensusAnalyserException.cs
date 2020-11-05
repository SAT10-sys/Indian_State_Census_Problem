using System;
using System.Collections.Generic;
using System.Text;

namespace Indian_State_Census_Problem
{
    public class CensusAnalyserException:Exception
    {
        public enum ExceptionType
        {
            FILE_NOT_FOUND,
            INVALID_FILE_TYPE,
            INCORRECT_DELIMITER,
            INCORRECT_HEADER,
            NO_SUCH_COUNTRY
        }
        private ExceptionType exceptionType;
        public CensusAnalyserException(string message, ExceptionType exceptionType):base(message)
        {
            this.exceptionType = exceptionType;
        }
    }
}
