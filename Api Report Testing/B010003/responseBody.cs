using System;
using System.Collections.Generic;
using System.Text;

namespace YBInterface.Support.B010003
{
    public partial class responseBody
    {
        public responseBodyBaseInfo baseInfo { get; set; }
        public responseBodyFeeInfo feeInfo { get; set; }
    }

    public partial class responseBodyBaseInfo
    {
        public string D501_79 { get; set; }
        public string D501_78 { get; set; }
        public string D503_01 { get; set; }
        public string D101_02 { get; set; }
        public string D501_12 { get; set; }
        public string D503_17 { get; set; }
        public string D501_03 { get; set; }
        public string D501_04 { get; set; }
        public string D501_05 { get; set; }
        public string D501_40 { get; set; }
        public string D501_08 { get; set; }
        public string D501_02 { get; set; }
        public string D501_09 { get; set; }
        public string D501_42 { get; set; }
        public string D501_10 { get; set; }
        public string D501_39 { get; set; }
        public string D501_85 { get; set; }
        public string D501_86 { get; set; }
    }

 
    public partial class responseBodyFeeInfo
    {
        public responseBodyFeeInfoAllFeeSubentry allFeeSubentry { get; set; }
       
        public responseBodyFeeInfoComputeTypeFee computeTypeFee { get; set; }
    }
 
    public partial class responseBodyFeeInfoAllFeeSubentry
    {
        public string D503_03 { get; set; }
        public string D503_04 { get; set; }
        public string D503_47 { get; set; }
        public string D503_48 { get; set; }
        public string D503_50 { get; set; }
        public string D503_06 { get; set; }
        public string D503_49 { get; set; }
        public string D503_05 { get; set; }
        public string D503_51 { get; set; }
        public string D503_57 { get; set; }
        public string D503_02_2 { get; set; }
        public string D503_69 { get; set; }
    }
     
    public partial class responseBodyFeeInfoComputeTypeFee
    {
        public string D503_03_A { get; set; }
        public string D503_04_A { get; set; }
        public string D503_47_A { get; set; }
        public string D503_48_A { get; set; }
        public string D503_50_A { get; set; }
        public string D503_06_A { get; set; }
        public string D503_49_A { get; set; }
        public string D503_05_A { get; set; }
        public string D503_51_A { get; set; }
        public string D503_57_A { get; set; }
        public string D503_58 { get; set; }
        public string D503_66 { get; set; }
        public string D503_09 { get; set; }
        public string D503_60 { get; set; }
        public string D503_59 { get; set; }
        public string D503_61 { get; set; }
        public string D501_56 { get; set; }
        public string D501_50 { get; set; }
    }
}
