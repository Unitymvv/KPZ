﻿using System.IO;

namespace ClassLibrary_Task4
{
    public class SmartTextReader : ISmartTextReader
    {
        public char[][] ReadText(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            char[][] result = new char[lines.Length][];

            for (int i = 0; i < lines.Length; i++) 
            {
                result[i] = lines[i].ToCharArray();
            }

            return result;
        }
    }
}
