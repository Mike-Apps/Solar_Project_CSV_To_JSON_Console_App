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
        //Continue to add and test regions.  Each region needs to have month string and month number changed in order to work.  So far this is working...........
        public static void ExtractData(string file)
        {
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
            

            string[] row = File.ReadAllLines(path);

            int count = 0;


            for (int i = 0; i < row.Length; i++)
            {
                //FIRST LOOP CREATES A LITTERAL STRING WITH SEPERATORS.  ONE STRING PER LINE.  SECOND STRING ARRAY "ROWS" SPLITS THE STRING INTO ITS INDIVIDUAL CELLS.  
                //NEED TO ADD THE ',' BACK INTO THE MIX ONCE RE-ADDED INTO THE TARGET CSV FILE.

                string[] cell = row[i].Split(',');

                for (int j = 0; j < cell.Length; j++)
                {
                    //Data to JSON that does not require Math
                    
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
                        //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
                        File.AppendAllText(targetPath, Environment.NewLine);
                        sb.Clear();

                        sb.Append($"\"State\": {cell[2].ToUpperInvariant()}" + ',');
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
                //myfile.Close();
                //sb.Clear();
                //count = 0;

                try
                {
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
                        //Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalFeb0600);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "02" && cell[1] == "07:00")
                    {
                        tempTotalFeb0700 = tempTotalFeb0700 + Convert.ToInt32(cell[4]);
                        countTotalFeb0700++;
                        //Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalFeb0700);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "02" && cell[1] == "08:00")
                    {
                        tempTotalFeb0800 = tempTotalFeb0800 + Convert.ToInt32(cell[4]);
                        countTotalFeb0800++;
                        // Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalFeb0800);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "02" && cell[1] == "09:00")
                    {
                        tempTotalFeb0900 = tempTotalFeb0900 + Convert.ToInt32(cell[4]);
                        countTotalFeb0900++;
                        // Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalFeb0900);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "02" && cell[1] == "10:00")
                    {
                        tempTotalFeb1000 = tempTotalFeb1000 + Convert.ToInt32(cell[4]);
                        countTotalFeb1000++;
                        //Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalFeb1000);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "02" && cell[1] == "11:00")
                    {
                        tempTotalFeb1100 = tempTotalFeb1100 + Convert.ToInt32(cell[4]);
                        countTotalFeb1100++;
                        // Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalFeb1100);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "02" && cell[1] == "12:00")
                    {
                        tempTotalFeb1200 = tempTotalFeb1200 + Convert.ToInt32(cell[4]);
                        countTotalFeb1200++;
                        // Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalFeb1200);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "02" && cell[1] == "13:00")
                    {
                        tempTotalFeb1300 = tempTotalFeb1300 + Convert.ToInt32(cell[4]);
                        countTotalFeb1300++;
                        //Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalFeb1300);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "02" && cell[1] == "14:00")
                    {
                        tempTotalFeb1400 = tempTotalFeb1400 + Convert.ToInt32(cell[4]);
                        countTotalFeb1400++;
                        // Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalFeb1400);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "02" && cell[1] == "15:00")
                    {
                        tempTotalFeb1500 = tempTotalFeb1500 + Convert.ToInt32(cell[4]);
                        countTotalFeb1500++;
                        //Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalFeb1500);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "02" && cell[1] == "16:00")
                    {
                        tempTotalFeb1600 = tempTotalFeb1600 + Convert.ToInt32(cell[4]);
                        countTotalFeb1600++;
                        //Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalFeb1600);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "02" && cell[1] == "17:00")
                    {
                        tempTotalFeb1700 = tempTotalFeb1700 + Convert.ToInt32(cell[4]);
                        countTotalFeb1700++;
                        //Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalFeb1700);
                    }


                    if (cell[0][0].ToString() + cell[0][1].ToString() == "02" && cell[1] == "18:00")
                    {
                        tempTotalFeb1800 = tempTotalFeb1800 + Convert.ToInt32(cell[4]);
                        countTotalFeb1800++;
                        //Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalFeb1800);
                    }


                    if (cell[0][0].ToString() + cell[0][1].ToString() == "02" && cell[1] == "19:00")
                    {
                        tempTotalFeb1900 = tempTotalFeb1900 + Convert.ToInt32(cell[4]);
                        countTotalFeb1900++;
                        //Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalFeb1900);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "02" && cell[1] == "20:00")
                    {
                        tempTotalFeb2000 = tempTotalFeb2000 + Convert.ToInt32(cell[4]);
                        countTotalFeb2000++;
                        // Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalFeb2000);
                    }
                    #endregion

                    //March Averages over the hours
                    #region

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "03" && cell[1] == "06:00")
                    {
                        tempTotalMar0600 = tempTotalMar0600 + Convert.ToInt32(cell[4]);
                        countTotalMar0600++;
                        //Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalMar0600);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "03" && cell[1] == "07:00")
                    {
                        tempTotalMar0700 = tempTotalMar0700 + Convert.ToInt32(cell[4]);
                        countTotalMar0700++;
                        //Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalMar0700);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "03" && cell[1] == "08:00")
                    {
                        tempTotalMar0800 = tempTotalMar0800 + Convert.ToInt32(cell[4]);
                        countTotalMar0800++;
                        // Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalMar0800);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "03" && cell[1] == "09:00")
                    {
                        tempTotalMar0900 = tempTotalMar0900 + Convert.ToInt32(cell[4]);
                        countTotalMar0900++;
                        // Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalMar0900);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "03" && cell[1] == "10:00")
                    {
                        tempTotalMar1000 = tempTotalMar1000 + Convert.ToInt32(cell[4]);
                        countTotalMar1000++;
                        //Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalMar1000);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "03" && cell[1] == "11:00")
                    {
                        tempTotalMar1100 = tempTotalMar1100 + Convert.ToInt32(cell[4]);
                        countTotalMar1100++;
                        // Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalMar1100);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "03" && cell[1] == "12:00")
                    {
                        tempTotalMar1200 = tempTotalMar1200 + Convert.ToInt32(cell[4]);
                        countTotalMar1200++;
                        // Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalMar1200);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "03" && cell[1] == "13:00")
                    {
                        tempTotalMar1300 = tempTotalMar1300 + Convert.ToInt32(cell[4]);
                        countTotalMar1300++;
                        //Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalMar1300);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "03" && cell[1] == "14:00")
                    {
                        tempTotalMar1400 = tempTotalMar1400 + Convert.ToInt32(cell[4]);
                        countTotalMar1400++;
                        // Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalMar1400);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "03" && cell[1] == "15:00")
                    {
                        tempTotalMar1500 = tempTotalMar1500 + Convert.ToInt32(cell[4]);
                        countTotalMar1500++;
                        //Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalMar1500);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "03" && cell[1] == "16:00")
                    {
                        tempTotalMar1600 = tempTotalMar1600 + Convert.ToInt32(cell[4]);
                        countTotalMar1600++;
                        //Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalMar1600);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "03" && cell[1] == "17:00")
                    {
                        tempTotalMar1700 = tempTotalMar1700 + Convert.ToInt32(cell[4]);
                        countTotalMar1700++;
                        //Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalMar1700);
                    }


                    if (cell[0][0].ToString() + cell[0][1].ToString() == "03" && cell[1] == "18:00")
                    {
                        tempTotalMar1800 = tempTotalMar1800 + Convert.ToInt32(cell[4]);
                        countTotalMar1800++;
                        //Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalMar1800);
                    }


                    if (cell[0][0].ToString() + cell[0][1].ToString() == "03" && cell[1] == "19:00")
                    {
                        tempTotalMar1900 = tempTotalMar1900 + Convert.ToInt32(cell[4]);
                        countTotalMar1900++;
                        //Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalMar1900);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "03" && cell[1] == "20:00")
                    {
                        tempTotalMar2000 = tempTotalMar2000 + Convert.ToInt32(cell[4]);
                        countTotalMar2000++;
                        // Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalMar2000);
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
                        //Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalApr0700);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "04" && cell[1] == "08:00")
                    {
                        tempTotalApr0800 = tempTotalApr0800 + Convert.ToInt32(cell[4]);
                        countTotalApr0800++;
                        // Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalApr0800);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "04" && cell[1] == "09:00")
                    {
                        tempTotalApr0900 = tempTotalApr0900 + Convert.ToInt32(cell[4]);
                        countTotalApr0900++;
                        // Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalApr0900);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "04" && cell[1] == "10:00")
                    {
                        tempTotalApr1000 = tempTotalApr1000 + Convert.ToInt32(cell[4]);
                        countTotalApr1000++;
                        //Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalApr1000);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "04" && cell[1] == "11:00")
                    {
                        tempTotalApr1100 = tempTotalApr1100 + Convert.ToInt32(cell[4]);
                        countTotalApr1100++;
                        // Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalApr1100);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "04" && cell[1] == "12:00")
                    {
                        tempTotalApr1200 = tempTotalApr1200 + Convert.ToInt32(cell[4]);
                        countTotalApr1200++;
                        // Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalApr1200);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "04" && cell[1] == "13:00")
                    {
                        tempTotalApr1300 = tempTotalApr1300 + Convert.ToInt32(cell[4]);
                        countTotalApr1300++;
                        //Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalApr1300);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "04" && cell[1] == "14:00")
                    {
                        tempTotalApr1400 = tempTotalApr1400 + Convert.ToInt32(cell[4]);
                        countTotalApr1400++;
                        // Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalApr1400);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "04" && cell[1] == "15:00")
                    {
                        tempTotalApr1500 = tempTotalApr1500 + Convert.ToInt32(cell[4]);
                        countTotalApr1500++;
                        //Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalApr1500);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "04" && cell[1] == "16:00")
                    {
                        tempTotalApr1600 = tempTotalApr1600 + Convert.ToInt32(cell[4]);
                        countTotalApr1600++;
                        //Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalApr1600);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "04" && cell[1] == "17:00")
                    {
                        tempTotalApr1700 = tempTotalApr1700 + Convert.ToInt32(cell[4]);
                        countTotalApr1700++;
                        //Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalApr1700);
                    }


                    if (cell[0][0].ToString() + cell[0][1].ToString() == "04" && cell[1] == "18:00")
                    {
                        tempTotalApr1800 = tempTotalApr1800 + Convert.ToInt32(cell[4]);
                        countTotalApr1800++;
                        //Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalApr1800);
                    }


                    if (cell[0][0].ToString() + cell[0][1].ToString() == "04" && cell[1] == "19:00")
                    {
                        tempTotalApr1900 = tempTotalApr1900 + Convert.ToInt32(cell[4]);
                        countTotalApr1900++;
                        //Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalApr1900);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "04" && cell[1] == "20:00")
                    {
                        tempTotalApr2000 = tempTotalApr2000 + Convert.ToInt32(cell[4]);
                        countTotalApr2000++;
                        // Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalApr2000);
                    }
                    #endregion

                    //May Averages over the hours
                    #region

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "05" && cell[1] == "06:00")
                    {
                        tempTotalMay0600 = tempTotalMay0600 + Convert.ToInt32(cell[4]);
                        countTotalMay0600++;
                        //Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalMay0600);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "05" && cell[1] == "07:00")
                    {
                        tempTotalMay0700 = tempTotalMay0700 + Convert.ToInt32(cell[4]);
                        countTotalMay0700++;
                        //Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalMay0700);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "05" && cell[1] == "08:00")
                    {
                        tempTotalMay0800 = tempTotalMay0800 + Convert.ToInt32(cell[4]);
                        countTotalMay0800++;
                        // Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalMay0800);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "05" && cell[1] == "09:00")
                    {
                        tempTotalMay0900 = tempTotalMay0900 + Convert.ToInt32(cell[4]);
                        countTotalMay0900++;
                        // Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalMay0900);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "05" && cell[1] == "10:00")
                    {
                        tempTotalMay1000 = tempTotalMay1000 + Convert.ToInt32(cell[4]);
                        countTotalMay1000++;
                        //Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalMay1000);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "05" && cell[1] == "11:00")
                    {
                        tempTotalMay1100 = tempTotalMay1100 + Convert.ToInt32(cell[4]);
                        countTotalMay1100++;
                        // Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalMay1100);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "05" && cell[1] == "12:00")
                    {
                        tempTotalMay1200 = tempTotalMay1200 + Convert.ToInt32(cell[4]);
                        countTotalMay1200++;
                        // Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalMay1200);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "05" && cell[1] == "13:00")
                    {
                        tempTotalMay1300 = tempTotalMay1300 + Convert.ToInt32(cell[4]);
                        countTotalMay1300++;
                        //Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalMay1300);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "05" && cell[1] == "14:00")
                    {
                        tempTotalMay1400 = tempTotalMay1400 + Convert.ToInt32(cell[4]);
                        countTotalMay1400++;
                        // Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalMay1400);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "05" && cell[1] == "15:00")
                    {
                        tempTotalMay1500 = tempTotalMay1500 + Convert.ToInt32(cell[4]);
                        countTotalMay1500++;
                        //Console.WriteLine(cell[0]);
                        //Console.WriteLine(tempTotalMay1500);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "05" && cell[1] == "16:00")
                    {
                        tempTotalMay1600 = tempTotalMay1600 + Convert.ToInt32(cell[4]);
                        countTotalMay1600++;
                        //Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalMay1600);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "05" && cell[1] == "17:00")
                    {
                        tempTotalMay1700 = tempTotalMay1700 + Convert.ToInt32(cell[4]);
                        countTotalMay1700++;
                        //Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalMay1700);
                    }


                    if (cell[0][0].ToString() + cell[0][1].ToString() == "05" && cell[1] == "18:00")
                    {
                        tempTotalMay1800 = tempTotalMay1800 + Convert.ToInt32(cell[4]);
                        countTotalMay1800++;
                        //Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalMay1800);
                    }


                    if (cell[0][0].ToString() + cell[0][1].ToString() == "05" && cell[1] == "19:00")
                    {
                        tempTotalMay1900 = tempTotalMay1900 + Convert.ToInt32(cell[4]);
                        countTotalMay1900++;
                        //Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalMay1900);
                    }

                    if (cell[0][0].ToString() + cell[0][1].ToString() == "05" && cell[1] == "20:00")
                    {
                        tempTotalMay2000 = tempTotalMay2000 + Convert.ToInt32(cell[4]);
                        countTotalMay2000++;
                        // Console.WriteLine(cell[0]);
                        // Console.WriteLine(tempTotalMay2000);
                    }
                    #endregion



                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);

                }


            }



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
            if (AverageJan0800 > 0)

                monthAverageJan += AverageJan0800;
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
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageFeb0700 = tempTotalFeb0700 / countTotalFeb0700;
            Console.WriteLine(Math.Floor(AverageFeb0700) + " is the average for Feb @ 0700");
            AverageForMonthFeb += AverageFeb0700;
            sb.Append($"\"Feb0700\": {Math.Floor(AverageFeb0700)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageFeb0800 = tempTotalFeb0800 / countTotalFeb0800;
            Console.WriteLine(Math.Floor(AverageFeb0800) + " is the average for Feb @ 0800");
            AverageForMonthFeb += AverageFeb0800;
            sb.Append($"\"Feb0800\": {Math.Floor(AverageFeb0800)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageFeb0900 = tempTotalFeb0900 / countTotalFeb0900;
            Console.WriteLine(Math.Floor(AverageFeb0900) + " is the average for Feb @ 0900");
            AverageForMonthFeb += AverageFeb0900;
            sb.Append($"\"Feb0900\": {Math.Floor(AverageFeb0900)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageFeb1000 = tempTotalFeb1000 / countTotalFeb1000;
            Console.WriteLine(Math.Floor(AverageFeb1000) + " is the average for Feb @ 1000");
            AverageForMonthFeb += AverageFeb1000;
            sb.Append($"\"Feb1000\": {Math.Floor(AverageFeb1000)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageFeb1100 = tempTotalFeb1100 / countTotalFeb1100;
            Console.WriteLine(Math.Floor(AverageFeb1100) + " is the average for Feb @ 1100");
            AverageForMonthFeb += AverageFeb1100;
            sb.Append($"\"Feb1100\": {Math.Floor(AverageFeb1100)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageFeb1200 = tempTotalFeb1200 / countTotalFeb1200;
            Console.WriteLine(Math.Floor(AverageFeb1200) + " is the average for Feb @ 1200");
            AverageForMonthFeb += AverageFeb1200;
            sb.Append($"\"Feb1200\": {Math.Floor(AverageFeb1200)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageFeb1300 = tempTotalFeb1300 / countTotalFeb1300;
            Console.WriteLine(Math.Floor(AverageFeb1300) + " is the average for Feb @ 1300");
            AverageForMonthFeb += AverageFeb1300;
            sb.Append($"\"Feb1300\": {Math.Floor(AverageFeb1300)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageFeb1400 = tempTotalFeb1400 / countTotalFeb1400;
            Console.WriteLine(Math.Floor(AverageFeb1400) + " is the average for Feb @ 1400");
            AverageForMonthFeb += AverageFeb1400;
            sb.Append($"\"Feb1400\": {Math.Floor(AverageFeb1400)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageFeb1500 = tempTotalFeb1500 / countTotalFeb1500;
            Console.WriteLine(Math.Floor(AverageFeb1500) + " is the average for Feb @ 1500");
            AverageForMonthFeb += AverageFeb1500;
            sb.Append($"\"Feb1500\": {Math.Floor(AverageFeb1500)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageFeb1600 = tempTotalFeb1600 / countTotalFeb1600;
            Console.WriteLine(Math.Floor(AverageFeb1600) + " is the average for Feb @ 1600");
            AverageForMonthFeb += AverageFeb1600;
            sb.Append($"\"Feb1600\": {Math.Floor(AverageFeb1600)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageFeb1700 = tempTotalFeb1700 / countTotalFeb1700;
            Console.WriteLine(Math.Floor(AverageFeb1700) + " is the average for Feb @ 1700");
            AverageForMonthFeb += AverageFeb1700;
            sb.Append($"\"Feb1700\": {Math.Floor(AverageFeb1700)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageFeb1800 = tempTotalFeb1800 / countTotalFeb1800;
            Console.WriteLine(Math.Floor(AverageFeb1800) + " is the average for Feb @ 1800");
            AverageForMonthFeb += AverageFeb1800;
            sb.Append($"\"Feb1800\": {Math.Floor(AverageFeb1800)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageFeb1900 = tempTotalFeb1900 / countTotalFeb1900;
            Console.WriteLine(Math.Floor(AverageFeb1900) + " is the average for Feb @ 1900");
            AverageForMonthFeb += AverageFeb1900;
            sb.Append($"\"Feb1900\": {Math.Floor(AverageFeb1900)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageFeb2000 = tempTotalFeb2000 / countTotalFeb2000;
            Console.WriteLine(Math.Floor(AverageFeb2000) + " is the average for Feb @ 1700");
            AverageForMonthFeb += AverageFeb2000;
            sb.Append($"\"Feb2000\": {Math.Floor(AverageFeb2000)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
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
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMar0700 = tempTotalMar0700 / countTotalMar0700;
            Console.WriteLine(Math.Floor(AverageMar0700) + " is the average for Mar @ 0700");
            averageMarch += AverageMar0700;
            sb.Append($"\"Mar0700\": {Math.Floor(AverageMar0700)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMar0800 = tempTotalMar0800 / countTotalMar0800;
            Console.WriteLine(Math.Floor(AverageMar0800) + " is the average for Mar @ 0800");
            averageMarch += AverageMar0800;
            sb.Append($"\"Mar0800\": {Math.Floor(AverageMar0800)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
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
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageApr0700 = tempTotalApr0700 / countTotalApr0700;
            Console.WriteLine(Math.Floor(AverageApr0700) + " is the average for Apr @ 0700");

            monthAverageApr += AverageApr0700;
            sb.Append($"\"Apr0700\": {Math.Floor(AverageApr0700)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageApr0800 = tempTotalApr0800 / countTotalApr0800;
            Console.WriteLine(Math.Floor(AverageApr0800) + " is the average for Apr @ 0800");


            monthAverageApr += AverageApr0800;
            sb.Append($"\"Apr0800\": {Math.Floor(AverageApr0800)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageApr0900 = tempTotalApr0900 / countTotalApr0900;
            Console.WriteLine(Math.Floor(AverageApr0900) + " is the average for Apr @ 0900");

            monthAverageApr += AverageApr0900;
            sb.Append($"\"Apr0900\": {Math.Floor(AverageApr0900)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageApr1000 = tempTotalApr1000 / countTotalApr1000;
            Console.WriteLine(Math.Floor(AverageApr1000) + " is the average for Apr @ 1000");

            monthAverageApr += AverageApr1000;
            sb.Append($"\"Apr1000\": {Math.Floor(AverageApr1000)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageApr1100 = tempTotalApr1100 / countTotalApr1100;
            Console.WriteLine(Math.Floor(AverageApr1100) + " is the average for Apr @ 1100");

            monthAverageApr += AverageApr1100;
            sb.Append($"\"Apr1100\": {Math.Floor(AverageApr1100)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageApr1200 = tempTotalApr1200 / countTotalApr1200;
            Console.WriteLine(Math.Floor(AverageApr1200) + " is the average for Apr @ 1200");

            monthAverageApr += AverageApr1200;
            sb.Append($"\"Apr1200\": {Math.Floor(AverageApr1200)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageApr1300 = tempTotalApr1300 / countTotalApr1300;
            Console.WriteLine(Math.Floor(AverageApr1300) + " is the average for Apr @ 1300");

            monthAverageApr += AverageApr1300;
            sb.Append($"\"Apr1300\": {Math.Floor(AverageApr1300)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageApr1400 = tempTotalApr1400 / countTotalApr1400;
            Console.WriteLine(Math.Floor(AverageApr1400) + " is the average for Apr @ 1400");

            monthAverageApr += AverageApr1400;
            sb.Append($"\"Apr1400\": {Math.Floor(AverageApr1400)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageApr1500 = tempTotalApr1500 / countTotalApr1500;
            Console.WriteLine(Math.Floor(AverageApr1500) + " is the average for Apr @ 1500");

            monthAverageApr += AverageApr1500;
            sb.Append($"\"Apr1500\": {Math.Floor(AverageApr1500)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageApr1600 = tempTotalApr1600 / countTotalApr1600;
            Console.WriteLine(Math.Floor(AverageApr1600) + " is the average for Apr @ 1600");

            monthAverageApr += AverageApr1600;
            sb.Append($"\"Apr1600\": {Math.Floor(AverageApr1600)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageApr1700 = tempTotalApr1700 / countTotalApr1700;
            Console.WriteLine(Math.Floor(AverageApr1700) + " is the average for Apr @ 1700");
            monthAverageApr += AverageApr1700;
            sb.Append($"\"Apr1700\": {Math.Floor(AverageApr1700)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageApr1800 = tempTotalApr1800 / countTotalApr1800;
            Console.WriteLine(Math.Floor(AverageApr1800) + " is the average for Apr @ 1800");
            monthAverageApr += AverageApr1800;
            sb.Append($"\"Apr1800\": {Math.Floor(AverageApr1800)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageApr1900 = tempTotalApr1900 / countTotalApr1900;
            Console.WriteLine(Math.Floor(AverageApr1900) + " is the average for Apr @ 1900");
            monthAverageApr += AverageApr1900;
            sb.Append($"\"Apr1900\": {Math.Floor(AverageApr1900)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageApr2000 = tempTotalApr2000 / countTotalApr2000;
            Console.WriteLine(Math.Floor(AverageApr2000) + " is the average for Apr @ 1700");
            monthAverageApr += AverageApr2000;
            sb.Append($"\"Apr2000\": {Math.Floor(AverageApr2000)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
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
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMay0700 = tempTotalMay0700 / countTotalMay0700;
            Console.WriteLine(Math.Floor(AverageMay0700) + " is the average for May @ 0700");

            monthAverageMay += AverageMay0700;
            sb.Append($"\"May0700\": {Math.Floor(AverageMay0700)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMay0800 = tempTotalMay0800 / countTotalMay0800;
            Console.WriteLine(Math.Floor(AverageMay0800) + " is the average for May @ 0800");


            monthAverageMay += AverageMay0800;
            sb.Append($"\"May0800\": {Math.Floor(AverageMay0800)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMay0900 = tempTotalMay0900 / countTotalMay0900;
            Console.WriteLine(Math.Floor(AverageMay0900) + " is the average for May @ 0900");

            monthAverageMay += AverageMay0900;
            sb.Append($"\"May0900\": {Math.Floor(AverageMay0900)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMay1000 = tempTotalMay1000 / countTotalMay1000;
            Console.WriteLine(Math.Floor(AverageMay1000) + " is the average for May @ 1000");

            monthAverageMay += AverageMay1000;
            sb.Append($"\"May1000\": {Math.Floor(AverageMay1000)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMay1100 = tempTotalMay1100 / countTotalMay1100;
            Console.WriteLine(Math.Floor(AverageMay1100) + " is the average for May @ 1100");

            monthAverageMay += AverageMay1100;
            sb.Append($"\"May1100\": {Math.Floor(AverageMay1100)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMay1200 = tempTotalMay1200 / countTotalMay1200;
            Console.WriteLine(Math.Floor(AverageMay1200) + " is the average for May @ 1200");

            monthAverageMay += AverageMay1200;
            sb.Append($"\"May1200\": {Math.Floor(AverageMay1200)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMay1300 = tempTotalMay1300 / countTotalMay1300;
            Console.WriteLine(Math.Floor(AverageMay1300) + " is the average for May @ 1300");

            monthAverageMay += AverageMay1300;
            sb.Append($"\"May1300\": {Math.Floor(AverageMay1300)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMay1400 = tempTotalMay1400 / countTotalMay1400;
            Console.WriteLine(Math.Floor(AverageMay1400) + " is the average for May @ 1400");

            monthAverageMay += AverageMay1400;
            sb.Append($"\"May1400\": {Math.Floor(AverageMay1400)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMay1500 = tempTotalMay1500 / countTotalMay1500;
            Console.WriteLine(Math.Floor(AverageMay1500) + " is the average for May @ 1500");

            monthAverageMay += AverageMay1500;
            sb.Append($"\"May1500\": {Math.Floor(AverageMay1500)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMay1600 = tempTotalMay1600 / countTotalMay1600;
            Console.WriteLine(Math.Floor(AverageMay1600) + " is the average for May @ 1600");

            monthAverageMay += AverageMay1600;
            sb.Append($"\"May1600\": {Math.Floor(AverageMay1600)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMay1700 = tempTotalMay1700 / countTotalMay1700;
            Console.WriteLine(Math.Floor(AverageMay1700) + " is the average for May @ 1700");
            monthAverageMay += AverageMay1700;
            sb.Append($"\"May1700\": {Math.Floor(AverageMay1700)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMay1800 = tempTotalMay1800 / countTotalMay1800;
            Console.WriteLine(Math.Floor(AverageMay1800) + " is the average for May @ 1800");
            monthAverageMay += AverageMay1800;
            sb.Append($"\"May1800\": {Math.Floor(AverageMay1800)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMay1900 = tempTotalMay1900 / countTotalMay1900;
            Console.WriteLine(Math.Floor(AverageMay1900) + " is the average for May @ 1900");
            monthAverageMay += AverageMay1900;
            sb.Append($"\"May1900\": {Math.Floor(AverageMay1900)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
            File.AppendAllText(targetPath, Environment.NewLine);
            sb.Clear();
            Console.WriteLine();


            AverageMay2000 = tempTotalMay2000 / countTotalMay2000;
            Console.WriteLine(Math.Floor(AverageMay2000) + " is the average for May @ 1700");
            monthAverageMay += AverageMay2000;
            sb.Append($"\"May2000\": {Math.Floor(AverageMay2000)}" + ',');
            File.AppendAllText(targetPath, sb.ToString());
            //ENVIRONMENT.NEWLINE ADDS THE NEXT LINE.  ELSE THIS WILL ADD TEXT TO THE SAME ROW.
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



        }
    }
}
