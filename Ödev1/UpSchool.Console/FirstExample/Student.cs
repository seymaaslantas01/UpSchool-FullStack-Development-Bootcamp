using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpSchool.Console.FirstExample
{
    public class Student : PersonBase, ITurkishPerson, IAge
    {
        public int SchoolNumber { get; set; }
        /*public int Score1 { get; set; }
        public int Score2 { get; set; }
        public int Score3 { get; set; }
        */

        public List<int> Scores { get; set; }   
        public string TCID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
     
        public string FullName
        {
            get
            {
                if (string.IsNullOrEmpty(FirstName))
                {
                    return "İsimsiz";
                }
                else
                {
                    return $"{FirstName} {LastName}";
                }
                
            }
            set
            {
                value = $"Şampiyon {FirstName} {LastName}";
            }
        }

        public string FulllName() => $"{FirstName} {LastName}";

        public string GetFullName ()
        {
            return $"{ SchoolNumber} {FirstName} {LastName}";
        }

        /*private int TotalOfScore ()
        {
            return Score1 + Score2 + Score3;
        }
        */

        /*private int TotalOfScore()
        {
            var totalScore = 0;
            return foreach (var score in Scores) 
            {
                totalScore += score;
            }    
        }

        public int FinalNotes() => (Score1 + Score2 + Score3) / 3;
        */
        
    }
}


