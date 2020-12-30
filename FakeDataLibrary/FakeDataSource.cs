﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeDataLibrary
{
    /// <summary>
    /// 資料來源
    /// </summary>
    public class FakeDataSource
    {
        public static List<string> _data;
        public static List<string> Data(Action createData)
        {
            createData();

            return _data;
        }

        /// <summary>
        /// 總長需為 29
        ///  0~2 需為 965,
        ///  13~20 需為日期格式, 
        ///  21~28 需為日期格式,  
        /// </summary>
        public static void CreateData()
        {
            _data = new List<string>()
           {
              "96500000000002015092919830912",
              "96500000000009999999919830912",
              "96500000000002015092919890330",
              "96500000000012015092919870814",
              "96511111111112015092819600808",
              "96511111111112015092919820830",
              "96512345678912015092819490704",
              "96519570474632015092719541212",
              "96519570474642015092719571115",
              "96522222222222015092819561105",
              "96522796416272015092819530520",
              "96523008787902015092919340404",
              "96523008787912015092919430520",
              "96523008878462015092820121111",
              "96523008977612015092719770403",
              "96523009027852015092719580106",
              "96523009056322015092719831119",
              "96523009056332015092719460418",
              "96523009056342015092719520122",
              "96523009067372015092719920805",
              "96523009085172015092719900402",
              "96523009119722015092719571104",
              "68000000000000000000000000000",
              "69500000000002015182919830912",
              "9999889",
              "96523009085172015092719900402",
              "96523009085172015092799999999"
           };
        }
        public static void CreateLengthData()
        {
            _data = new List<string>()
           {
              "96500000000002015092919830912",
           };
        }

        public static void CreateHeaderData()
        {
            _data = new List<string>()
           {
              "96500000000002015092919830912",
              "9999889",
           };
        }

        public static void CreateFirstDateTime()
        {
            _data = new List<string>()
            {
                "96500000000002015092919830912",
            };
        }
    }
}
