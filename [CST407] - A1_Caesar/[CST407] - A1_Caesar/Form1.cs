using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _CST407____A1_Caesar
{
    //CLASS: CAESARCIPHER: FORM____________________________________________________________________
    public partial class CaesarCipher : Form
    {
        //[ member variables ]
        private const string mAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";//<---capital for ease of reading
        private string mPhrase;//<---stores phrase to be BOTH encrypted and decrypted: is over written!
        private int mKey;
        private bool mTextBoxFlag = false;//<---flag used for textbox logic: controls which textbox gets updated: used in Encrypt()

        //[ constructor: overloads ]
        public CaesarCipher()
        {
            InitializeComponent();
        }

        //[ accessor functions ]
        /*
        //Function: Shift(char character)
        //Parameters: character
        //Task: applies the shift in alphabet characters: used in Encrypt function
        */
        public char Shift(char character)
        {
            //local variables
            int ndx = mAlphabet.IndexOf(character);//<---set initial index to position of passed in character in regard to mAlphabet

            //check for valid alphabet character
            if (ndx == -1)//<---character NOT valid
                return character;

            //check for positive or negative key            
            //if (mKey < 0)//<<---negative key
            //shift
            //ndx = (((ndx - mKey) + 26) % 26);//<---plaintext = (cipherLetter - Key + 26) % 26
            //else//<---positive key
            //shift
            ndx = (((ndx + mKey) + 26) % 26);//<---plaintext = (cipherLetter + Key + 26) % 26

            //return ciphered letter
            return mAlphabet.ElementAt(ndx);
        }
        /*
        //Function: Key()
        //Parameters: none
        //Task: returns the current key value
        */
        public int Key()
        {
            return mKey;
        }
        /*
        //Function: Phrase()
        //Parameters: none
        //Task: returns the current phrase string
        */
        public string Phrase()
        {
            return mPhrase;
        }
        //[ mutator functions ]
        /*
        //Function: Encrypt()
        //Parameters: none
        //Task: encrypts current plain text string: calls Shift()
        */
        public void Encrypt()
        { 
            //local variables
            string cipher = string.Empty;

            //absolute value the key?

            //convert phrase to lower case to match const mAlphabet
            mPhrase = mPhrase.ToUpper();

            //parse plain text phrase
            for (int ndx = 0; ndx < mPhrase.Length; ndx++)
            {
                //set cipher letter to cipher string: calls shift method
                cipher += Shift(mPhrase.ElementAt(ndx));
            }

            if (mTextBoxFlag == true)
            {
                Decrypt_txb.Text = cipher;
                mTextBoxFlag = false;
            }
            else
            {
                //send cipher to text box control
                cipherText_tbx.Text = cipher;
                mTextBoxFlag = true;
            }
        }
        /*
        //Function: Decrypt()
        //Parameters: none
        //Task: decrypts cipher text string back into plain text: calls Encrypt()
        */
        public void Decrypt()
        {
            //unwind key
            mKey = 26 - mKey;

            //set phrase to cipher
            mPhrase = cipherText_tbx.Text;

            //call encrypt
            Encrypt();
        }

        //KEY TEXT________________________________________________________________________________
        private void key_tbx_TextChanged(object sender, EventArgs e)
        {
            //check for valid key
            
            //set key value
            mKey = Int32.Parse(key_tbx.Text);
        }

        //PLAIN TEXT BOX___________________________________________________________________________
        private void plainText_txb_TextChanged(object sender, EventArgs e)
        {
            mPhrase = Decrypt_txb.Text;
        }
        //PLAIN TEXT BUTTON________________________________________________________________________
        private void plainText_btn_Click(object sender, EventArgs e)
        {
            //call encrypt
            Encrypt();

            //clear plain text box control
            Decrypt_txb.Clear();
        }
        //CIPHER TEXT BOX__________________________________________________________________________
        private void cipherText_tbx_TextChanged(object sender, EventArgs e)
        {
            //Decrypt_txb.Text = mPhrase;
        }
        //CIPHER TEXT BUTTON_______________________________________________________________________
        private void Decrypt_btn_Click(object sender, EventArgs e)
        {
            //call decrypt
            Decrypt();

            //clear cipher text box control
            cipherText_tbx.Clear();
        }
    }
}
