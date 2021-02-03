using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BecomeADeveloperTask
{
    public partial class Form1 : Form
    {   
        private string UsersInputString { get; set; }
        private string[] arrayOfWords { get; set; }
        public char[][] jaggedArrayStrings { get; set; }

        public const char SEPARATOR = ' ';

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {   
            // get users input string from text box
            UsersInputString = richTextBoxUsersString.Text;

            // in order to compare symbols correctly, we need to cast them to lower case
            UsersInputString = UsersInputString.ToLower();

            // delete unnecessary symbols
            UsersInputString = Regex.Replace(UsersInputString, @"[^0-9a-zA-Z]+", " ");

            // cast string to array of words
            arrayOfWords = UsersInputString.Split(SEPARATOR);

            // the length of first dimension of the jagged array is equal to the number of elements in array of words 
            jaggedArrayStrings = new char[arrayOfWords.Length][];

            int i = 0;
            foreach (var word in arrayOfWords)
            {
                if (word.Equals(""))
                {
                    continue;
                }

                // fill the jagged array with arrays of characters
                jaggedArrayStrings[i] = word.ToCharArray();

                // index of first dimension grows by 1
                i++;
            }

            char[] almostNormalizedArr = new char[arrayOfWords.Length];

            int k = 0;
            // iterate over words
            for (int x = 0; x < arrayOfWords.Length; x++)
            {   

                var letter = returnFirstNonRepeatingCharacterFromArrayOfChars(jaggedArrayStrings[x]);
                if (letter.ToString() != "")
                {
                    almostNormalizedArr[k] = letter;
                }
                k++;
                if (k == almostNormalizedArr.Length - 1)
                {
                    break;
                }
            }

            char firstNonRepeatingChar = returnFirstNonRepeatingCharacterFromArrayOfChars(almostNormalizedArr);

            labelLetter.Text = firstNonRepeatingChar.ToString();
        }

        public char returnFirstNonRepeatingCharacterFromArrayOfChars(char[] arrChars)
        {
            for (int i = 0; i < arrChars.Length; i++)
            {
                bool isRepeated = false;
                for (int j = 0; j < arrChars.Length; j++)
                {
                    if ((i != j) && (arrChars[i] == arrChars[j]))
                    {
                        isRepeated = true;
                        break;
                    }
                }
                if (isRepeated == false)
                {
                    return arrChars[i];
                }
            }
            return ' ';
        }

    }
}
