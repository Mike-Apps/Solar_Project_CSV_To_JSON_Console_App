using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Solar_Project_CSV_To_JSON_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creates a list of files in a directory
            string[] files = Directory.GetFiles(@"C:\CSV_Read_Project\test", "*.csv", SearchOption.TopDirectoryOnly);

            foreach (string file in files)
            {
                ExtractData(file);
            }
        }
        
        public static void ExtractData(string file)
        {
           /* Variable declaration starts here.  Each month has an hourly breakdown.  CSV file I am extracting data from contains around 71 Columns and > 8k Rows per file
            * There are > 2K CSV files in this format that need to be itterated through.
            * Goal here is to identify the hourly averages for each location (each CSV file is a location) over a 20 year span.Right now, this information
            * is getting stored in a JSON file and will have a class model that matches the JSON template.Next project will be to output this information to a database.
            * Which is why this whole program is in one main class, for ease of replication.Next project will be to clean up and minimize the repeated code. 
            */

            //January Averages 
            #region
            decimal monthAverageJan = 0;

            decimal tempTotalJan0600 = 0;
            decimal countTotalJan0600 = 0;
            decimal AverageJan0600 = 0;

            decimal tempTotalJan0700 = 0;
            decimal countTotalJan0700 = 0;
            decimal AverageJan0700 = 0;

            decimal tempTotalJan0800 = 0;
            decimal countTotalJan0800 = 0;
            decimal AverageJan0800 = 0;

            decimal tempTotalJan0900 = 0;
            decimal countTotalJan0900 = 0;
            decimal AverageJan0900 = 0;

            decimal tempTotalJan1000 = 0;
            decimal countTotalJan1000 = 0;
            decimal AverageJan1000 = 0;

            decimal tempTotalJan1100 = 0;
            decimal countTotalJan1100 = 0;
            decimal AverageJan1100 = 0;

            decimal tempTotalJan1200 = 0;
            decimal countTotalJan1200 = 0;
            decimal AverageJan1200 = 0;

            decimal tempTotalJan1300 = 0;
            decimal countTotalJan1300 = 0;
            decimal AverageJan1300 = 0;

            decimal tempTotalJan1400 = 0;
            decimal countTotalJan1400 = 0;
            decimal AverageJan1400 = 0;

            decimal tempTotalJan1500 = 0;
            decimal countTotalJan1500 = 0;
            decimal AverageJan1500 = 0;

            decimal tempTotalJan1600 = 0;
            decimal countTotalJan1600 = 0;
            decimal AverageJan1600 = 0;

            decimal tempTotalJan1700 = 0;
            decimal countTotalJan1700 = 0;
            decimal AverageJan1700 = 0;

            decimal tempTotalJan1800 = 0;
            decimal countTotalJan1800 = 0;
            decimal AverageJan1800 = 0;

            decimal tempTotalJan1900 = 0;
            decimal countTotalJan1900 = 0;
            decimal AverageJan1900 = 0;

            decimal tempTotalJan2000 = 0;
            decimal countTotalJan2000 = 0;
            decimal AverageJan2000 = 0;
            #endregion

            //February Averages
            #region
            decimal AverageForMonthFeb = 0;

            decimal tempTotalFeb0600 = 0;
            decimal countTotalFeb0600 = 0;
            decimal AverageFeb0600 = 0;

            decimal tempTotalFeb0700 = 0;
            decimal countTotalFeb0700 = 0;
            decimal AverageFeb0700 = 0;

            decimal tempTotalFeb0800 = 0;
            decimal countTotalFeb0800 = 0;
            decimal AverageFeb0800 = 0;

            decimal tempTotalFeb0900 = 0;
            decimal countTotalFeb0900 = 0;
            decimal AverageFeb0900 = 0;

            decimal tempTotalFeb1000 = 0;
            decimal countTotalFeb1000 = 0;
            decimal AverageFeb1000 = 0;

            decimal tempTotalFeb1100 = 0;
            decimal countTotalFeb1100 = 0;
            decimal AverageFeb1100 = 0;

            decimal tempTotalFeb1200 = 0;
            decimal countTotalFeb1200 = 0;
            decimal AverageFeb1200 = 0;

            decimal tempTotalFeb1300 = 0;
            decimal countTotalFeb1300 = 0;
            decimal AverageFeb1300 = 0;

            decimal tempTotalFeb1400 = 0;
            decimal countTotalFeb1400 = 0;
            decimal AverageFeb1400 = 0;

            decimal tempTotalFeb1500 = 0;
            decimal countTotalFeb1500 = 0;
            decimal AverageFeb1500 = 0;

            decimal tempTotalFeb1600 = 0;
            decimal countTotalFeb1600 = 0;
            decimal AverageFeb1600 = 0;

            decimal tempTotalFeb1700 = 0;
            decimal countTotalFeb1700 = 0;
            decimal AverageFeb1700 = 0;

            decimal tempTotalFeb1800 = 0;
            decimal countTotalFeb1800 = 0;
            decimal AverageFeb1800 = 0;

            decimal tempTotalFeb1900 = 0;
            decimal countTotalFeb1900 = 0;
            decimal AverageFeb1900 = 0;

            decimal tempTotalFeb2000 = 0;
            decimal countTotalFeb2000 = 0;
            decimal AverageFeb2000 = 0;
            #endregion

            //March Averages
            #region
            decimal averageMarch = 0;

            decimal tempTotalMar0600 = 0;
            decimal countTotalMar0600 = 0;
            decimal AverageMar0600 = 0;

            decimal tempTotalMar0700 = 0;
            decimal countTotalMar0700 = 0;
            decimal AverageMar0700 = 0;

            decimal tempTotalMar0800 = 0;
            decimal countTotalMar0800 = 0;
            decimal AverageMar0800 = 0;

            decimal tempTotalMar0900 = 0;
            decimal countTotalMar0900 = 0;
            decimal AverageMar0900 = 0;

            decimal tempTotalMar1000 = 0;
            decimal countTotalMar1000 = 0;
            decimal AverageMar1000 = 0;

            decimal tempTotalMar1100 = 0;
            decimal countTotalMar1100 = 0;
            decimal AverageMar1100 = 0;

            decimal tempTotalMar1200 = 0;
            decimal countTotalMar1200 = 0;
            decimal AverageMar1200 = 0;

            decimal tempTotalMar1300 = 0;
            decimal countTotalMar1300 = 0;
            decimal AverageMar1300 = 0;

            decimal tempTotalMar1400 = 0;
            decimal countTotalMar1400 = 0;
            decimal AverageMar1400 = 0;

            decimal tempTotalMar1500 = 0;
            decimal countTotalMar1500 = 0;
            decimal AverageMar1500 = 0;

            decimal tempTotalMar1600 = 0;
            decimal countTotalMar1600 = 0;
            decimal AverageMar1600 = 0;

            decimal tempTotalMar1700 = 0;
            decimal countTotalMar1700 = 0;
            decimal AverageMar1700 = 0;

            decimal tempTotalMar1800 = 0;
            decimal countTotalMar1800 = 0;
            decimal AverageMar1800 = 0;

            decimal tempTotalMar1900 = 0;
            decimal countTotalMar1900 = 0;
            decimal AverageMar1900 = 0;

            decimal tempTotalMar2000 = 0;
            decimal countTotalMar2000 = 0;
            decimal AverageMar2000 = 0;
            #endregion

            //April Averages
            #region
            decimal monthAverageApr = 0;

            decimal tempTotalApr0600 = 0;
            decimal countTotalApr0600 = 0;
            decimal AverageApr0600 = 0;

            decimal tempTotalApr0700 = 0;
            decimal countTotalApr0700 = 0;
            decimal AverageApr0700 = 0;

            decimal tempTotalApr0800 = 0;
            decimal countTotalApr0800 = 0;
            decimal AverageApr0800 = 0;

            decimal tempTotalApr0900 = 0;
            decimal countTotalApr0900 = 0;
            decimal AverageApr0900 = 0;

            decimal tempTotalApr1000 = 0;
            decimal countTotalApr1000 = 0;
            decimal AverageApr1000 = 0;

            decimal tempTotalApr1100 = 0;
            decimal countTotalApr1100 = 0;
            decimal AverageApr1100 = 0;

            decimal tempTotalApr1200 = 0;
            decimal countTotalApr1200 = 0;
            decimal AverageApr1200 = 0;

            decimal tempTotalApr1300 = 0;
            decimal countTotalApr1300 = 0;
            decimal AverageApr1300 = 0;

            decimal tempTotalApr1400 = 0;
            decimal countTotalApr1400 = 0;
            decimal AverageApr1400 = 0;

            decimal tempTotalApr1500 = 0;
            decimal countTotalApr1500 = 0;
            decimal AverageApr1500 = 0;

            decimal tempTotalApr1600 = 0;
            decimal countTotalApr1600 = 0;
            decimal AverageApr1600 = 0;

            decimal tempTotalApr1700 = 0;
            decimal countTotalApr1700 = 0;
            decimal AverageApr1700 = 0;

            decimal tempTotalApr1800 = 0;
            decimal countTotalApr1800 = 0;
            decimal AverageApr1800 = 0;

            decimal tempTotalApr1900 = 0;
            decimal countTotalApr1900 = 0;
            decimal AverageApr1900 = 0;

            decimal tempTotalApr2000 = 0;
            decimal countTotalApr2000 = 0;
            decimal AverageApr2000 = 0;
            #endregion

            //May Averages
            #region
            decimal monthAverageMay = 0;

            decimal tempTotalMay0600 = 0;
            decimal countTotalMay0600 = 0;
            decimal AverageMay0600 = 0;

            decimal tempTotalMay0700 = 0;
            decimal countTotalMay0700 = 0;
            decimal AverageMay0700 = 0;

            decimal tempTotalMay0800 = 0;
            decimal countTotalMay0800 = 0;
            decimal AverageMay0800 = 0;

            decimal tempTotalMay0900 = 0;
            decimal countTotalMay0900 = 0;
            decimal AverageMay0900 = 0;

            decimal tempTotalMay1000 = 0;
            decimal countTotalMay1000 = 0;
            decimal AverageMay1000 = 0;

            decimal tempTotalMay1100 = 0;
            decimal countTotalMay1100 = 0;
            decimal AverageMay1100 = 0;

            decimal tempTotalMay1200 = 0;
            decimal countTotalMay1200 = 0;
            decimal AverageMay1200 = 0;

            decimal tempTotalMay1300 = 0;
            decimal countTotalMay1300 = 0;
            decimal AverageMay1300 = 0;

            decimal tempTotalMay1400 = 0;
            decimal countTotalMay1400 = 0;
            decimal AverageMay1400 = 0;

            decimal tempTotalMay1500 = 0;
            decimal countTotalMay1500 = 0;
            decimal AverageMay1500 = 0;

            decimal tempTotalMay1600 = 0;
            decimal countTotalMay1600 = 0;
            decimal AverageMay1600 = 0;

            decimal tempTotalMay1700 = 0;
            decimal countTotalMay1700 = 0;
            decimal AverageMay1700 = 0;

            decimal tempTotalMay1800 = 0;
            decimal countTotalMay1800 = 0;
            decimal AverageMay1800 = 0;

            decimal tempTotalMay1900 = 0;
            decimal countTotalMay1900 = 0;
            decimal AverageMay1900 = 0;

            decimal tempTotalMay2000 = 0;
            decimal countTotalMay2000 = 0;
            decimal AverageMay2000 = 0;
            #endregion

            //Jun Averages
            #region
            decimal monthAverageJun = 0;

            decimal tempTotalJun0600 = 0;
            decimal countTotalJun0600 = 0;
            decimal AverageJun0600 = 0;

            decimal tempTotalJun0700 = 0;
            decimal countTotalJun0700 = 0;
            decimal AverageJun0700 = 0;

            decimal tempTotalJun0800 = 0;
            decimal countTotalJun0800 = 0;
            decimal AverageJun0800 = 0;

            decimal tempTotalJun0900 = 0;
            decimal countTotalJun0900 = 0;
            decimal AverageJun0900 = 0;

            decimal tempTotalJun1000 = 0;
            decimal countTotalJun1000 = 0;
            decimal AverageJun1000 = 0;

            decimal tempTotalJun1100 = 0;
            decimal countTotalJun1100 = 0;
            decimal AverageJun1100 = 0;

            decimal tempTotalJun1200 = 0;
            decimal countTotalJun1200 = 0;
            decimal AverageJun1200 = 0;

            decimal tempTotalJun1300 = 0;
            decimal countTotalJun1300 = 0;
            decimal AverageJun1300 = 0;

            decimal tempTotalJun1400 = 0;
            decimal countTotalJun1400 = 0;
            decimal AverageJun1400 = 0;

            decimal tempTotalJun1500 = 0;
            decimal countTotalJun1500 = 0;
            decimal AverageJun1500 = 0;

            decimal tempTotalJun1600 = 0;
            decimal countTotalJun1600 = 0;
            decimal AverageJun1600 = 0;

            decimal tempTotalJun1700 = 0;
            decimal countTotalJun1700 = 0;
            decimal AverageJun1700 = 0;

            decimal tempTotalJun1800 = 0;
            decimal countTotalJun1800 = 0;
            decimal AverageJun1800 = 0;

            decimal tempTotalJun1900 = 0;
            decimal countTotalJun1900 = 0;
            decimal AverageJun1900 = 0;

            decimal tempTotalJun2000 = 0;
            decimal countTotalJun2000 = 0;
            decimal AverageJun2000 = 0;
            #endregion

            //Jul Averages
            #region
            decimal monthAverageJul = 0;

            decimal tempTotalJul0600 = 0;
            decimal countTotalJul0600 = 0;
            decimal AverageJul0600 = 0;

            decimal tempTotalJul0700 = 0;
            decimal countTotalJul0700 = 0;
            decimal AverageJul0700 = 0;

            decimal tempTotalJul0800 = 0;
            decimal countTotalJul0800 = 0;
            decimal AverageJul0800 = 0;

            decimal tempTotalJul0900 = 0;
            decimal countTotalJul0900 = 0;
            decimal AverageJul0900 = 0;

            decimal tempTotalJul1000 = 0;
            decimal countTotalJul1000 = 0;
            decimal AverageJul1000 = 0;

            decimal tempTotalJul1100 = 0;
            decimal countTotalJul1100 = 0;
            decimal AverageJul1100 = 0;

            decimal tempTotalJul1200 = 0;
            decimal countTotalJul1200 = 0;
            decimal AverageJul1200 = 0;

            decimal tempTotalJul1300 = 0;
            decimal countTotalJul1300 = 0;
            decimal AverageJul1300 = 0;

            decimal tempTotalJul1400 = 0;
            decimal countTotalJul1400 = 0;
            decimal AverageJul1400 = 0;

            decimal tempTotalJul1500 = 0;
            decimal countTotalJul1500 = 0;
            decimal AverageJul1500 = 0;

            decimal tempTotalJul1600 = 0;
            decimal countTotalJul1600 = 0;
            decimal AverageJul1600 = 0;

            decimal tempTotalJul1700 = 0;
            decimal countTotalJul1700 = 0;
            decimal AverageJul1700 = 0;

            decimal tempTotalJul1800 = 0;
            decimal countTotalJul1800 = 0;
            decimal AverageJul1800 = 0;

            decimal tempTotalJul1900 = 0;
            decimal countTotalJul1900 = 0;
            decimal AverageJul1900 = 0;

            decimal tempTotalJul2000 = 0;
            decimal countTotalJul2000 = 0;
            decimal AverageJul2000 = 0;
            #endregion

            //Aug Averages
            #region
            decimal monthAverageAug = 0;

            decimal tempTotalAug0600 = 0;
            decimal countTotalAug0600 = 0;
            decimal AverageAug0600 = 0;

            decimal tempTotalAug0700 = 0;
            decimal countTotalAug0700 = 0;
            decimal AverageAug0700 = 0;

            decimal tempTotalAug0800 = 0;
            decimal countTotalAug0800 = 0;
            decimal AverageAug0800 = 0;

            decimal tempTotalAug0900 = 0;
            decimal countTotalAug0900 = 0;
            decimal AverageAug0900 = 0;

            decimal tempTotalAug1000 = 0;
            decimal countTotalAug1000 = 0;
            decimal AverageAug1000 = 0;

            decimal tempTotalAug1100 = 0;
            decimal countTotalAug1100 = 0;
            decimal AverageAug1100 = 0;

            decimal tempTotalAug1200 = 0;
            decimal countTotalAug1200 = 0;
            decimal AverageAug1200 = 0;

            decimal tempTotalAug1300 = 0;
            decimal countTotalAug1300 = 0;
            decimal AverageAug1300 = 0;

            decimal tempTotalAug1400 = 0;
            decimal countTotalAug1400 = 0;
            decimal AverageAug1400 = 0;

            decimal tempTotalAug1500 = 0;
            decimal countTotalAug1500 = 0;
            decimal AverageAug1500 = 0;

            decimal tempTotalAug1600 = 0;
            decimal countTotalAug1600 = 0;
            decimal AverageAug1600 = 0;

            decimal tempTotalAug1700 = 0;
            decimal countTotalAug1700 = 0;
            decimal AverageAug1700 = 0;

            decimal tempTotalAug1800 = 0;
            decimal countTotalAug1800 = 0;
            decimal AverageAug1800 = 0;

            decimal tempTotalAug1900 = 0;
            decimal countTotalAug1900 = 0;
            decimal AverageAug1900 = 0;

            decimal tempTotalAug2000 = 0;
            decimal countTotalAug2000 = 0;
            decimal AverageAug2000 = 0;
            #endregion

            //Sep Averages
            #region
            decimal monthAverageSep = 0;

            decimal tempTotalSep0600 = 0;
            decimal countTotalSep0600 = 0;
            decimal AverageSep0600 = 0;

            decimal tempTotalSep0700 = 0;
            decimal countTotalSep0700 = 0;
            decimal AverageSep0700 = 0;

            decimal tempTotalSep0800 = 0;
            decimal countTotalSep0800 = 0;
            decimal AverageSep0800 = 0;

            decimal tempTotalSep0900 = 0;
            decimal countTotalSep0900 = 0;
            decimal AverageSep0900 = 0;

            decimal tempTotalSep1000 = 0;
            decimal countTotalSep1000 = 0;
            decimal AverageSep1000 = 0;

            decimal tempTotalSep1100 = 0;
            decimal countTotalSep1100 = 0;
            decimal AverageSep1100 = 0;

            decimal tempTotalSep1200 = 0;
            decimal countTotalSep1200 = 0;
            decimal AverageSep1200 = 0;

            decimal tempTotalSep1300 = 0;
            decimal countTotalSep1300 = 0;
            decimal AverageSep1300 = 0;

            decimal tempTotalSep1400 = 0;
            decimal countTotalSep1400 = 0;
            decimal AverageSep1400 = 0;

            decimal tempTotalSep1500 = 0;
            decimal countTotalSep1500 = 0;
            decimal AverageSep1500 = 0;

            decimal tempTotalSep1600 = 0;
            decimal countTotalSep1600 = 0;
            decimal AverageSep1600 = 0;

            decimal tempTotalSep1700 = 0;
            decimal countTotalSep1700 = 0;
            decimal AverageSep1700 = 0;

            decimal tempTotalSep1800 = 0;
            decimal countTotalSep1800 = 0;
            decimal AverageSep1800 = 0;

            decimal tempTotalSep1900 = 0;
            decimal countTotalSep1900 = 0;
            decimal AverageSep1900 = 0;

            decimal tempTotalSep2000 = 0;
            decimal countTotalSep2000 = 0;
            decimal AverageSep2000 = 0;
            #endregion

            //Oct Averages
            #region
            decimal monthAverageOct = 0;

            decimal tempTotalOct0600 = 0;
            decimal countTotalOct0600 = 0;
            decimal AverageOct0600 = 0;

            decimal tempTotalOct0700 = 0;
            decimal countTotalOct0700 = 0;
            decimal AverageOct0700 = 0;

            decimal tempTotalOct0800 = 0;
            decimal countTotalOct0800 = 0;
            decimal AverageOct0800 = 0;

            decimal tempTotalOct0900 = 0;
            decimal countTotalOct0900 = 0;
            decimal AverageOct0900 = 0;

            decimal tempTotalOct1000 = 0;
            decimal countTotalOct1000 = 0;
            decimal AverageOct1000 = 0;

            decimal tempTotalOct1100 = 0;
            decimal countTotalOct1100 = 0;
            decimal AverageOct1100 = 0;

            decimal tempTotalOct1200 = 0;
            decimal countTotalOct1200 = 0;
            decimal AverageOct1200 = 0;

            decimal tempTotalOct1300 = 0;
            decimal countTotalOct1300 = 0;
            decimal AverageOct1300 = 0;

            decimal tempTotalOct1400 = 0;
            decimal countTotalOct1400 = 0;
            decimal AverageOct1400 = 0;

            decimal tempTotalOct1500 = 0;
            decimal countTotalOct1500 = 0;
            decimal AverageOct1500 = 0;

            decimal tempTotalOct1600 = 0;
            decimal countTotalOct1600 = 0;
            decimal AverageOct1600 = 0;

            decimal tempTotalOct1700 = 0;
            decimal countTotalOct1700 = 0;
            decimal AverageOct1700 = 0;

            decimal tempTotalOct1800 = 0;
            decimal countTotalOct1800 = 0;
            decimal AverageOct1800 = 0;

            decimal tempTotalOct1900 = 0;
            decimal countTotalOct1900 = 0;
            decimal AverageOct1900 = 0;

            decimal tempTotalOct2000 = 0;
            decimal countTotalOct2000 = 0;
            decimal AverageOct2000 = 0;
            #endregion

            //Nov Averages
            #region
            decimal monthAverageNov = 0;

            decimal tempTotalNov0600 = 0;
            decimal countTotalNov0600 = 0;
            decimal AverageNov0600 = 0;

            decimal tempTotalNov0700 = 0;
            decimal countTotalNov0700 = 0;
            decimal AverageNov0700 = 0;

            decimal tempTotalNov0800 = 0;
            decimal countTotalNov0800 = 0;
            decimal AverageNov0800 = 0;

            decimal tempTotalNov0900 = 0;
            decimal countTotalNov0900 = 0;
            decimal AverageNov0900 = 0;

            decimal tempTotalNov1000 = 0;
            decimal countTotalNov1000 = 0;
            decimal AverageNov1000 = 0;

            decimal tempTotalNov1100 = 0;
            decimal countTotalNov1100 = 0;
            decimal AverageNov1100 = 0;

            decimal tempTotalNov1200 = 0;
            decimal countTotalNov1200 = 0;
            decimal AverageNov1200 = 0;

            decimal tempTotalNov1300 = 0;
            decimal countTotalNov1300 = 0;
            decimal AverageNov1300 = 0;

            decimal tempTotalNov1400 = 0;
            decimal countTotalNov1400 = 0;
            decimal AverageNov1400 = 0;

            decimal tempTotalNov1500 = 0;
            decimal countTotalNov1500 = 0;
            decimal AverageNov1500 = 0;

            decimal tempTotalNov1600 = 0;
            decimal countTotalNov1600 = 0;
            decimal AverageNov1600 = 0;

            decimal tempTotalNov1700 = 0;
            decimal countTotalNov1700 = 0;
            decimal AverageNov1700 = 0;

            decimal tempTotalNov1800 = 0;
            decimal countTotalNov1800 = 0;
            decimal AverageNov1800 = 0;

            decimal tempTotalNov1900 = 0;
            decimal countTotalNov1900 = 0;
            decimal AverageNov1900 = 0;

            decimal tempTotalNov2000 = 0;
            decimal countTotalNov2000 = 0;
            decimal AverageNov2000 = 0;
            #endregion

            //Dec Averages
            #region
            decimal monthAverageDec = 0;

            decimal tempTotalDec0600 = 0;
            decimal countTotalDec0600 = 0;
            decimal AverageDec0600 = 0;

            decimal tempTotalDec0700 = 0;
            decimal countTotalDec0700 = 0;
            decimal AverageDec0700 = 0;

            decimal tempTotalDec0800 = 0;
            decimal countTotalDec0800 = 0;
            decimal AverageDec0800 = 0;

            decimal tempTotalDec0900 = 0;
            decimal countTotalDec0900 = 0;
            decimal AverageDec0900 = 0;

            decimal tempTotalDec1000 = 0;
            decimal countTotalDec1000 = 0;
            decimal AverageDec1000 = 0;

            decimal tempTotalDec1100 = 0;
            decimal countTotalDec1100 = 0;
            decimal AverageDec1100 = 0;

            decimal tempTotalDec1200 = 0;
            decimal countTotalDec1200 = 0;
            decimal AverageDec1200 = 0;

            decimal tempTotalDec1300 = 0;
            decimal countTotalDec1300 = 0;
            decimal AverageDec1300 = 0;

            decimal tempTotalDec1400 = 0;
            decimal countTotalDec1400 = 0;
            decimal AverageDec1400 = 0;

            decimal tempTotalDec1500 = 0;
            decimal countTotalDec1500 = 0;
            decimal AverageDec1500 = 0;

            decimal tempTotalDec1600 = 0;
            decimal countTotalDec1600 = 0;
            decimal AverageDec1600 = 0;

            decimal tempTotalDec1700 = 0;
            decimal countTotalDec1700 = 0;
            decimal AverageDec1700 = 0;

            decimal tempTotalDec1800 = 0;
            decimal countTotalDec1800 = 0;
            decimal AverageDec1800 = 0;

            decimal tempTotalDec1900 = 0;
            decimal countTotalDec1900 = 0;
            decimal AverageDec1900 = 0;

            decimal tempTotalDec2000 = 0;
            decimal countTotalDec2000 = 0;
            decimal AverageDec2000 = 0;
            #endregion


            //file is the full path of the directory.  
            //targePath is the name of the file, it will create a new file with the information from the parent extracted.

            StringBuilder sb = new StringBuilder();
            string path = file;
            string targetPath = "C:\\CSV_Read_Project\\temp\\SolarData.txt";

            Stream myfile;
            if (!File.Exists(targetPath))
            {
                myfile = File.Create(targetPath);
                myfile.Close();
            }

            //sb.Append("[");
            //File.AppendAllText(targetPath, sb.ToString());
            //File.AppendAllText(targetPath, Environment.NewLine);
            //sb.Clear();

            string[] row = File.ReadAllLines(path);

            int count = 0;


            for (int i = 0; i < row.Length; i++)
            {
                //FIRST LOOP CREATES A LITTERAL STRING WITH SEPERATORS.  ONE STRING PER LINE.  SECOND STRING ARRAY "ROWS" SPLITS THE STRING INTO ITS INDIVIDUAL CELLS.  

                string[] cell = row[i].Split(',');

                for (int j = 0; j < cell.Length; j++)
                {
                    //Data to JSON that does not require Math.  This is all my header data from each file.  City, state, Lat/Long.
                    
                    if (i == 0 && count == 0)
                    {
                        sb.Append("{");
                        File.AppendAllText(targetPath, sb.ToString());
                        //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
                        File.AppendAllText(targetPath, Environment.NewLine);
                        sb.Clear();
                        count++;
                    }

                    if (i == 0 && count == 1)
                    {

                        sb.Append($"\"City\": {cell[1]}" + ',');
                        File.AppendAllText(targetPath, sb.ToString());
                        File.AppendAllText(targetPath, Environment.NewLine);
                        sb.Clear();

                        sb.Append($"\"State\": \"{cell[2]}\"" + ',');
                        File.AppendAllText(targetPath, sb.ToString());
                        File.AppendAllText(targetPath, Environment.NewLine);
                        sb.Clear();

                        sb.Append($"\"lat\": {cell[4]}" + ',');
                        File.AppendAllText(targetPath, sb.ToString());
                        File.AppendAllText(targetPath, Environment.NewLine);
                        sb.Clear();

                        sb.Append($"\"lon\": {cell[5]}" + ',');
                        File.AppendAllText(targetPath, sb.ToString());
                        File.AppendAllText(targetPath, Environment.NewLine);
                        sb.Clear();
                        
                        count++;
                        break;
                    }

                    sb.Clear();
                    count = 0;
                }

                try
                {
                    /* this is where my math takes place.  First storing the month and time data into its respective variable.  Then calculating the average
                     * of that month/hour combo and storing it in the respective totals above.
                     * */

                    //January Averages over the hours.
                    #region
                    if (cell[0][0].ToString() + cell[0][1].ToString() == "01" && cell[1] == "06:00")
                    {
                        tempTotalJan0600 = tempTotalJan0600 + Convert.ToInt32(cell[4]);
                        countTotalJan0600++;
                        //Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalJan0600);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "01" && cell[1] == "07:00")
                    {
                        tempTotalJan0700 = tempTotalJan0700 + Convert.ToInt32(cell[4]);
                        countTotalJan0700++;
                        //Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalJan0700);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "01" && cell[1] == "08:00")
                    {
                        tempTotalJan0800 = tempTotalJan0800 + Convert.ToInt32(cell[4]);
                        countTotalJan0800++;
                        // Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalJan0800);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "01" && cell[1] == "09:00")
                    {
                        tempTotalJan0900 = tempTotalJan0900 + Convert.ToInt32(cell[4]);
                        countTotalJan0900++;
                        // Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalJan0900);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "01" && cell[1] == "10:00")
                    {
                        tempTotalJan1000 = tempTotalJan1000 + Convert.ToInt32(cell[4]);
                        countTotalJan1000++;
                        //Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalJan1000);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "01" && cell[1] == "11:00")
                    {
                        tempTotalJan1100 = tempTotalJan1100 + Convert.ToInt32(cell[4]);
                        countTotalJan1100++;
                        // Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalJan1100);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "01" && cell[1] == "12:00")
                    {
                        tempTotalJan1200 = tempTotalJan1200 + Convert.ToInt32(cell[4]);
                        countTotalJan1200++;
                        // Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalJan1200);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "01" && cell[1] == "13:00")
                    {
                        tempTotalJan1300 = tempTotalJan1300 + Convert.ToInt32(cell[4]);
                        countTotalJan1300++;
                        //Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalJan1300);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "01" && cell[1] == "14:00")
                    {
                        tempTotalJan1400 = tempTotalJan1400 + Convert.ToInt32(cell[4]);
                        countTotalJan1400++;
                        // Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalJan1400);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "01" && cell[1] == "15:00")
                    {
                        tempTotalJan1500 = tempTotalJan1500 + Convert.ToInt32(cell[4]);
                        countTotalJan1500++;
                        //Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalJan1500);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "01" && cell[1] == "16:00")
                    {
                        tempTotalJan1600 = tempTotalJan1600 + Convert.ToInt32(cell[4]);
                        countTotalJan1600++;
                        //Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalJan1600);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "01" && cell[1] == "17:00")
                    {
                        tempTotalJan1700 = tempTotalJan1700 + Convert.ToInt32(cell[4]);
                        countTotalJan1700++;
                        //Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalJan1700);
                    }


                    if (cell[0][0].ToString() + cell[0][1].ToString() == "01" && cell[1] == "18:00")
                    {
                        tempTotalJan1800 = tempTotalJan1800 + Convert.ToInt32(cell[4]);
                        countTotalJan1800++;
                        //Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalJan1800);
                    }


                    if (cell[0][0].ToString() + cell[0][1].ToString() == "01" && cell[1] == "19:00")
                    {
                        tempTotalJan1900 = tempTotalJan1900 + Convert.ToInt32(cell[4]);
                        countTotalJan1900++;
                        //Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalJan1900);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "01" && cell[1] == "20:00")
                    {
                        tempTotalJan2000 = tempTotalJan2000 + Convert.ToInt32(cell[4]);
                        countTotalJan2000++;
                        // Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalJan2000);
                    }
                    #endregion

                    //Feb Averages over the hours.
                    #region
                    if (cell[0][0].ToString() + cell[0][1].ToString() == "02" && cell[1] == "06:00")
                    {
                        tempTotalFeb0600 = tempTotalFeb0600 + Convert.ToInt32(cell[4]);
                        countTotalFeb0600++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "02" && cell[1] == "07:00")
                    {
                        tempTotalFeb0700 = tempTotalFeb0700 + Convert.ToInt32(cell[4]);
                        countTotalFeb0700++;
                    }

                    if  (cell[0][0].ToString() + cell[0][1].ToString() == "02" && cell[1] == "08:00")
                    {
                        tempTotalFeb0800 = tempTotalFeb0800 + Convert.ToInt32(cell[4]);
                        countTotalFeb0800++;
                    }

                        if(cell[0][0].ToString() + cell[0][1].ToString() == "02" && cell[1] == "09:00")
                    {
                        tempTotalFeb0900 = tempTotalFeb0900 + Convert.ToInt32(cell[4]);
                        countTotalFeb0900++;
                    }

                   if  (cell[0][0].ToString() + cell[0][1].ToString() == "02" && cell[1] == "10:00")
                    {
                        tempTotalFeb1000 = tempTotalFeb1000 + Convert.ToInt32(cell[4]);
                        countTotalFeb1000++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "02" && cell[1] == "11:00")
                    {
                        tempTotalFeb1100 = tempTotalFeb1100 + Convert.ToInt32(cell[4]);
                        countTotalFeb1100++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "02" && cell[1] == "12:00")
                    {
                        tempTotalFeb1200 = tempTotalFeb1200 + Convert.ToInt32(cell[4]);
                        countTotalFeb1200++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "02" && cell[1] == "13:00")
                    {
                        tempTotalFeb1300 = tempTotalFeb1300 + Convert.ToInt32(cell[4]);
                        countTotalFeb1300++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "02" && cell[1] == "14:00")
                    {
                        tempTotalFeb1400 = tempTotalFeb1400 + Convert.ToInt32(cell[4]);
                        countTotalFeb1400++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "02" && cell[1] == "15:00")
                    {
                        tempTotalFeb1500 = tempTotalFeb1500 + Convert.ToInt32(cell[4]);
                        countTotalFeb1500++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "02" && cell[1] == "16:00")
                    {
                        tempTotalFeb1600 = tempTotalFeb1600 + Convert.ToInt32(cell[4]);
                        countTotalFeb1600++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "02" && cell[1] == "17:00")
                    {
                        tempTotalFeb1700 = tempTotalFeb1700 + Convert.ToInt32(cell[4]);
                        countTotalFeb1700++;
                    }


                    if (cell[0][0].ToString() + cell[0][1].ToString() == "02" && cell[1] == "18:00")
                    {
                        tempTotalFeb1800 = tempTotalFeb1800 + Convert.ToInt32(cell[4]);
                        countTotalFeb1800++;
                    }


                    if (cell[0][0].ToString() + cell[0][1].ToString() == "02" && cell[1] == "19:00")
                    {
                        tempTotalFeb1900 = tempTotalFeb1900 + Convert.ToInt32(cell[4]);
                        countTotalFeb1900++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "02" && cell[1] == "20:00")
                    {
                        tempTotalFeb2000 = tempTotalFeb2000 + Convert.ToInt32(cell[4]);
                        countTotalFeb2000++;
                    }
                    #endregion

                    //March Averages over the hours
                    #region

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "03" && cell[1] == "06:00")
                    {
                        tempTotalMar0600 = tempTotalMar0600 + Convert.ToInt32(cell[4]);
                        countTotalMar0600++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "03" && cell[1] == "07:00")
                    {
                        tempTotalMar0700 = tempTotalMar0700 + Convert.ToInt32(cell[4]);
                        countTotalMar0700++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "03" && cell[1] == "08:00")
                    {
                        tempTotalMar0800 = tempTotalMar0800 + Convert.ToInt32(cell[4]);
                        countTotalMar0800++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "03" && cell[1] == "09:00")
                    {
                        tempTotalMar0900 = tempTotalMar0900 + Convert.ToInt32(cell[4]);
                        countTotalMar0900++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "03" && cell[1] == "10:00")
                    {
                        tempTotalMar1000 = tempTotalMar1000 + Convert.ToInt32(cell[4]);
                        countTotalMar1000++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "03" && cell[1] == "11:00")
                    {
                        tempTotalMar1100 = tempTotalMar1100 + Convert.ToInt32(cell[4]);
                        countTotalMar1100++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "03" && cell[1] == "12:00")
                    {
                        tempTotalMar1200 = tempTotalMar1200 + Convert.ToInt32(cell[4]);
                        countTotalMar1200++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "03" && cell[1] == "13:00")
                    {
                        tempTotalMar1300 = tempTotalMar1300 + Convert.ToInt32(cell[4]);
                        countTotalMar1300++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "03" && cell[1] == "14:00")
                    {
                        tempTotalMar1400 = tempTotalMar1400 + Convert.ToInt32(cell[4]);
                        countTotalMar1400++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "03" && cell[1] == "15:00")
                    {
                        tempTotalMar1500 = tempTotalMar1500 + Convert.ToInt32(cell[4]);
                        countTotalMar1500++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "03" && cell[1] == "16:00")
                    {
                        tempTotalMar1600 = tempTotalMar1600 + Convert.ToInt32(cell[4]);
                        countTotalMar1600++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "03" && cell[1] == "17:00")
                    {
                        tempTotalMar1700 = tempTotalMar1700 + Convert.ToInt32(cell[4]);
                        countTotalMar1700++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "03" && cell[1] == "18:00")
                    {
                        tempTotalMar1800 = tempTotalMar1800 + Convert.ToInt32(cell[4]);
                        countTotalMar1800++;
                    }


                    if (cell[0][0].ToString() + cell[0][1].ToString() == "03" && cell[1] == "19:00")
                    {
                        tempTotalMar1900 = tempTotalMar1900 + Convert.ToInt32(cell[4]);
                        countTotalMar1900++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "03" && cell[1] == "20:00")
                    {
                        tempTotalMar2000 = tempTotalMar2000 + Convert.ToInt32(cell[4]);
                        countTotalMar2000++;
                    }
                    #endregion

                    //April Averages over the hours
                    #region

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "04" && cell[1] == "06:00")
                    {
                        tempTotalApr0600 = tempTotalApr0600 + Convert.ToInt32(cell[4]);
                        countTotalApr0600++;
                        Console.WriteLine(cell[0]);
                        Console.WriteLine(tempTotalApr0600);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "04" && cell[1] == "07:00")
                    {
                        tempTotalApr0700 = tempTotalApr0700 + Convert.ToInt32(cell[4]);
                        countTotalApr0700++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "04" && cell[1] == "08:00")
                    {
                        tempTotalApr0800 = tempTotalApr0800 + Convert.ToInt32(cell[4]);
                        countTotalApr0800++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "04" && cell[1] == "09:00")
                    {
                        tempTotalApr0900 = tempTotalApr0900 + Convert.ToInt32(cell[4]);
                        countTotalApr0900++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "04" && cell[1] == "10:00")
                    {
                        tempTotalApr1000 = tempTotalApr1000 + Convert.ToInt32(cell[4]);
                        countTotalApr1000++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "04" && cell[1] == "11:00")
                    {
                        tempTotalApr1100 = tempTotalApr1100 + Convert.ToInt32(cell[4]);
                        countTotalApr1100++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "04" && cell[1] == "12:00")
                    {
                        tempTotalApr1200 = tempTotalApr1200 + Convert.ToInt32(cell[4]);
                        countTotalApr1200++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "04" && cell[1] == "13:00")
                    {
                        tempTotalApr1300 = tempTotalApr1300 + Convert.ToInt32(cell[4]);
                        countTotalApr1300++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "04" && cell[1] == "14:00")
                    {
                        tempTotalApr1400 = tempTotalApr1400 + Convert.ToInt32(cell[4]);
                        countTotalApr1400++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "04" && cell[1] == "15:00")
                    {
                        tempTotalApr1500 = tempTotalApr1500 + Convert.ToInt32(cell[4]);
                        countTotalApr1500++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "04" && cell[1] == "16:00")
                    {
                        tempTotalApr1600 = tempTotalApr1600 + Convert.ToInt32(cell[4]);
                        countTotalApr1600++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "04" && cell[1] == "17:00")
                    {
                        tempTotalApr1700 = tempTotalApr1700 + Convert.ToInt32(cell[4]);
                        countTotalApr1700++;
                    }


                    if (cell[0][0].ToString() + cell[0][1].ToString() == "04" && cell[1] == "18:00")
                    {
                        tempTotalApr1800 = tempTotalApr1800 + Convert.ToInt32(cell[4]);
                        countTotalApr1800++;
                    }


                    if (cell[0][0].ToString() + cell[0][1].ToString() == "04" && cell[1] == "19:00")
                    {
                        tempTotalApr1900 = tempTotalApr1900 + Convert.ToInt32(cell[4]);
                        countTotalApr1900++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "04" && cell[1] == "20:00")
                    {
                        tempTotalApr2000 = tempTotalApr2000 + Convert.ToInt32(cell[4]);
                        countTotalApr2000++;
                    }
                    #endregion

                    //May Averages over the hours
                    #region

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "05" && cell[1] == "06:00")
                    {
                        tempTotalMay0600 = tempTotalMay0600 + Convert.ToInt32(cell[4]);
                        countTotalMay0600++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "05" && cell[1] == "07:00")
                    {
                        tempTotalMay0700 = tempTotalMay0700 + Convert.ToInt32(cell[4]);
                        countTotalMay0700++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "05" && cell[1] == "08:00")
                    {
                        tempTotalMay0800 = tempTotalMay0800 + Convert.ToInt32(cell[4]);
                        countTotalMay0800++;
                    }
                    if (cell[0][0].ToString() + cell[0][1].ToString() == "05" && cell[1] == "09:00")
                    {
                        tempTotalMay0900 = tempTotalMay0900 + Convert.ToInt32(cell[4]);
                        countTotalMay0900++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "05" && cell[1] == "10:00")
                    {
                        tempTotalMay1000 = tempTotalMay1000 + Convert.ToInt32(cell[4]);
                        countTotalMay1000++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "05" && cell[1] == "11:00")
                    {
                        tempTotalMay1100 = tempTotalMay1100 + Convert.ToInt32(cell[4]);
                        countTotalMay1100++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "05" && cell[1] == "12:00")
                    {
                        tempTotalMay1200 = tempTotalMay1200 + Convert.ToInt32(cell[4]);
                        countTotalMay1200++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "05" && cell[1] == "13:00")
                    {
                        tempTotalMay1300 = tempTotalMay1300 + Convert.ToInt32(cell[4]);
                        countTotalMay1300++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "05" && cell[1] == "14:00")
                    {
                        tempTotalMay1400 = tempTotalMay1400 + Convert.ToInt32(cell[4]);
                        countTotalMay1400++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "05" && cell[1] == "15:00")
                    {
                        tempTotalMay1500 = tempTotalMay1500 + Convert.ToInt32(cell[4]);
                        countTotalMay1500++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "05" && cell[1] == "16:00")
                    {
                        tempTotalMay1600 = tempTotalMay1600 + Convert.ToInt32(cell[4]);
                        countTotalMay1600++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "05" && cell[1] == "17:00")
                    {
                        tempTotalMay1700 = tempTotalMay1700 + Convert.ToInt32(cell[4]);
                        countTotalMay1700++;
                    }


                    if (cell[0][0].ToString() + cell[0][1].ToString() == "05" && cell[1] == "18:00")
                    {
                        tempTotalMay1800 = tempTotalMay1800 + Convert.ToInt32(cell[4]);
                        countTotalMay1800++;
                    }


                    if (cell[0][0].ToString() + cell[0][1].ToString() == "05" && cell[1] == "19:00")
                    {
                        tempTotalMay1900 = tempTotalMay1900 + Convert.ToInt32(cell[4]);
                        countTotalMay1900++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "05" && cell[1] == "20:00")
                    {
                        tempTotalMay2000 = tempTotalMay2000 + Convert.ToInt32(cell[4]);
                        countTotalMay2000++;
                    }
                    #endregion

                    //Jun Averages over the hours
                    #region

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "06" && cell[1] == "06:00")
                    {
                        tempTotalJun0600 = tempTotalJun0600 + Convert.ToInt32(cell[4]);
                        countTotalJun0600++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "06" && cell[1] == "07:00")
                    {
                        tempTotalJun0700 = tempTotalJun0700 + Convert.ToInt32(cell[4]);
                        countTotalJun0700++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "06" && cell[1] == "08:00")
                    {
                        tempTotalJun0800 = tempTotalJun0800 + Convert.ToInt32(cell[4]);
                        countTotalJun0800++;
                    }
                    if (cell[0][0].ToString() + cell[0][1].ToString() == "06" && cell[1] == "09:00")
                    {
                        tempTotalJun0900 = tempTotalJun0900 + Convert.ToInt32(cell[4]);
                        countTotalJun0900++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "06" && cell[1] == "10:00")
                    {
                        tempTotalJun1000 = tempTotalJun1000 + Convert.ToInt32(cell[4]);
                        countTotalJun1000++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "06" && cell[1] == "11:00")
                    {
                        tempTotalJun1100 = tempTotalJun1100 + Convert.ToInt32(cell[4]);
                        countTotalJun1100++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "06" && cell[1] == "12:00")
                    {
                        tempTotalJun1200 = tempTotalJun1200 + Convert.ToInt32(cell[4]);
                        countTotalJun1200++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "06" && cell[1] == "13:00")
                    {
                        tempTotalJun1300 = tempTotalJun1300 + Convert.ToInt32(cell[4]);
                        countTotalJun1300++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "06" && cell[1] == "14:00")
                    {
                        tempTotalJun1400 = tempTotalJun1400 + Convert.ToInt32(cell[4]);
                        countTotalJun1400++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "06" && cell[1] == "15:00")
                    {
                        tempTotalJun1500 = tempTotalJun1500 + Convert.ToInt32(cell[4]);
                        countTotalJun1500++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "06" && cell[1] == "16:00")
                    {
                        tempTotalJun1600 = tempTotalJun1600 + Convert.ToInt32(cell[4]);
                        countTotalJun1600++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "06" && cell[1] == "17:00")
                    {
                        tempTotalJun1700 = tempTotalJun1700 + Convert.ToInt32(cell[4]);
                        countTotalJun1700++;
                    }


                    if (cell[0][0].ToString() + cell[0][1].ToString() == "06" && cell[1] == "18:00")
                    {
                        tempTotalJun1800 = tempTotalJun1800 + Convert.ToInt32(cell[4]);
                        countTotalJun1800++;
                    }


                    if (cell[0][0].ToString() + cell[0][1].ToString() == "06" && cell[1] == "19:00")
                    {
                        tempTotalJun1900 = tempTotalJun1900 + Convert.ToInt32(cell[4]);
                        countTotalJun1900++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "06" && cell[1] == "20:00")
                    {
                        tempTotalJun2000 = tempTotalJun2000 + Convert.ToInt32(cell[4]);
                        countTotalJun2000++;
                    }
                    #endregion

                    //Jul Averages over the hours
                    #region

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "07" && cell[1] == "06:00")
                    {
                        tempTotalJul0600 = tempTotalJul0600 + Convert.ToInt32(cell[4]);
                        countTotalJul0600++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "07" && cell[1] == "07:00")
                    {
                        tempTotalJul0700 = tempTotalJul0700 + Convert.ToInt32(cell[4]);
                        countTotalJul0700++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "07" && cell[1] == "08:00")
                    {
                        tempTotalJul0800 = tempTotalJul0800 + Convert.ToInt32(cell[4]);
                        countTotalJul0800++;
                    }
                    if (cell[0][0].ToString() + cell[0][1].ToString() == "07" && cell[1] == "09:00")
                    {
                        tempTotalJul0900 = tempTotalJul0900 + Convert.ToInt32(cell[4]);
                        countTotalJul0900++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "07" && cell[1] == "10:00")
                    {
                        tempTotalJul1000 = tempTotalJul1000 + Convert.ToInt32(cell[4]);
                        countTotalJul1000++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "07" && cell[1] == "11:00")
                    {
                        tempTotalJul1100 = tempTotalJul1100 + Convert.ToInt32(cell[4]);
                        countTotalJul1100++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "07" && cell[1] == "12:00")
                    {
                        tempTotalJul1200 = tempTotalJul1200 + Convert.ToInt32(cell[4]);
                        countTotalJul1200++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "07" && cell[1] == "13:00")
                    {
                        tempTotalJul1300 = tempTotalJul1300 + Convert.ToInt32(cell[4]);
                        countTotalJul1300++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "07" && cell[1] == "14:00")
                    {
                        tempTotalJul1400 = tempTotalJul1400 + Convert.ToInt32(cell[4]);
                        countTotalJul1400++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "07" && cell[1] == "15:00")
                    {
                        tempTotalJul1500 = tempTotalJul1500 + Convert.ToInt32(cell[4]);
                        countTotalJul1500++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "07" && cell[1] == "16:00")
                    {
                        tempTotalJul1600 = tempTotalJul1600 + Convert.ToInt32(cell[4]);
                        countTotalJul1600++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "07" && cell[1] == "17:00")
                    {
                        tempTotalJul1700 = tempTotalJul1700 + Convert.ToInt32(cell[4]);
                        countTotalJul1700++;
                    }


                    if (cell[0][0].ToString() + cell[0][1].ToString() == "07" && cell[1] == "18:00")
                    {
                        tempTotalJul1800 = tempTotalJul1800 + Convert.ToInt32(cell[4]);
                        countTotalJul1800++;
                    }


                    if (cell[0][0].ToString() + cell[0][1].ToString() == "07" && cell[1] == "19:00")
                    {
                        tempTotalJul1900 = tempTotalJul1900 + Convert.ToInt32(cell[4]);
                        countTotalJul1900++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "07" && cell[1] == "20:00")
                    {
                        tempTotalJul2000 = tempTotalJul2000 + Convert.ToInt32(cell[4]);
                        countTotalJul2000++;
                    }
                    #endregion

                    //Aug Averages over the hours
                    #region

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "08" && cell[1] == "06:00")
                    {
                        tempTotalAug0600 = tempTotalAug0600 + Convert.ToInt32(cell[4]);
                        countTotalAug0600++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "08" && cell[1] == "07:00")
                    {
                        tempTotalAug0700 = tempTotalAug0700 + Convert.ToInt32(cell[4]);
                        countTotalAug0700++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "08" && cell[1] == "08:00")
                    {
                        tempTotalAug0800 = tempTotalAug0800 + Convert.ToInt32(cell[4]);
                        countTotalAug0800++;
                    }
                    if (cell[0][0].ToString() + cell[0][1].ToString() == "08" && cell[1] == "09:00")
                    {
                        tempTotalAug0900 = tempTotalAug0900 + Convert.ToInt32(cell[4]);
                        countTotalAug0900++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "08" && cell[1] == "10:00")
                    {
                        tempTotalAug1000 = tempTotalAug1000 + Convert.ToInt32(cell[4]);
                        countTotalAug1000++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "08" && cell[1] == "11:00")
                    {
                        tempTotalAug1100 = tempTotalAug1100 + Convert.ToInt32(cell[4]);
                        countTotalAug1100++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "08" && cell[1] == "12:00")
                    {
                        tempTotalAug1200 = tempTotalAug1200 + Convert.ToInt32(cell[4]);
                        countTotalAug1200++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "08" && cell[1] == "13:00")
                    {
                        tempTotalAug1300 = tempTotalAug1300 + Convert.ToInt32(cell[4]);
                        countTotalAug1300++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "08" && cell[1] == "14:00")
                    {
                        tempTotalAug1400 = tempTotalAug1400 + Convert.ToInt32(cell[4]);
                        countTotalAug1400++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "08" && cell[1] == "15:00")
                    {
                        tempTotalAug1500 = tempTotalAug1500 + Convert.ToInt32(cell[4]);
                        countTotalAug1500++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "08" && cell[1] == "16:00")
                    {
                        tempTotalAug1600 = tempTotalAug1600 + Convert.ToInt32(cell[4]);
                        countTotalAug1600++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "08" && cell[1] == "17:00")
                    {
                        tempTotalAug1700 = tempTotalAug1700 + Convert.ToInt32(cell[4]);
                        countTotalAug1700++;
                    }


                    if (cell[0][0].ToString() + cell[0][1].ToString() == "08" && cell[1] == "18:00")
                    {
                        tempTotalAug1800 = tempTotalAug1800 + Convert.ToInt32(cell[4]);
                        countTotalAug1800++;
                    }


                    if (cell[0][0].ToString() + cell[0][1].ToString() == "08" && cell[1] == "19:00")
                    {
                        tempTotalAug1900 = tempTotalAug1900 + Convert.ToInt32(cell[4]);
                        countTotalAug1900++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "08" && cell[1] == "20:00")
                    {
                        tempTotalAug2000 = tempTotalAug2000 + Convert.ToInt32(cell[4]);
                        countTotalAug2000++;
                    }
                    #endregion

                    //Sep Averages over the hours
                    #region

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "09" && cell[1] == "06:00")
                    {
                        tempTotalSep0600 = tempTotalSep0600 + Convert.ToInt32(cell[4]);
                        countTotalSep0600++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "09" && cell[1] == "07:00")
                    {
                        tempTotalSep0700 = tempTotalSep0700 + Convert.ToInt32(cell[4]);
                        countTotalSep0700++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "09" && cell[1] == "08:00")
                    {
                        tempTotalSep0800 = tempTotalSep0800 + Convert.ToInt32(cell[4]);
                        countTotalSep0800++;
                    }
                    if (cell[0][0].ToString() + cell[0][1].ToString() == "09" && cell[1] == "09:00")
                    {
                        tempTotalSep0900 = tempTotalSep0900 + Convert.ToInt32(cell[4]);
                        countTotalSep0900++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "09" && cell[1] == "10:00")
                    {
                        tempTotalSep1000 = tempTotalSep1000 + Convert.ToInt32(cell[4]);
                        countTotalSep1000++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "09" && cell[1] == "11:00")
                    {
                        tempTotalSep1100 = tempTotalSep1100 + Convert.ToInt32(cell[4]);
                        countTotalSep1100++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "09" && cell[1] == "12:00")
                    {
                        tempTotalSep1200 = tempTotalSep1200 + Convert.ToInt32(cell[4]);
                        countTotalSep1200++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "09" && cell[1] == "13:00")
                    {
                        tempTotalSep1300 = tempTotalSep1300 + Convert.ToInt32(cell[4]);
                        countTotalSep1300++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "09" && cell[1] == "14:00")
                    {
                        tempTotalSep1400 = tempTotalSep1400 + Convert.ToInt32(cell[4]);
                        countTotalSep1400++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "09" && cell[1] == "15:00")
                    {
                        tempTotalSep1500 = tempTotalSep1500 + Convert.ToInt32(cell[4]);
                        countTotalSep1500++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "09" && cell[1] == "16:00")
                    {
                        tempTotalSep1600 = tempTotalSep1600 + Convert.ToInt32(cell[4]);
                        countTotalSep1600++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "09" && cell[1] == "17:00")
                    {
                        tempTotalSep1700 = tempTotalSep1700 + Convert.ToInt32(cell[4]);
                        countTotalSep1700++;
                    }


                    if (cell[0][0].ToString() + cell[0][1].ToString() == "09" && cell[1] == "18:00")
                    {
                        tempTotalSep1800 = tempTotalSep1800 + Convert.ToInt32(cell[4]);
                        countTotalSep1800++;
                    }


                    if (cell[0][0].ToString() + cell[0][1].ToString() == "09" && cell[1] == "19:00")
                    {
                        tempTotalSep1900 = tempTotalSep1900 + Convert.ToInt32(cell[4]);
                        countTotalSep1900++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "09" && cell[1] == "20:00")
                    {
                        tempTotalSep2000 = tempTotalSep2000 + Convert.ToInt32(cell[4]);
                        countTotalSep2000++;
                    }
                    #endregion

                    //Oct Averages over the hours
                    #region

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "10" && cell[1] == "06:00")
                    {
                        tempTotalOct0600 = tempTotalOct0600 + Convert.ToInt32(cell[4]);
                        countTotalOct0600++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "10" && cell[1] == "07:00")
                    {
                        tempTotalOct0700 = tempTotalOct0700 + Convert.ToInt32(cell[4]);
                        countTotalOct0700++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "10" && cell[1] == "08:00")
                    {
                        tempTotalOct0800 = tempTotalOct0800 + Convert.ToInt32(cell[4]);
                        countTotalOct0800++;
                    }
                    if (cell[0][0].ToString() + cell[0][1].ToString() == "10" && cell[1] == "09:00")
                    {
                        tempTotalOct0900 = tempTotalOct0900 + Convert.ToInt32(cell[4]);
                        countTotalOct0900++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "10" && cell[1] == "10:00")
                    {
                        tempTotalOct1000 = tempTotalOct1000 + Convert.ToInt32(cell[4]);
                        countTotalOct1000++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "10" && cell[1] == "11:00")
                    {
                        tempTotalOct1100 = tempTotalOct1100 + Convert.ToInt32(cell[4]);
                        countTotalOct1100++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "10" && cell[1] == "12:00")
                    {
                        tempTotalOct1200 = tempTotalOct1200 + Convert.ToInt32(cell[4]);
                        countTotalOct1200++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "10" && cell[1] == "13:00")
                    {
                        tempTotalOct1300 = tempTotalOct1300 + Convert.ToInt32(cell[4]);
                        countTotalOct1300++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "10" && cell[1] == "14:00")
                    {
                        tempTotalOct1400 = tempTotalOct1400 + Convert.ToInt32(cell[4]);
                        countTotalOct1400++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "10" && cell[1] == "15:00")
                    {
                        tempTotalOct1500 = tempTotalOct1500 + Convert.ToInt32(cell[4]);
                        countTotalOct1500++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "10" && cell[1] == "16:00")
                    {
                        tempTotalOct1600 = tempTotalOct1600 + Convert.ToInt32(cell[4]);
                        countTotalOct1600++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "10" && cell[1] == "17:00")
                    {
                        tempTotalOct1700 = tempTotalOct1700 + Convert.ToInt32(cell[4]);
                        countTotalOct1700++;
                    }


                    if (cell[0][0].ToString() + cell[0][1].ToString() == "10" && cell[1] == "18:00")
                    {
                        tempTotalOct1800 = tempTotalOct1800 + Convert.ToInt32(cell[4]);
                        countTotalOct1800++;
                    }


                    if (cell[0][0].ToString() + cell[0][1].ToString() == "10" && cell[1] == "19:00")
                    {
                        tempTotalOct1900 = tempTotalOct1900 + Convert.ToInt32(cell[4]);
                        countTotalOct1900++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "10" && cell[1] == "20:00")
                    {
                        tempTotalOct2000 = tempTotalOct2000 + Convert.ToInt32(cell[4]);
                        countTotalOct2000++;
                    }
                    #endregion

                    //Nov Averages over the hours
                    #region

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "11" && cell[1] == "06:00")
                    {
                        tempTotalNov0600 = tempTotalNov0600 + Convert.ToInt32(cell[4]);
                        countTotalNov0600++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "11" && cell[1] == "07:00")
                    {
                        tempTotalNov0700 = tempTotalNov0700 + Convert.ToInt32(cell[4]);
                        countTotalNov0700++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "11" && cell[1] == "08:00")
                    {
                        tempTotalNov0800 = tempTotalNov0800 + Convert.ToInt32(cell[4]);
                        countTotalNov0800++;
                    }
                    if (cell[0][0].ToString() + cell[0][1].ToString() == "11" && cell[1] == "09:00")
                    {
                        tempTotalNov0900 = tempTotalNov0900 + Convert.ToInt32(cell[4]);
                        countTotalNov0900++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "11" && cell[1] == "10:00")
                    {
                        tempTotalNov1000 = tempTotalNov1000 + Convert.ToInt32(cell[4]);
                        countTotalNov1000++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "11" && cell[1] == "11:00")
                    {
                        tempTotalNov1100 = tempTotalNov1100 + Convert.ToInt32(cell[4]);
                        countTotalNov1100++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "11" && cell[1] == "12:00")
                    {
                        tempTotalNov1200 = tempTotalNov1200 + Convert.ToInt32(cell[4]);
                        countTotalNov1200++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "11" && cell[1] == "13:00")
                    {
                        tempTotalNov1300 = tempTotalNov1300 + Convert.ToInt32(cell[4]);
                        countTotalNov1300++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "11" && cell[1] == "14:00")
                    {
                        tempTotalNov1400 = tempTotalNov1400 + Convert.ToInt32(cell[4]);
                        countTotalNov1400++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "11" && cell[1] == "15:00")
                    {
                        tempTotalNov1500 = tempTotalNov1500 + Convert.ToInt32(cell[4]);
                        countTotalNov1500++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "11" && cell[1] == "16:00")
                    {
                        tempTotalNov1600 = tempTotalNov1600 + Convert.ToInt32(cell[4]);
                        countTotalNov1600++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "11" && cell[1] == "17:00")
                    {
                        tempTotalNov1700 = tempTotalNov1700 + Convert.ToInt32(cell[4]);
                        countTotalNov1700++;
                    }


                    if (cell[0][0].ToString() + cell[0][1].ToString() == "11" && cell[1] == "18:00")
                    {
                        tempTotalNov1800 = tempTotalNov1800 + Convert.ToInt32(cell[4]);
                        countTotalNov1800++;
                    }


                    if (cell[0][0].ToString() + cell[0][1].ToString() == "11" && cell[1] == "19:00")
                    {
                        tempTotalNov1900 = tempTotalNov1900 + Convert.ToInt32(cell[4]);
                        countTotalNov1900++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "11" && cell[1] == "20:00")
                    {
                        tempTotalNov2000 = tempTotalNov2000 + Convert.ToInt32(cell[4]);
                        countTotalNov2000++;
                    }
                    #endregion

                    //Dec Averages over the hours
                    #region

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "12" && cell[1] == "06:00")
                    {
                        tempTotalDec0600 = tempTotalDec0600 + Convert.ToInt32(cell[4]);
                        countTotalDec0600++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "12" && cell[1] == "07:00")
                    {
                        tempTotalDec0700 = tempTotalDec0700 + Convert.ToInt32(cell[4]);
                        countTotalDec0700++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "12" && cell[1] == "08:00")
                    {
                        tempTotalDec0800 = tempTotalDec0800 + Convert.ToInt32(cell[4]);
                        countTotalDec0800++;
                    }
                    if (cell[0][0].ToString() + cell[0][1].ToString() == "12" && cell[1] == "09:00")
                    {
                        tempTotalDec0900 = tempTotalDec0900 + Convert.ToInt32(cell[4]);
                        countTotalDec0900++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "12" && cell[1] == "10:00")
                    {
                        tempTotalDec1000 = tempTotalDec1000 + Convert.ToInt32(cell[4]);
                        countTotalDec1000++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "12" && cell[1] == "11:00")
                    {
                        tempTotalDec1100 = tempTotalDec1100 + Convert.ToInt32(cell[4]);
                        countTotalDec1100++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "12" && cell[1] == "12:00")
                    {
                        tempTotalDec1200 = tempTotalDec1200 + Convert.ToInt32(cell[4]);
                        countTotalDec1200++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "12" && cell[1] == "13:00")
                    {
                        tempTotalDec1300 = tempTotalDec1300 + Convert.ToInt32(cell[4]);
                        countTotalDec1300++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "12" && cell[1] == "14:00")
                    {
                        tempTotalDec1400 = tempTotalDec1400 + Convert.ToInt32(cell[4]);
                        countTotalDec1400++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "12" && cell[1] == "15:00")
                    {
                        tempTotalDec1500 = tempTotalDec1500 + Convert.ToInt32(cell[4]);
                        countTotalDec1500++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "12" && cell[1] == "16:00")
                    {
                        tempTotalDec1600 = tempTotalDec1600 + Convert.ToInt32(cell[4]);
                        countTotalDec1600++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "12" && cell[1] == "17:00")
                    {
                        tempTotalDec1700 = tempTotalDec1700 + Convert.ToInt32(cell[4]);
                        countTotalDec1700++;
                    }


                    if (cell[0][0].ToString() + cell[0][1].ToString() == "12" && cell[1] == "18:00")
                    {
                        tempTotalDec1800 = tempTotalDec1800 + Convert.ToInt32(cell[4]);
                        countTotalDec1800++;
                    }


                    if (cell[0][0].ToString() + cell[0][1].ToString() == "12" && cell[1] == "19:00")
                    {
                        tempTotalDec1900 = tempTotalDec1900 + Convert.ToInt32(cell[4]);
                        countTotalDec1900++;
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "12" && cell[1] == "20:00")
                    {
                        tempTotalDec2000 = tempTotalDec2000 + Convert.ToInt32(cell[4]);
                        countTotalDec2000++;
                    }
                    #endregion


                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }

            /* Calculate averages and append to .txt file. in JSON format.  This file will hold a lot of data.
             * Eventually, this is one area I will augment to migrate to a database.  If I want to hold all 70+ Colums
             * of data, I can omit most of this code and simply use the rows and cells loops above.  This will dramatically simplify the code
             * but it glances over the point of this exercise.
             * 
             * All output power ratings are in Watts/Square Meter
             */

            //Jan ToFile After Math
            #region
            

            Console.WriteLine(Math.Floor(tempTotalJan0600) + " is the average for Jan @ 0600: ");
            AverageJan0600 = tempTotalJan0600 / countTotalJan0600;

            monthAverageJan += AverageJan0600;
            sb.Append($"\"Jan0600\": {Math.Floor(AverageJan0600)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJan0700 = tempTotalJan0700 / countTotalJan0700;
            Console.WriteLine(Math.Floor(AverageJan0700) + " is the average for Jan @ 0700");

            monthAverageJan += AverageJan0700;
            sb.Append($"\"Jan0700\": {Math.Floor(AverageJan0700)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJan0800 = tempTotalJan0800 / countTotalJan0800;
            Console.WriteLine(Math.Floor(AverageJan0800) + " is the average for Jan @ 0800");
            sb.Append($"\"Jan0800\": {Math.Floor(AverageJan0800)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJan0900 = tempTotalJan0900 / countTotalJan0900;
            Console.WriteLine(Math.Floor(AverageJan0900) + " is the average for Jan @ 0900");

            monthAverageJan += AverageJan0900;
            sb.Append($"\"Jan0900\": {Math.Floor(AverageJan0900)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJan1000 = tempTotalJan1000 / countTotalJan1000;
            Console.WriteLine(Math.Floor(AverageJan1000) + " is the average for Jan @ 1000");

            monthAverageJan += AverageJan1000;
            sb.Append($"\"Jan1000\": {Math.Floor(AverageJan1000)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJan1100 = tempTotalJan1100 / countTotalJan1100;
            Console.WriteLine(Math.Floor(AverageJan1100) + " is the average for Jan @ 1100");

            monthAverageJan += AverageJan1100;
            sb.Append($"\"Jan1100\": {Math.Floor(AverageJan1100)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJan1200 = tempTotalJan1200 / countTotalJan1200;
            Console.WriteLine(Math.Floor(AverageJan1200) + " is the average for Jan @ 1200");

            monthAverageJan += AverageJan1200;
            sb.Append($"\"Jan1200\": {Math.Floor(AverageJan1200)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJan1300 = tempTotalJan1300 / countTotalJan1300;
            Console.WriteLine(Math.Floor(AverageJan1300) + " is the average for Jan @ 1300");


            monthAverageJan += AverageJan1300;
            sb.Append($"\"Jan1300\": {Math.Floor(AverageJan1300)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJan1400 = tempTotalJan1400 / countTotalJan1400;
            Console.WriteLine(Math.Floor(AverageJan1400) + " is the average for Jan @ 1400");

            monthAverageJan += AverageJan1400;
            sb.Append($"\"Jan1400\": {Math.Floor(AverageJan1400)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJan1500 = tempTotalJan1500 / countTotalJan1500;
            Console.WriteLine(Math.Floor(AverageJan1500) + " is the average for Jan @ 1500");

            monthAverageJan += AverageJan1500;
            sb.Append($"\"Jan1500\": {Math.Floor(AverageJan1500)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJan1600 = tempTotalJan1600 / countTotalJan1600;
            Console.WriteLine(Math.Floor(AverageJan1600) + " is the average for Jan @ 1600");

            monthAverageJan += AverageJan1600;
            sb.Append($"\"Jan1600\": {Math.Floor(AverageJan1600)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJan1700 = tempTotalJan1700 / countTotalJan1700;
            Console.WriteLine(Math.Floor(AverageJan1700) + " is the average for Jan @ 1700");

            monthAverageJan += AverageJan1700;
            sb.Append($"\"Jan1700\": {Math.Floor(AverageJan1700)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJan1800 = tempTotalJan1800 / countTotalJan1800;
            Console.WriteLine(Math.Floor(AverageJan1800) + " is the average for Jan @ 1800");

            monthAverageJan += AverageJan1800;
            sb.Append($"\"Jan1800\": {Math.Floor(AverageJan1800)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJan1900 = tempTotalJan1900 / countTotalJan1900;
            Console.WriteLine(Math.Floor(AverageJan1900) + " is the average for Jan @ 1900");

            monthAverageJan += AverageJan1900;
            sb.Append($"\"Jan1900\": {Math.Floor(AverageJan1900)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJan2000 = tempTotalJan2000 / countTotalJan2000;
            Console.WriteLine(Math.Floor(AverageJan2000) + " is the average for Jan @ 1700");

            monthAverageJan += AverageJan2000;
            sb.Append($"\"Jan2000\": {Math.Floor(AverageJan2000)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            Console.WriteLine( Math.Floor(monthAverageJan) + " is the monthly average for Jan");
            sb.Append($"\"JanAverage\": {Math.Floor(monthAverageJan)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();



            #endregion

            //Feb ToFile After Math
            #region

           
            Console.WriteLine(Math.Floor(tempTotalFeb0600) + " is the average for Feb @ 0600: ");
            AverageFeb0600 = tempTotalFeb0600 / countTotalFeb0600;

            AverageForMonthFeb += AverageFeb0600;

            sb.Append($"\"Feb0600\": {Math.Floor(AverageFeb0600)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageFeb0700 = tempTotalFeb0700 / countTotalFeb0700;
            Console.WriteLine(Math.Floor(AverageFeb0700) + " is the average for Feb @ 0700");
            AverageForMonthFeb += AverageFeb0700;
            sb.Append($"\"Feb0700\": {Math.Floor(AverageFeb0700)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageFeb0800 = tempTotalFeb0800 / countTotalFeb0800;
            Console.WriteLine(Math.Floor(AverageFeb0800) + " is the average for Feb @ 0800");
            AverageForMonthFeb += AverageFeb0800;
            sb.Append($"\"Feb0800\": {Math.Floor(AverageFeb0800)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageFeb0900 = tempTotalFeb0900 / countTotalFeb0900;
            Console.WriteLine(Math.Floor(AverageFeb0900) + " is the average for Feb @ 0900");
            AverageForMonthFeb += AverageFeb0900;
            sb.Append($"\"Feb0900\": {Math.Floor(AverageFeb0900)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageFeb1000 = tempTotalFeb1000 / countTotalFeb1000;
            Console.WriteLine(Math.Floor(AverageFeb1000) + " is the average for Feb @ 1000");
            AverageForMonthFeb += AverageFeb1000;
            sb.Append($"\"Feb1000\": {Math.Floor(AverageFeb1000)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageFeb1100 = tempTotalFeb1100 / countTotalFeb1100;
            Console.WriteLine(Math.Floor(AverageFeb1100) + " is the average for Feb @ 1100");
            AverageForMonthFeb += AverageFeb1100;
            sb.Append($"\"Feb1100\": {Math.Floor(AverageFeb1100)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageFeb1200 = tempTotalFeb1200 / countTotalFeb1200;
            Console.WriteLine(Math.Floor(AverageFeb1200) + " is the average for Feb @ 1200");
            AverageForMonthFeb += AverageFeb1200;
            sb.Append($"\"Feb1200\": {Math.Floor(AverageFeb1200)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageFeb1300 = tempTotalFeb1300 / countTotalFeb1300;
            Console.WriteLine(Math.Floor(AverageFeb1300) + " is the average for Feb @ 1300");
            AverageForMonthFeb += AverageFeb1300;
            sb.Append($"\"Feb1300\": {Math.Floor(AverageFeb1300)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageFeb1400 = tempTotalFeb1400 / countTotalFeb1400;
            Console.WriteLine(Math.Floor(AverageFeb1400) + " is the average for Feb @ 1400");
            AverageForMonthFeb += AverageFeb1400;
            sb.Append($"\"Feb1400\": {Math.Floor(AverageFeb1400)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageFeb1500 = tempTotalFeb1500 / countTotalFeb1500;
            Console.WriteLine(Math.Floor(AverageFeb1500) + " is the average for Feb @ 1500");
            AverageForMonthFeb += AverageFeb1500;
            sb.Append($"\"Feb1500\": {Math.Floor(AverageFeb1500)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageFeb1600 = tempTotalFeb1600 / countTotalFeb1600;
            Console.WriteLine(Math.Floor(AverageFeb1600) + " is the average for Feb @ 1600");
            AverageForMonthFeb += AverageFeb1600;
            sb.Append($"\"Feb1600\": {Math.Floor(AverageFeb1600)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageFeb1700 = tempTotalFeb1700 / countTotalFeb1700;
            Console.WriteLine(Math.Floor(AverageFeb1700) + " is the average for Feb @ 1700");
            AverageForMonthFeb += AverageFeb1700;
            sb.Append($"\"Feb1700\": {Math.Floor(AverageFeb1700)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageFeb1800 = tempTotalFeb1800 / countTotalFeb1800;
            Console.WriteLine(Math.Floor(AverageFeb1800) + " is the average for Feb @ 1800");
            AverageForMonthFeb += AverageFeb1800;
            sb.Append($"\"Feb1800\": {Math.Floor(AverageFeb1800)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageFeb1900 = tempTotalFeb1900 / countTotalFeb1900;
            Console.WriteLine(Math.Floor(AverageFeb1900) + " is the average for Feb @ 1900");
            AverageForMonthFeb += AverageFeb1900;
            sb.Append($"\"Feb1900\": {Math.Floor(AverageFeb1900)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageFeb2000 = tempTotalFeb2000 / countTotalFeb2000;
            Console.WriteLine(Math.Floor(AverageFeb2000) + " is the average for Feb @ 1700");
            AverageForMonthFeb += AverageFeb2000;
            sb.Append($"\"Feb2000\": {Math.Floor(AverageFeb2000)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();



            Console.WriteLine(Math.Floor(AverageForMonthFeb) + " is the monthly average for Feb");
            sb.Append($"\"FebAverage\": {Math.Floor(AverageForMonthFeb)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();

            #endregion

            //March ToFile After Math
            #region
           
            Console.WriteLine(Math.Floor(tempTotalMar0600) + " is the average for Mar @ 0600: ");
            AverageMar0600 = tempTotalMar0600 / countTotalMar0600;
            averageMarch += AverageMar0600;
            sb.Append($"\"Mar0600\": {Math.Floor(AverageMar0600)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMar0700 = tempTotalMar0700 / countTotalMar0700;
            Console.WriteLine(Math.Floor(AverageMar0700) + " is the average for Mar @ 0700");
            averageMarch += AverageMar0700;
            sb.Append($"\"Mar0700\": {Math.Floor(AverageMar0700)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMar0800 = tempTotalMar0800 / countTotalMar0800;
            Console.WriteLine(Math.Floor(AverageMar0800) + " is the average for Mar @ 0800");
            averageMarch += AverageMar0800;
            sb.Append($"\"Mar0800\": {Math.Floor(AverageMar0800)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMar0900 = tempTotalMar0900 / countTotalMar0900;
            Console.WriteLine(Math.Floor(AverageMar0900) + " is the average for Mar @ 0900");
            averageMarch += AverageMar0900;
            sb.Append($"\"Mar0900\": {Math.Floor(AverageMar0900)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMar1000 = tempTotalMar1000 / countTotalMar1000;
            Console.WriteLine(Math.Floor(AverageMar1000) + " is the average for Mar @ 1000");
            averageMarch += AverageMar1000;
            sb.Append($"\"Mar1000\": {Math.Floor(AverageMar1000)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMar1100 = tempTotalMar1100 / countTotalMar1100;
            Console.WriteLine(Math.Floor(AverageMar1100) + " is the average for Mar @ 1100");
            averageMarch += AverageMar1100;
            sb.Append($"\"Mar1100\": {Math.Floor(AverageMar1100)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMar1200 = tempTotalMar1200 / countTotalMar1200;
            Console.WriteLine(Math.Floor(AverageMar1200) + " is the average for Mar @ 1200");
            averageMarch += AverageMar1200;
            sb.Append($"\"Mar1200\": {Math.Floor(AverageMar1200)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMar1300 = tempTotalMar1300 / countTotalMar1300;
            Console.WriteLine(Math.Floor(AverageMar1300) + " is the average for Mar @ 1300");
            averageMarch += AverageMar1300;
            sb.Append($"\"Mar1300\": {Math.Floor(AverageMar1300)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMar1400 = tempTotalMar1400 / countTotalMar1400;
            Console.WriteLine(Math.Floor(AverageMar1400) + " is the average for Mar @ 1400");
            averageMarch += AverageMar1400;
            sb.Append($"\"Mar1400\": {Math.Floor(AverageMar1400)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMar1500 = tempTotalMar1500 / countTotalMar1500;
            Console.WriteLine(Math.Floor(AverageMar1500) + " is the average for Mar @ 1500");
            averageMarch += AverageMar1500;
            sb.Append($"\"Mar1500\": {Math.Floor(AverageMar1500)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMar1600 = tempTotalMar1600 / countTotalMar1600;
            Console.WriteLine(Math.Floor(AverageMar1600) + " is the average for Mar @ 1600");
            averageMarch += AverageMar1600;
            sb.Append($"\"Mar1600\": {Math.Floor(AverageMar1600)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMar1700 = tempTotalMar1700 / countTotalMar1700;
            Console.WriteLine(Math.Floor(AverageMar1700) + " is the average for Mar @ 1700");
            if (AverageMar1700 > 0)
                averageMarch += AverageMar1700;
            sb.Append($"\"Mar1700\": {Math.Floor(AverageMar1700)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMar1800 = tempTotalMar1800 / countTotalMar1800;
            Console.WriteLine(Math.Floor(AverageMar1800) + " is the average for Mar @ 1800");
            if (AverageMar1800 > 0)
                averageMarch += AverageMar1800;
            sb.Append($"\"Mar1800\": {Math.Floor(AverageMar1800)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMar1900 = tempTotalMar1900 / countTotalMar1900;
            Console.WriteLine(Math.Floor(AverageMar1900) + " is the average for Mar @ 1900");
            if (AverageMar1900 > 0)
                averageMarch += AverageMar1900;
            sb.Append($"\"Mar1900\": {Math.Floor(AverageMar1900)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMar2000 = tempTotalMar2000 / countTotalMar2000;
            Console.WriteLine(Math.Floor(AverageMar2000) + " is the average for Mar @ 1700");
            if (AverageMar2000 > 0)
                averageMarch += AverageMar2000;
            sb.Append($"\"Mar2000\": {Math.Floor(AverageMar2000)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            Console.WriteLine(Math.Floor(averageMarch) + " is the monthly average for Mar");
            sb.Append($"\"MarAverage\": {Math.Floor(averageMarch)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();
        
            #endregion

            //April ToFile After Math
            #region

            Console.WriteLine(Math.Floor(tempTotalApr0600) + " is the average for Apr @ 0600: ");
            AverageApr0600 = tempTotalApr0600 / countTotalApr0600;

            monthAverageApr += AverageApr0600;

            sb.Append($"\"Apr0600\": {Math.Floor(AverageApr0600)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageApr0700 = tempTotalApr0700 / countTotalApr0700;
            Console.WriteLine(Math.Floor(AverageApr0700) + " is the average for Apr @ 0700");

            monthAverageApr += AverageApr0700;
            sb.Append($"\"Apr0700\": {Math.Floor(AverageApr0700)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageApr0800 = tempTotalApr0800 / countTotalApr0800;
            Console.WriteLine(Math.Floor(AverageApr0800) + " is the average for Apr @ 0800");


            monthAverageApr += AverageApr0800;
            sb.Append($"\"Apr0800\": {Math.Floor(AverageApr0800)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageApr0900 = tempTotalApr0900 / countTotalApr0900;
            Console.WriteLine(Math.Floor(AverageApr0900) + " is the average for Apr @ 0900");

            monthAverageApr += AverageApr0900;
            sb.Append($"\"Apr0900\": {Math.Floor(AverageApr0900)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageApr1000 = tempTotalApr1000 / countTotalApr1000;
            Console.WriteLine(Math.Floor(AverageApr1000) + " is the average for Apr @ 1000");

            monthAverageApr += AverageApr1000;
            sb.Append($"\"Apr1000\": {Math.Floor(AverageApr1000)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageApr1100 = tempTotalApr1100 / countTotalApr1100;
            Console.WriteLine(Math.Floor(AverageApr1100) + " is the average for Apr @ 1100");

            monthAverageApr += AverageApr1100;
            sb.Append($"\"Apr1100\": {Math.Floor(AverageApr1100)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageApr1200 = tempTotalApr1200 / countTotalApr1200;
            Console.WriteLine(Math.Floor(AverageApr1200) + " is the average for Apr @ 1200");

            monthAverageApr += AverageApr1200;
            sb.Append($"\"Apr1200\": {Math.Floor(AverageApr1200)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageApr1300 = tempTotalApr1300 / countTotalApr1300;
            Console.WriteLine(Math.Floor(AverageApr1300) + " is the average for Apr @ 1300");

            monthAverageApr += AverageApr1300;
            sb.Append($"\"Apr1300\": {Math.Floor(AverageApr1300)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageApr1400 = tempTotalApr1400 / countTotalApr1400;
            Console.WriteLine(Math.Floor(AverageApr1400) + " is the average for Apr @ 1400");

            monthAverageApr += AverageApr1400;
            sb.Append($"\"Apr1400\": {Math.Floor(AverageApr1400)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageApr1500 = tempTotalApr1500 / countTotalApr1500;
            Console.WriteLine(Math.Floor(AverageApr1500) + " is the average for Apr @ 1500");

            monthAverageApr += AverageApr1500;
            sb.Append($"\"Apr1500\": {Math.Floor(AverageApr1500)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageApr1600 = tempTotalApr1600 / countTotalApr1600;
            Console.WriteLine(Math.Floor(AverageApr1600) + " is the average for Apr @ 1600");

            monthAverageApr += AverageApr1600;
            sb.Append($"\"Apr1600\": {Math.Floor(AverageApr1600)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageApr1700 = tempTotalApr1700 / countTotalApr1700;
            Console.WriteLine(Math.Floor(AverageApr1700) + " is the average for Apr @ 1700");
            monthAverageApr += AverageApr1700;
            sb.Append($"\"Apr1700\": {Math.Floor(AverageApr1700)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageApr1800 = tempTotalApr1800 / countTotalApr1800;
            Console.WriteLine(Math.Floor(AverageApr1800) + " is the average for Apr @ 1800");
            monthAverageApr += AverageApr1800;
            sb.Append($"\"Apr1800\": {Math.Floor(AverageApr1800)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageApr1900 = tempTotalApr1900 / countTotalApr1900;
            Console.WriteLine(Math.Floor(AverageApr1900) + " is the average for Apr @ 1900");
            monthAverageApr += AverageApr1900;
            sb.Append($"\"Apr1900\": {Math.Floor(AverageApr1900)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageApr2000 = tempTotalApr2000 / countTotalApr2000;
            Console.WriteLine(Math.Floor(AverageApr2000) + " is the average for Apr @ 1700");
            monthAverageApr += AverageApr2000;
            sb.Append($"\"Apr2000\": {Math.Floor(AverageApr2000)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            Console.WriteLine(Math.Floor(monthAverageApr) + " is the monthly average for Apr");
            sb.Append($"\"AprAverage\": {Math.Floor(monthAverageApr)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();

            #endregion

            //May ToFile After Math
            #region

            Console.WriteLine(Math.Floor(tempTotalMay0600) + " is the average for May @ 0600: ");
            AverageMay0600 = tempTotalMay0600 / countTotalMay0600;

            monthAverageMay += AverageMay0600;

            sb.Append($"\"May0600\": {Math.Floor(AverageMay0600)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMay0700 = tempTotalMay0700 / countTotalMay0700;
            Console.WriteLine(Math.Floor(AverageMay0700) + " is the average for May @ 0700");

            monthAverageMay += AverageMay0700;
            sb.Append($"\"May0700\": {Math.Floor(AverageMay0700)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMay0800 = tempTotalMay0800 / countTotalMay0800;
            Console.WriteLine(Math.Floor(AverageMay0800) + " is the average for May @ 0800");


            monthAverageMay += AverageMay0800;
            sb.Append($"\"May0800\": {Math.Floor(AverageMay0800)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMay0900 = tempTotalMay0900 / countTotalMay0900;
            Console.WriteLine(Math.Floor(AverageMay0900) + " is the average for May @ 0900");

            monthAverageMay += AverageMay0900;
            sb.Append($"\"May0900\": {Math.Floor(AverageMay0900)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMay1000 = tempTotalMay1000 / countTotalMay1000;
            Console.WriteLine(Math.Floor(AverageMay1000) + " is the average for May @ 1000");

            monthAverageMay += AverageMay1000;
            sb.Append($"\"May1000\": {Math.Floor(AverageMay1000)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMay1100 = tempTotalMay1100 / countTotalMay1100;
            Console.WriteLine(Math.Floor(AverageMay1100) + " is the average for May @ 1100");

            monthAverageMay += AverageMay1100;
            sb.Append($"\"May1100\": {Math.Floor(AverageMay1100)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMay1200 = tempTotalMay1200 / countTotalMay1200;
            Console.WriteLine(Math.Floor(AverageMay1200) + " is the average for May @ 1200");

            monthAverageMay += AverageMay1200;
            sb.Append($"\"May1200\": {Math.Floor(AverageMay1200)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMay1300 = tempTotalMay1300 / countTotalMay1300;
            Console.WriteLine(Math.Floor(AverageMay1300) + " is the average for May @ 1300");

            monthAverageMay += AverageMay1300;
            sb.Append($"\"May1300\": {Math.Floor(AverageMay1300)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMay1400 = tempTotalMay1400 / countTotalMay1400;
            Console.WriteLine(Math.Floor(AverageMay1400) + " is the average for May @ 1400");

            monthAverageMay += AverageMay1400;
            sb.Append($"\"May1400\": {Math.Floor(AverageMay1400)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMay1500 = tempTotalMay1500 / countTotalMay1500;
            Console.WriteLine(Math.Floor(AverageMay1500) + " is the average for May @ 1500");

            monthAverageMay += AverageMay1500;
            sb.Append($"\"May1500\": {Math.Floor(AverageMay1500)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMay1600 = tempTotalMay1600 / countTotalMay1600;
            Console.WriteLine(Math.Floor(AverageMay1600) + " is the average for May @ 1600");

            monthAverageMay += AverageMay1600;
            sb.Append($"\"May1600\": {Math.Floor(AverageMay1600)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMay1700 = tempTotalMay1700 / countTotalMay1700;
            Console.WriteLine(Math.Floor(AverageMay1700) + " is the average for May @ 1700");
            monthAverageMay += AverageMay1700;
            sb.Append($"\"May1700\": {Math.Floor(AverageMay1700)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMay1800 = tempTotalMay1800 / countTotalMay1800;
            Console.WriteLine(Math.Floor(AverageMay1800) + " is the average for May @ 1800");
            monthAverageMay += AverageMay1800;
            sb.Append($"\"May1800\": {Math.Floor(AverageMay1800)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMay1900 = tempTotalMay1900 / countTotalMay1900;
            Console.WriteLine(Math.Floor(AverageMay1900) + " is the average for May @ 1900");
            monthAverageMay += AverageMay1900;
            sb.Append($"\"May1900\": {Math.Floor(AverageMay1900)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMay2000 = tempTotalMay2000 / countTotalMay2000;
            Console.WriteLine(Math.Floor(AverageMay2000) + " is the average for May @ 1700");
            monthAverageMay += AverageMay2000;
            sb.Append($"\"May2000\": {Math.Floor(AverageMay2000)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            Console.WriteLine(Math.Floor(monthAverageMay) + " is the monthly average for May");
            sb.Append($"\"MayAverage\": {Math.Floor(monthAverageMay)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();

            #endregion

            //Jun ToFile After Math
            #region

            Console.WriteLine(Math.Floor(tempTotalJun0600) + " is the average for Jun @ 0600: ");
            AverageJun0600 = tempTotalJun0600 / countTotalJun0600;

            monthAverageJun += AverageJun0600;

            sb.Append($"\"Jun0600\": {Math.Floor(AverageJun0600)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJun0700 = tempTotalJun0700 / countTotalJun0700;
            Console.WriteLine(Math.Floor(AverageJun0700) + " is the average for Jun @ 0700");

            monthAverageJun += AverageJun0700;
            sb.Append($"\"Jun0700\": {Math.Floor(AverageJun0700)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJun0800 = tempTotalJun0800 / countTotalJun0800;
            Console.WriteLine(Math.Floor(AverageJun0800) + " is the average for Jun @ 0800");


            monthAverageJun += AverageJun0800;
            sb.Append($"\"Jun0800\": {Math.Floor(AverageJun0800)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJun0900 = tempTotalJun0900 / countTotalJun0900;
            Console.WriteLine(Math.Floor(AverageJun0900) + " is the average for Jun @ 0900");

            monthAverageJun += AverageJun0900;
            sb.Append($"\"Jun0900\": {Math.Floor(AverageJun0900)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJun1000 = tempTotalJun1000 / countTotalJun1000;
            Console.WriteLine(Math.Floor(AverageJun1000) + " is the average for Jun @ 1000");

            monthAverageJun += AverageJun1000;
            sb.Append($"\"Jun1000\": {Math.Floor(AverageJun1000)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJun1100 = tempTotalJun1100 / countTotalJun1100;
            Console.WriteLine(Math.Floor(AverageJun1100) + " is the average for Jun @ 1100");

            monthAverageJun += AverageJun1100;
            sb.Append($"\"Jun1100\": {Math.Floor(AverageJun1100)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJun1200 = tempTotalJun1200 / countTotalJun1200;
            Console.WriteLine(Math.Floor(AverageJun1200) + " is the average for Jun @ 1200");

            monthAverageJun += AverageJun1200;
            sb.Append($"\"Jun1200\": {Math.Floor(AverageJun1200)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJun1300 = tempTotalJun1300 / countTotalJun1300;
            Console.WriteLine(Math.Floor(AverageJun1300) + " is the average for Jun @ 1300");

            monthAverageJun += AverageJun1300;
            sb.Append($"\"Jun1300\": {Math.Floor(AverageJun1300)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJun1400 = tempTotalJun1400 / countTotalJun1400;
            Console.WriteLine(Math.Floor(AverageJun1400) + " is the average for Jun @ 1400");

            monthAverageJun += AverageJun1400;
            sb.Append($"\"Jun1400\": {Math.Floor(AverageJun1400)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJun1500 = tempTotalJun1500 / countTotalJun1500;
            Console.WriteLine(Math.Floor(AverageJun1500) + " is the average for Jun @ 1500");

            monthAverageJun += AverageJun1500;
            sb.Append($"\"Jun1500\": {Math.Floor(AverageJun1500)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJun1600 = tempTotalJun1600 / countTotalJun1600;
            Console.WriteLine(Math.Floor(AverageJun1600) + " is the average for Jun @ 1600");

            monthAverageJun += AverageJun1600;
            sb.Append($"\"Jun1600\": {Math.Floor(AverageJun1600)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJun1700 = tempTotalJun1700 / countTotalJun1700;
            Console.WriteLine(Math.Floor(AverageJun1700) + " is the average for Jun @ 1700");
            monthAverageJun += AverageJun1700;
            sb.Append($"\"Jun1700\": {Math.Floor(AverageJun1700)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJun1800 = tempTotalJun1800 / countTotalJun1800;
            Console.WriteLine(Math.Floor(AverageJun1800) + " is the average for Jun @ 1800");
            monthAverageJun += AverageJun1800;
            sb.Append($"\"Jun1800\": {Math.Floor(AverageJun1800)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJun1900 = tempTotalJun1900 / countTotalJun1900;
            Console.WriteLine(Math.Floor(AverageJun1900) + " is the average for Jun @ 1900");
            monthAverageJun += AverageJun1900;
            sb.Append($"\"Jun1900\": {Math.Floor(AverageJun1900)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJun2000 = tempTotalJun2000 / countTotalJun2000;
            Console.WriteLine(Math.Floor(AverageJun2000) + " is the average for Jun @ 1700");
            monthAverageJun += AverageJun2000;
            sb.Append($"\"Jun2000\": {Math.Floor(AverageJun2000)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            Console.WriteLine(Math.Floor(monthAverageJun) + " is the monthly average for Jun");
            sb.Append($"\"JunAverage\": {Math.Floor(monthAverageJun)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();

            #endregion

            //Jul ToFile After Math
            #region

            Console.WriteLine(Math.Floor(tempTotalJul0600) + " is the average for Jul @ 0600: ");
            AverageJul0600 = tempTotalJul0600 / countTotalJul0600;

            monthAverageJul += AverageJul0600;

            sb.Append($"\"Jul0600\": {Math.Floor(AverageJul0600)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJul0700 = tempTotalJul0700 / countTotalJul0700;
            Console.WriteLine(Math.Floor(AverageJul0700) + " is the average for Jul @ 0700");

            monthAverageJul += AverageJul0700;
            sb.Append($"\"Jul0700\": {Math.Floor(AverageJul0700)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJul0800 = tempTotalJul0800 / countTotalJul0800;
            Console.WriteLine(Math.Floor(AverageJul0800) + " is the average for Jul @ 0800");


            monthAverageJul += AverageJul0800;
            sb.Append($"\"Jul0800\": {Math.Floor(AverageJul0800)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJul0900 = tempTotalJul0900 / countTotalJul0900;
            Console.WriteLine(Math.Floor(AverageJul0900) + " is the average for Jul @ 0900");

            monthAverageJul += AverageJul0900;
            sb.Append($"\"Jul0900\": {Math.Floor(AverageJul0900)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJul1000 = tempTotalJul1000 / countTotalJul1000;
            Console.WriteLine(Math.Floor(AverageJul1000) + " is the average for Jul @ 1000");

            monthAverageJul += AverageJul1000;
            sb.Append($"\"Jul1000\": {Math.Floor(AverageJul1000)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJul1100 = tempTotalJul1100 / countTotalJul1100;
            Console.WriteLine(Math.Floor(AverageJul1100) + " is the average for Jul @ 1100");

            monthAverageJul += AverageJul1100;
            sb.Append($"\"Jul1100\": {Math.Floor(AverageJul1100)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJul1200 = tempTotalJul1200 / countTotalJul1200;
            Console.WriteLine(Math.Floor(AverageJul1200) + " is the average for Jul @ 1200");

            monthAverageJul += AverageJul1200;
            sb.Append($"\"Jul1200\": {Math.Floor(AverageJul1200)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJul1300 = tempTotalJul1300 / countTotalJul1300;
            Console.WriteLine(Math.Floor(AverageJul1300) + " is the average for Jul @ 1300");

            monthAverageJul += AverageJul1300;
            sb.Append($"\"Jul1300\": {Math.Floor(AverageJul1300)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJul1400 = tempTotalJul1400 / countTotalJul1400;
            Console.WriteLine(Math.Floor(AverageJul1400) + " is the average for Jul @ 1400");

            monthAverageJul += AverageJul1400;
            sb.Append($"\"Jul1400\": {Math.Floor(AverageJul1400)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJul1500 = tempTotalJul1500 / countTotalJul1500;
            Console.WriteLine(Math.Floor(AverageJul1500) + " is the average for Jul @ 1500");

            monthAverageJul += AverageJul1500;
            sb.Append($"\"Jul1500\": {Math.Floor(AverageJul1500)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJul1600 = tempTotalJul1600 / countTotalJul1600;
            Console.WriteLine(Math.Floor(AverageJul1600) + " is the average for Jul @ 1600");

            monthAverageJul += AverageJul1600;
            sb.Append($"\"Jul1600\": {Math.Floor(AverageJul1600)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJul1700 = tempTotalJul1700 / countTotalJul1700;
            Console.WriteLine(Math.Floor(AverageJul1700) + " is the average for Jul @ 1700");
            monthAverageJul += AverageJul1700;
            sb.Append($"\"Jul1700\": {Math.Floor(AverageJul1700)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJul1800 = tempTotalJul1800 / countTotalJul1800;
            Console.WriteLine(Math.Floor(AverageJul1800) + " is the average for Jul @ 1800");
            monthAverageJul += AverageJul1800;
            sb.Append($"\"Jul1800\": {Math.Floor(AverageJul1800)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJul1900 = tempTotalJul1900 / countTotalJul1900;
            Console.WriteLine(Math.Floor(AverageJul1900) + " is the average for Jul @ 1900");
            monthAverageJul += AverageJul1900;
            sb.Append($"\"Jul1900\": {Math.Floor(AverageJul1900)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageJul2000 = tempTotalJul2000 / countTotalJul2000;
            Console.WriteLine(Math.Floor(AverageJul2000) + " is the average for Jul @ 1700");
            monthAverageJul += AverageJul2000;
            sb.Append($"\"Jul2000\": {Math.Floor(AverageJul2000)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            Console.WriteLine(Math.Floor(monthAverageJul) + " is the monthly average for Jul");
            sb.Append($"\"JulAverage\": {Math.Floor(monthAverageJul)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();

            #endregion

            //Aug ToFile After Math
            #region

            Console.WriteLine(Math.Floor(tempTotalAug0600) + " is the average for Aug @ 0600: ");
            AverageAug0600 = tempTotalAug0600 / countTotalAug0600;

            monthAverageAug += AverageAug0600;

            sb.Append($"\"Aug0600\": {Math.Floor(AverageAug0600)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageAug0700 = tempTotalAug0700 / countTotalAug0700;
            Console.WriteLine(Math.Floor(AverageAug0700) + " is the average for Aug @ 0700");

            monthAverageAug += AverageAug0700;
            sb.Append($"\"Aug0700\": {Math.Floor(AverageAug0700)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageAug0800 = tempTotalAug0800 / countTotalAug0800;
            Console.WriteLine(Math.Floor(AverageAug0800) + " is the average for Aug @ 0800");


            monthAverageAug += AverageAug0800;
            sb.Append($"\"Aug0800\": {Math.Floor(AverageAug0800)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageAug0900 = tempTotalAug0900 / countTotalAug0900;
            Console.WriteLine(Math.Floor(AverageAug0900) + " is the average for Aug @ 0900");

            monthAverageAug += AverageAug0900;
            sb.Append($"\"Aug0900\": {Math.Floor(AverageAug0900)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageAug1000 = tempTotalAug1000 / countTotalAug1000;
            Console.WriteLine(Math.Floor(AverageAug1000) + " is the average for Aug @ 1000");

            monthAverageAug += AverageAug1000;
            sb.Append($"\"Aug1000\": {Math.Floor(AverageAug1000)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageAug1100 = tempTotalAug1100 / countTotalAug1100;
            Console.WriteLine(Math.Floor(AverageAug1100) + " is the average for Aug @ 1100");

            monthAverageAug += AverageAug1100;
            sb.Append($"\"Aug1100\": {Math.Floor(AverageAug1100)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageAug1200 = tempTotalAug1200 / countTotalAug1200;
            Console.WriteLine(Math.Floor(AverageAug1200) + " is the average for Aug @ 1200");

            monthAverageAug += AverageAug1200;
            sb.Append($"\"Aug1200\": {Math.Floor(AverageAug1200)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageAug1300 = tempTotalAug1300 / countTotalAug1300;
            Console.WriteLine(Math.Floor(AverageAug1300) + " is the average for Aug @ 1300");

            monthAverageAug += AverageAug1300;
            sb.Append($"\"Aug1300\": {Math.Floor(AverageAug1300)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageAug1400 = tempTotalAug1400 / countTotalAug1400;
            Console.WriteLine(Math.Floor(AverageAug1400) + " is the average for Aug @ 1400");

            monthAverageAug += AverageAug1400;
            sb.Append($"\"Aug1400\": {Math.Floor(AverageAug1400)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageAug1500 = tempTotalAug1500 / countTotalAug1500;
            Console.WriteLine(Math.Floor(AverageAug1500) + " is the average for Aug @ 1500");

            monthAverageAug += AverageAug1500;
            sb.Append($"\"Aug1500\": {Math.Floor(AverageAug1500)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageAug1600 = tempTotalAug1600 / countTotalAug1600;
            Console.WriteLine(Math.Floor(AverageAug1600) + " is the average for Aug @ 1600");

            monthAverageAug += AverageAug1600;
            sb.Append($"\"Aug1600\": {Math.Floor(AverageAug1600)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageAug1700 = tempTotalAug1700 / countTotalAug1700;
            Console.WriteLine(Math.Floor(AverageAug1700) + " is the average for Aug @ 1700");
            monthAverageAug += AverageAug1700;
            sb.Append($"\"Aug1700\": {Math.Floor(AverageAug1700)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageAug1800 = tempTotalAug1800 / countTotalAug1800;
            Console.WriteLine(Math.Floor(AverageAug1800) + " is the average for Aug @ 1800");
            monthAverageAug += AverageAug1800;
            sb.Append($"\"Aug1800\": {Math.Floor(AverageAug1800)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageAug1900 = tempTotalAug1900 / countTotalAug1900;
            Console.WriteLine(Math.Floor(AverageAug1900) + " is the average for Aug @ 1900");
            monthAverageAug += AverageAug1900;
            sb.Append($"\"Aug1900\": {Math.Floor(AverageAug1900)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageAug2000 = tempTotalAug2000 / countTotalAug2000;
            Console.WriteLine(Math.Floor(AverageAug2000) + " is the average for Aug @ 1700");
            monthAverageAug += AverageAug2000;
            sb.Append($"\"Aug2000\": {Math.Floor(AverageAug2000)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            Console.WriteLine(Math.Floor(monthAverageAug) + " is the monthly average for Aug");
            sb.Append($"\"AugAverage\": {Math.Floor(monthAverageAug)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();

            #endregion

            //Sep ToFile After Math
            #region

            Console.WriteLine(Math.Floor(tempTotalSep0600) + " is the average for Sep @ 0600: ");
            AverageSep0600 = tempTotalSep0600 / countTotalSep0600;

            monthAverageSep += AverageSep0600;

            sb.Append($"\"Sep0600\": {Math.Floor(AverageSep0600)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageSep0700 = tempTotalSep0700 / countTotalSep0700;
            Console.WriteLine(Math.Floor(AverageSep0700) + " is the average for Sep @ 0700");

            monthAverageSep += AverageSep0700;
            sb.Append($"\"Sep0700\": {Math.Floor(AverageSep0700)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageSep0800 = tempTotalSep0800 / countTotalSep0800;
            Console.WriteLine(Math.Floor(AverageSep0800) + " is the average for Sep @ 0800");


            monthAverageSep += AverageSep0800;
            sb.Append($"\"Sep0800\": {Math.Floor(AverageSep0800)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageSep0900 = tempTotalSep0900 / countTotalSep0900;
            Console.WriteLine(Math.Floor(AverageSep0900) + " is the average for Sep @ 0900");

            monthAverageSep += AverageSep0900;
            sb.Append($"\"Sep0900\": {Math.Floor(AverageSep0900)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageSep1000 = tempTotalSep1000 / countTotalSep1000;
            Console.WriteLine(Math.Floor(AverageSep1000) + " is the average for Sep @ 1000");

            monthAverageSep += AverageSep1000;
            sb.Append($"\"Sep1000\": {Math.Floor(AverageSep1000)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageSep1100 = tempTotalSep1100 / countTotalSep1100;
            Console.WriteLine(Math.Floor(AverageSep1100) + " is the average for Sep @ 1100");

            monthAverageSep += AverageSep1100;
            sb.Append($"\"Sep1100\": {Math.Floor(AverageSep1100)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageSep1200 = tempTotalSep1200 / countTotalSep1200;
            Console.WriteLine(Math.Floor(AverageSep1200) + " is the average for Sep @ 1200");

            monthAverageSep += AverageSep1200;
            sb.Append($"\"Sep1200\": {Math.Floor(AverageSep1200)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageSep1300 = tempTotalSep1300 / countTotalSep1300;
            Console.WriteLine(Math.Floor(AverageSep1300) + " is the average for Sep @ 1300");

            monthAverageSep += AverageSep1300;
            sb.Append($"\"Sep1300\": {Math.Floor(AverageSep1300)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageSep1400 = tempTotalSep1400 / countTotalSep1400;
            Console.WriteLine(Math.Floor(AverageSep1400) + " is the average for Sep @ 1400");

            monthAverageSep += AverageSep1400;
            sb.Append($"\"Sep1400\": {Math.Floor(AverageSep1400)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageSep1500 = tempTotalSep1500 / countTotalSep1500;
            Console.WriteLine(Math.Floor(AverageSep1500) + " is the average for Sep @ 1500");

            monthAverageSep += AverageSep1500;
            sb.Append($"\"Sep1500\": {Math.Floor(AverageSep1500)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageSep1600 = tempTotalSep1600 / countTotalSep1600;
            Console.WriteLine(Math.Floor(AverageSep1600) + " is the average for Sep @ 1600");

            monthAverageSep += AverageSep1600;
            sb.Append($"\"Sep1600\": {Math.Floor(AverageSep1600)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageSep1700 = tempTotalSep1700 / countTotalSep1700;
            Console.WriteLine(Math.Floor(AverageSep1700) + " is the average for Sep @ 1700");
            monthAverageSep += AverageSep1700;
            sb.Append($"\"Sep1700\": {Math.Floor(AverageSep1700)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageSep1800 = tempTotalSep1800 / countTotalSep1800;
            Console.WriteLine(Math.Floor(AverageSep1800) + " is the average for Sep @ 1800");
            monthAverageSep += AverageSep1800;
            sb.Append($"\"Sep1800\": {Math.Floor(AverageSep1800)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageSep1900 = tempTotalSep1900 / countTotalSep1900;
            Console.WriteLine(Math.Floor(AverageSep1900) + " is the average for Sep @ 1900");
            monthAverageSep += AverageSep1900;
            sb.Append($"\"Sep1900\": {Math.Floor(AverageSep1900)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageSep2000 = tempTotalSep2000 / countTotalSep2000;
            Console.WriteLine(Math.Floor(AverageSep2000) + " is the average for Sep @ 1700");
            monthAverageSep += AverageSep2000;
            sb.Append($"\"Sep2000\": {Math.Floor(AverageSep2000)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            Console.WriteLine(Math.Floor(monthAverageSep) + " is the monthly average for Sep");
            sb.Append($"\"SepAverage\": {Math.Floor(monthAverageSep)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();

            #endregion

            //Oct ToFile After Math
            #region

            Console.WriteLine(Math.Floor(tempTotalOct0600) + " is the average for Oct @ 0600: ");
            AverageOct0600 = tempTotalOct0600 / countTotalOct0600;

            monthAverageOct += AverageOct0600;

            sb.Append($"\"Oct0600\": {Math.Floor(AverageOct0600)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageOct0700 = tempTotalOct0700 / countTotalOct0700;
            Console.WriteLine(Math.Floor(AverageOct0700) + " is the average for Oct @ 0700");

            monthAverageOct += AverageOct0700;
            sb.Append($"\"Oct0700\": {Math.Floor(AverageOct0700)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageOct0800 = tempTotalOct0800 / countTotalOct0800;
            Console.WriteLine(Math.Floor(AverageOct0800) + " is the average for Oct @ 0800");


            monthAverageOct += AverageOct0800;
            sb.Append($"\"Oct0800\": {Math.Floor(AverageOct0800)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageOct0900 = tempTotalOct0900 / countTotalOct0900;
            Console.WriteLine(Math.Floor(AverageOct0900) + " is the average for Oct @ 0900");

            monthAverageOct += AverageOct0900;
            sb.Append($"\"Oct0900\": {Math.Floor(AverageOct0900)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageOct1000 = tempTotalOct1000 / countTotalOct1000;
            Console.WriteLine(Math.Floor(AverageOct1000) + " is the average for Oct @ 1000");

            monthAverageOct += AverageOct1000;
            sb.Append($"\"Oct1000\": {Math.Floor(AverageOct1000)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageOct1100 = tempTotalOct1100 / countTotalOct1100;
            Console.WriteLine(Math.Floor(AverageOct1100) + " is the average for Oct @ 1100");

            monthAverageOct += AverageOct1100;
            sb.Append($"\"Oct1100\": {Math.Floor(AverageOct1100)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageOct1200 = tempTotalOct1200 / countTotalOct1200;
            Console.WriteLine(Math.Floor(AverageOct1200) + " is the average for Oct @ 1200");

            monthAverageOct += AverageOct1200;
            sb.Append($"\"Oct1200\": {Math.Floor(AverageOct1200)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageOct1300 = tempTotalOct1300 / countTotalOct1300;
            Console.WriteLine(Math.Floor(AverageOct1300) + " is the average for Oct @ 1300");

            monthAverageOct += AverageOct1300;
            sb.Append($"\"Oct1300\": {Math.Floor(AverageOct1300)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageOct1400 = tempTotalOct1400 / countTotalOct1400;
            Console.WriteLine(Math.Floor(AverageOct1400) + " is the average for Oct @ 1400");

            monthAverageOct += AverageOct1400;
            sb.Append($"\"Oct1400\": {Math.Floor(AverageOct1400)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageOct1500 = tempTotalOct1500 / countTotalOct1500;
            Console.WriteLine(Math.Floor(AverageOct1500) + " is the average for Oct @ 1500");

            monthAverageOct += AverageOct1500;
            sb.Append($"\"Oct1500\": {Math.Floor(AverageOct1500)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageOct1600 = tempTotalOct1600 / countTotalOct1600;
            Console.WriteLine(Math.Floor(AverageOct1600) + " is the average for Oct @ 1600");

            monthAverageOct += AverageOct1600;
            sb.Append($"\"Oct1600\": {Math.Floor(AverageOct1600)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageOct1700 = tempTotalOct1700 / countTotalOct1700;
            Console.WriteLine(Math.Floor(AverageOct1700) + " is the average for Oct @ 1700");
            monthAverageOct += AverageOct1700;
            sb.Append($"\"Oct1700\": {Math.Floor(AverageOct1700)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageOct1800 = tempTotalOct1800 / countTotalOct1800;
            Console.WriteLine(Math.Floor(AverageOct1800) + " is the average for Oct @ 1800");
            monthAverageOct += AverageOct1800;
            sb.Append($"\"Oct1800\": {Math.Floor(AverageOct1800)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageOct1900 = tempTotalOct1900 / countTotalOct1900;
            Console.WriteLine(Math.Floor(AverageOct1900) + " is the average for Oct @ 1900");
            monthAverageOct += AverageOct1900;
            sb.Append($"\"Oct1900\": {Math.Floor(AverageOct1900)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageOct2000 = tempTotalOct2000 / countTotalOct2000;
            Console.WriteLine(Math.Floor(AverageOct2000) + " is the average for Oct @ 1700");
            monthAverageOct += AverageOct2000;
            sb.Append($"\"Oct2000\": {Math.Floor(AverageOct2000)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            Console.WriteLine(Math.Floor(monthAverageOct) + " is the monthly average for Oct");
            sb.Append($"\"OctAverage\": {Math.Floor(monthAverageOct)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();

            #endregion

            //Nov ToFile After Math
            #region

            Console.WriteLine(Math.Floor(tempTotalNov0600) + " is the average for Nov @ 0600: ");
            AverageNov0600 = tempTotalNov0600 / countTotalNov0600;

            monthAverageNov += AverageNov0600;

            sb.Append($"\"Nov0600\": {Math.Floor(AverageNov0600)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageNov0700 = tempTotalNov0700 / countTotalNov0700;
            Console.WriteLine(Math.Floor(AverageNov0700) + " is the average for Nov @ 0700");

            monthAverageNov += AverageNov0700;
            sb.Append($"\"Nov0700\": {Math.Floor(AverageNov0700)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageNov0800 = tempTotalNov0800 / countTotalNov0800;
            Console.WriteLine(Math.Floor(AverageNov0800) + " is the average for Nov @ 0800");


            monthAverageNov += AverageNov0800;
            sb.Append($"\"Nov0800\": {Math.Floor(AverageNov0800)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageNov0900 = tempTotalNov0900 / countTotalNov0900;
            Console.WriteLine(Math.Floor(AverageNov0900) + " is the average for Nov @ 0900");

            monthAverageNov += AverageNov0900;
            sb.Append($"\"Nov0900\": {Math.Floor(AverageNov0900)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageNov1000 = tempTotalNov1000 / countTotalNov1000;
            Console.WriteLine(Math.Floor(AverageNov1000) + " is the average for Nov @ 1000");

            monthAverageNov += AverageNov1000;
            sb.Append($"\"Nov1000\": {Math.Floor(AverageNov1000)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageNov1100 = tempTotalNov1100 / countTotalNov1100;
            Console.WriteLine(Math.Floor(AverageNov1100) + " is the average for Nov @ 1100");

            monthAverageNov += AverageNov1100;
            sb.Append($"\"Nov1100\": {Math.Floor(AverageNov1100)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageNov1200 = tempTotalNov1200 / countTotalNov1200;
            Console.WriteLine(Math.Floor(AverageNov1200) + " is the average for Nov @ 1200");

            monthAverageNov += AverageNov1200;
            sb.Append($"\"Nov1200\": {Math.Floor(AverageNov1200)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageNov1300 = tempTotalNov1300 / countTotalNov1300;
            Console.WriteLine(Math.Floor(AverageNov1300) + " is the average for Nov @ 1300");

            monthAverageNov += AverageNov1300;
            sb.Append($"\"Nov1300\": {Math.Floor(AverageNov1300)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageNov1400 = tempTotalNov1400 / countTotalNov1400;
            Console.WriteLine(Math.Floor(AverageNov1400) + " is the average for Nov @ 1400");

            monthAverageNov += AverageNov1400;
            sb.Append($"\"Nov1400\": {Math.Floor(AverageNov1400)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageNov1500 = tempTotalNov1500 / countTotalNov1500;
            Console.WriteLine(Math.Floor(AverageNov1500) + " is the average for Nov @ 1500");

            monthAverageNov += AverageNov1500;
            sb.Append($"\"Nov1500\": {Math.Floor(AverageNov1500)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageNov1600 = tempTotalNov1600 / countTotalNov1600;
            Console.WriteLine(Math.Floor(AverageNov1600) + " is the average for Nov @ 1600");

            monthAverageNov += AverageNov1600;
            sb.Append($"\"Nov1600\": {Math.Floor(AverageNov1600)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageNov1700 = tempTotalNov1700 / countTotalNov1700;
            Console.WriteLine(Math.Floor(AverageNov1700) + " is the average for Nov @ 1700");
            monthAverageNov += AverageNov1700;
            sb.Append($"\"Nov1700\": {Math.Floor(AverageNov1700)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageNov1800 = tempTotalNov1800 / countTotalNov1800;
            Console.WriteLine(Math.Floor(AverageNov1800) + " is the average for Nov @ 1800");
            monthAverageNov += AverageNov1800;
            sb.Append($"\"Nov1800\": {Math.Floor(AverageNov1800)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageNov1900 = tempTotalNov1900 / countTotalNov1900;
            Console.WriteLine(Math.Floor(AverageNov1900) + " is the average for Nov @ 1900");
            monthAverageNov += AverageNov1900;
            sb.Append($"\"Nov1900\": {Math.Floor(AverageNov1900)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageNov2000 = tempTotalNov2000 / countTotalNov2000;
            Console.WriteLine(Math.Floor(AverageNov2000) + " is the average for Nov @ 1700");
            monthAverageNov += AverageNov2000;
            sb.Append($"\"Nov2000\": {Math.Floor(AverageNov2000)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            Console.WriteLine(Math.Floor(monthAverageNov) + " is the monthly average for Nov");
            sb.Append($"\"NovAverage\": {Math.Floor(monthAverageNov)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();

            #endregion

            //Dec ToFile After Math
            #region

            Console.WriteLine(Math.Floor(tempTotalDec0600) + " is the average for Dec @ 0600: ");
            AverageDec0600 = tempTotalDec0600 / countTotalDec0600;

            monthAverageDec += AverageDec0600;

            sb.Append($"\"Dec0600\": {Math.Floor(AverageDec0600)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageDec0700 = tempTotalDec0700 / countTotalDec0700;
            Console.WriteLine(Math.Floor(AverageDec0700) + " is the average for Dec @ 0700");

            monthAverageDec += AverageDec0700;
            sb.Append($"\"Dec0700\": {Math.Floor(AverageDec0700)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageDec0800 = tempTotalDec0800 / countTotalDec0800;
            Console.WriteLine(Math.Floor(AverageDec0800) + " is the average for Dec @ 0800");


            monthAverageDec += AverageDec0800;
            sb.Append($"\"Dec0800\": {Math.Floor(AverageDec0800)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageDec0900 = tempTotalDec0900 / countTotalDec0900;
            Console.WriteLine(Math.Floor(AverageDec0900) + " is the average for Dec @ 0900");

            monthAverageDec += AverageDec0900;
            sb.Append($"\"Dec0900\": {Math.Floor(AverageDec0900)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageDec1000 = tempTotalDec1000 / countTotalDec1000;
            Console.WriteLine(Math.Floor(AverageDec1000) + " is the average for Dec @ 1000");

            monthAverageDec += AverageDec1000;
            sb.Append($"\"Dec1000\": {Math.Floor(AverageDec1000)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageDec1100 = tempTotalDec1100 / countTotalDec1100;
            Console.WriteLine(Math.Floor(AverageDec1100) + " is the average for Dec @ 1100");

            monthAverageDec += AverageDec1100;
            sb.Append($"\"Dec1100\": {Math.Floor(AverageDec1100)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageDec1200 = tempTotalDec1200 / countTotalDec1200;
            Console.WriteLine(Math.Floor(AverageDec1200) + " is the average for Dec @ 1200");

            monthAverageDec += AverageDec1200;
            sb.Append($"\"Dec1200\": {Math.Floor(AverageDec1200)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageDec1300 = tempTotalDec1300 / countTotalDec1300;
            Console.WriteLine(Math.Floor(AverageDec1300) + " is the average for Dec @ 1300");

            monthAverageDec += AverageDec1300;
            sb.Append($"\"Dec1300\": {Math.Floor(AverageDec1300)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageDec1400 = tempTotalDec1400 / countTotalDec1400;
            Console.WriteLine(Math.Floor(AverageDec1400) + " is the average for Dec @ 1400");

            monthAverageDec += AverageDec1400;
            sb.Append($"\"Dec1400\": {Math.Floor(AverageDec1400)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageDec1500 = tempTotalDec1500 / countTotalDec1500;
            Console.WriteLine(Math.Floor(AverageDec1500) + " is the average for Dec @ 1500");

            monthAverageDec += AverageDec1500;
            sb.Append($"\"Dec1500\": {Math.Floor(AverageDec1500)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageDec1600 = tempTotalDec1600 / countTotalDec1600;
            Console.WriteLine(Math.Floor(AverageDec1600) + " is the average for Dec @ 1600");

            monthAverageDec += AverageDec1600;
            sb.Append($"\"Dec1600\": {Math.Floor(AverageDec1600)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageDec1700 = tempTotalDec1700 / countTotalDec1700;
            Console.WriteLine(Math.Floor(AverageDec1700) + " is the average for Dec @ 1700");
            monthAverageDec += AverageDec1700;
            sb.Append($"\"Dec1700\": {Math.Floor(AverageDec1700)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageDec1800 = tempTotalDec1800 / countTotalDec1800;
            Console.WriteLine(Math.Floor(AverageDec1800) + " is the average for Dec @ 1800");
            monthAverageDec += AverageDec1800;
            sb.Append($"\"Dec1800\": {Math.Floor(AverageDec1800)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageDec1900 = tempTotalDec1900 / countTotalDec1900;
            Console.WriteLine(Math.Floor(AverageDec1900) + " is the average for Dec @ 1900");
            monthAverageDec += AverageDec1900;
            sb.Append($"\"Dec1900\": {Math.Floor(AverageDec1900)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageDec2000 = tempTotalDec2000 / countTotalDec2000;
            Console.WriteLine(Math.Floor(AverageDec2000) + " is the average for Dec @ 1700");
            monthAverageDec += AverageDec2000;
            sb.Append($"\"Dec2000\": {Math.Floor(AverageDec2000)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            Console.WriteLine(Math.Floor(monthAverageDec) + " is the monthly average for Dec");
            sb.Append($"\"DecAverage\": {Math.Floor(monthAverageDec)}");
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();

            //Closing marks for JSON format.
            sb.Append("},");
            File.AppendAllText(targetPath, sb.ToString());
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();

            #endregion

        }

    }
}
