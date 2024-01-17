using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationGauthierCadet {
    public static class ParseFiles {

        public static int CountWordsInFile(string filePath) {
            var lines = File.ReadAllLines(filePath);
            int totalWordsAmount = 0;
            Parallel.ForEach(lines, (line) => {
                int wordsInThisLine = line.Split(new char[] { ' ', ',', '.', ';', ':', '-', '\r', '\n', '\t' }).Length;
                totalWordsAmount += wordsInThisLine;
            });
            Console.WriteLine("this file has {0} words.", totalWordsAmount);
            return totalWordsAmount;
        }
        
        public static int CountWordOccurrenceInFile(string filePath, string wordToFind) {
            var lines = File.ReadAllLines(filePath);
            int occurrenceCounter = 0;
            Parallel.ForEach(lines, (line) => {
                foreach (string word in line.Split(new char[] { ' ', ',', '.', ';', ':', '-', '\r', '\n', '\t' })) {
                    if (word == wordToFind) {
                        occurrenceCounter++;
                    }
                }
                
            });
            Console.WriteLine("the word {0} appeared {1} times in this file.", wordToFind, occurrenceCounter);
            return occurrenceCounter;
        }
    }
}
