using System;
using System.IO;

namespace WindowsFormsApp1
{
    class Controller
    {
        //constructor
        public Controller()
        {
            FilesPath = @"c:\New Folder\";
            Random = new Random();
        }

        //checking if file exists
        public void FileExists(string name)
        {
            FileInfo fileInf = new FileInfo(FilesPath + name);
            if (!fileInf.Exists)
                FillFile(name);
        }

        //getting from file by adding name
        public void GetFromFile(string name)
        {
            using (StreamReader sr = new StreamReader(FilesPath + name, System.Text.Encoding.Default))
            {
                string file = sr.ReadToEnd();
                if (name == "SA.txt")
                    SA = File.ReadAllText(FilesPath + name).Split(' ');
                if (name == "SB.txt")
                    SB = File.ReadAllText(FilesPath + name).Split(' ');
                if (name == "SC.txt")
                    SC = File.ReadAllText(FilesPath + name).Split(' ');
            }
        }

        //moves all elements to SD
        public void ToSD()
        {
            //finding min size of three files
            SortedIndex = Math.Min(Math.Min(SA.Length, SB.Length), SC.Length);
            //writing all three to SD 
            for (int i = 0; i < SortedIndex; i++)
            {
                SD += SA[i];
                SD += " ";
                SD += SB[i];
                SD += " ";
                SD += SC[i];
                SD += " ";
            }
            //if files have not same size
            if (SA.Length != SB.Length || SA.Length != SC.Length)
            {
                if (DifferentSize() == 2) //one are passed
                    TwoInOne();
                if (DifferentSize() == 1) //two are passed
                    LastInOne();
            }
        }

        //fill SA SB SC
        void FillFile(string name)
        {
            using (StreamWriter sw = new StreamWriter(FilesPath + name, false, System.Text.Encoding.Default))
            {
                string s = "";
                // filling string
                for (int i = 0; i < 10; i++)
                    s += Random.Next(0, 100).ToString() + " ";
                sw.Write(s);
            }  
        }

        //Counts how many arrays need to be passed
        int DifferentSize()
        {
            int[] IsPassed = new int[3] { 0, 0, 0 };
            if (SA.Length == SortedIndex)
                IsPassed[0]++;
            if (SB.Length == SortedIndex)
                IsPassed[1]++;
            if (SC.Length == SortedIndex)
                IsPassed[2]++;
            return IsPassed[0] + IsPassed[1] + IsPassed[2];
        }

        //moves 2 arrays' data in SD
        void TwoInOne()
        {
            int NextStep = 0;
            if (SortedIndex == SA.Length)
            {
                NextStep = Math.Min(SB.Length, SC.Length);
                for (int i = SortedIndex; i < NextStep; i++)
                {
                    SD += SB[i];
                    SD += " ";
                    SD += SC[i];
                    SD += " ";
                }
            }
            if (SortedIndex == SB.Length)
            {
                NextStep = Math.Min(SA.Length, SC.Length);
                for (int i = SortedIndex; i < NextStep; i++)
                {
                    SD += SA[i];
                    SD += " ";
                    SD += SC[i];
                    SD += " ";
                }
            }
            if (SortedIndex == SC.Length)
            {
                NextStep = Math.Min(SA.Length, SB.Length);
                for (int i = SortedIndex; i < NextStep; i++)
                {
                    SD += SA[i];
                    SD += " ";
                    SD += SB[i];
                    SD += " ";
                }
            }
            SortedIndex = NextStep;
        }

        //moves last array's data to SD
        void LastInOne()
        {
            int Last = Math.Max(Math.Max(SA.Length, SB.Length), SC.Length);
            if (Last == SA.Length)
                for (int i = SortedIndex; i < Last; i++)
                {
                    SD += SA[i];
                    SD += " ";
                }
            if (Last == SB.Length)
                for (int i = SortedIndex; i < Last; i++)
                {
                    SD += SB[i];
                    SD += " ";
                }
            if (Last == SC.Length)
                for (int i = SortedIndex; i < Last; i++)
                {
                    SD += SC[i];
                    SD += " ";
                }
            SortedIndex = Last;
        }

        //saves result to SD
        public void SaveResult()
        {
            using (StreamWriter sw = new StreamWriter(FilesPath + "SD.txt", false, System.Text.Encoding.Default))
                sw.Write(SD); //dispose file
        }

        //data
        string[] SA, SB, SC;
        int SortedIndex;
        string SD, FilesPath;
        Random Random;
    }
}
