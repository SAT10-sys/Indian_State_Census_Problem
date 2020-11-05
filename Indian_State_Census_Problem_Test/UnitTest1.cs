
using Indian_State_Census_Problem;
using NUnit.Framework;
using Indian_State_Census_Problem.DTO;
using static Indian_State_Census_Problem.StateCensusAnalyser;
using System.Collections.Generic;

namespace Indian_State_Census_Problem_Test
{
    public class UnitTest1
    {
        string indianStateCensusDataCSVPath = @"C:\Users\USER\source\repos\Indian_State_Census_Problem\Indian_State_Census_Problem_Test\CensusFiles\IndiaStateCensusData.csv";
        string indianStateCensusDataHeader= "State,Population,AreaInSqKm,DensityPerSqKm";
        string indianStateCensusDataWrongCSVPath= @"C:\Users\USER\source\Indian_State_Census_Problem\Indian_State_Census_Problem_Test\CensusFiles\IndiaStateCensusData.csv";
        string indianStateCensusDataWrongType = @"C:\Users\USER\source\repos\Indian_State_Census_Problem\Indian_State_Census_Problem_Test\CensusFiles\IndiaStateCode.txt";
        string indianStateCensusDataDelimeter = @"C:\Users\USER\source\repos\Indian_State_Census_Problem\Indian_State_Census_Problem_Test\CensusFiles\DelimiterIndiaStateCensusData.csv";
        string indianStateCensusDataWrongHeader = @"C:\Users\USER\source\repos\Indian_State_Census_Problem\Indian_State_Census_Problem_Test\CensusFiles\WrongIndiaStateCensusData.csv";

        StateCensusAnalyser stateCensusAnalyser;
        Dictionary<string, CensusDTO> stateDataRecord;
        [SetUp]
        public void SetUp()
        {
            stateCensusAnalyser = new StateCensusAnalyser();
            stateDataRecord = new Dictionary<string, CensusDTO>();
        }
       [Test]
        public void TestMethod1()
        {
            Assert.Pass();
        }
        [Test]
        public void GivenIndianStateCensusDataFileShouldReturnCensusDataCount()
        {
            stateDataRecord = stateCensusAnalyser.LoadCensusData(indianStateCensusDataCSVPath, Country.INDIA, indianStateCensusDataHeader);
            Assert.AreEqual(29, stateDataRecord.Count);
        }
        [Test]
        public void GivenIndianStateCensusDataWrongFilePathShouldReturnException()
        {
            try
            {
                stateDataRecord = stateCensusAnalyser.LoadCensusData(indianStateCensusDataWrongCSVPath, Country.INDIA, indianStateCensusDataHeader);
            }
            catch (CensusAnalyserException e)
            {
                Assert.AreEqual(CensusAnalyserException.ExceptionType.FILE_NOT_FOUND, e.Message);
            }
        }
        [Test]
        public void GivenIndianStateCensusDataWrongFileTypeShouldReturnException()
        {
            try
            {
                stateDataRecord = stateCensusAnalyser.LoadCensusData(indianStateCensusDataWrongType, Country.INDIA, indianStateCensusDataHeader);
            }
            catch (CensusAnalyserException e)
            {
                Assert.AreEqual(CensusAnalyserException.ExceptionType.INVALID_FILE_TYPE, e.Message);
            }
        }
        [Test]
        public void GivenIndianStateCensusDataFileWrongDelimiterShouldReturnException()
        {
            try
            {
                stateDataRecord = stateCensusAnalyser.LoadCensusData(indianStateCensusDataDelimeter, Country.INDIA, indianStateCensusDataHeader);
            }
            catch (CensusAnalyserException e)
            {
                Assert.AreEqual(CensusAnalyserException.ExceptionType.INCORRECT_DELIMITER, e.Message);
            }
        }
        [Test]
        public void GivenIndianStateCensusDataFileWrongHeaderShouldReturnException()
        {
            try
            {
                stateDataRecord = stateCensusAnalyser.LoadCensusData(indianStateCensusDataWrongHeader, Country.INDIA, indianStateCensusDataHeader);
            }
            catch (CensusAnalyserException e)
            {
                Assert.AreEqual(CensusAnalyserException.ExceptionType.INCORRECT_HEADER, e.Message);
            }
        }

    }
}
