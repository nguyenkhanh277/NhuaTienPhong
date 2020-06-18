using NhuaTienPhong.Core.Domain;
using Registration.Core.License;
using System;
using System.Collections.Generic;
using System.Data;

namespace NhuaTienPhong.Core
{
    public class GlobalConstants
    {
        #region Default Values
        public static string keySoft = "KSOFT";
        public static string saltSoft = "O12ab88cKh@nh";
        public static kLicense license;
        public static string userID = "";
        public static string username = "";
        public static string fullName = "";
        public static string printerName = "Printer";
        public static int language = 0;
        public static List<LanguageLibrary> languageLibrary = new List<LanguageLibrary>();
        public static int defaultSaltLength = 5;
        public static bool debugMode = true;
        public enum GenderValue { Female, Male }
        public enum StatusValue { NoUse, Using }
        public enum LanguageValue { Vietnamese, English }
        public enum UseCarStatusValue { Agency, Company }
        public enum ProcessingCarStatusValue { MergeCar, WaitCar }
        public enum ProcessingStatusValue { None, Approved, Reject, MergeOrder }
        #endregion
    }
}
