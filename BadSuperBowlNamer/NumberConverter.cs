using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadSuperBowlNamer
{
    public class NumberConverter
    {
        public string Convert(int num)
        {
            //length of number and pattern of 1,4,5,9 can somehow be tied together
            //loop over all the digits in num




            //any single digit number
            char oneCharacter = 'I';
            char fiveCharacter = 'V';
            char tenCharacter = 'X';

            var returnValue = "";

            var newNumber = num % 9;
            var numberOfTenCharacters = num / 9;
            returnValue += new string(tenCharacter, numberOfTenCharacters);

            if (newNumber == 0)
            {
                return oneCharacter + returnValue;
            }

            newNumber = num % 5;
            var numberOfFiveCharacters = num / 5;
            returnValue += new string(fiveCharacter, numberOfFiveCharacters);
            
            if (newNumber == 0)
            {
                return returnValue;
            }

            newNumber = num % 4; //num needs to be newNumber
            numberOfFiveCharacters = num / 4;
            returnValue += new string(fiveCharacter, numberOfFiveCharacters);

            if (newNumber == 0)
            {
                returnValue = oneCharacter + returnValue;
            }

            newNumber = num % 1;
            var numberOfOneCharacters = num / 1;
            returnValue += new string(fiveCharacter, numberOfFiveCharacters);

            
            return returnValue;
            

            //translate that digit to a string roman numeral
            //stick the numerals together



            
        }
    }
}
