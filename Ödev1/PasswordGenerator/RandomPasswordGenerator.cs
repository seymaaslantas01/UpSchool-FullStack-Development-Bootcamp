using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public class RandomPasswordGenerator
    {
        string LowercaseLetters = "abcdefghijklmnopqrstuvwxyz";
        string UppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string Numbers = "0123456789";
        string SpecialCharacters = "!@#$%^&*_-=+";
        

        private Random _random;
        string CharList = "";
        private string Password = "";


        public RandomPasswordGenerator()
        { 
            _random = new Random();
   
        }

        public string GenerateRandomPassword(string includeNumbers, string includeLowercaseLetters, string includeUpperCaseLetters, string includeSpecialCharacters, int PasswordLength)
        {

            switch (includeNumbers)
            {
                case "Y" or "y":
                    CharList += Numbers;
                    break;
                case "N" or "n":
                    CharList += "";
                    break;


            }
            switch (includeLowercaseLetters)
            {
                case "Y" or "y":
                    CharList += LowercaseLetters;
                    break;
                case "N" or "n":
                    CharList += "";
                    break;


            }
            switch (includeUpperCaseLetters)
            {
                case "Y" or "y":
                    CharList += UppercaseLetters;
                    break;
                case "N" or "n":
                    CharList += "";
                    break;


            }
            switch (includeSpecialCharacters)
            {
                case "Y" or "y":
                    CharList += SpecialCharacters;
                    break;
                case "N" or "n":
                    CharList += "";
                    break;


            }

            for (int i = 0; i < PasswordLength; i++)
            {
                var randomIndex = _random.Next(0, PasswordLength);
                var RandomPassword = CharList[randomIndex];
                Password += RandomPassword;
            }

            return Password;
        }



    }
}
