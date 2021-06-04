using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Message_encryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public uint shift;
        public void Setshift(uint shift)
        {
            this.shift = shift;
        }

        public string Encryption(string text)
        {
            //Если величина сдвига больше длины алфавита кирилицы
            if (shift > 32)
                shift = shift % 32;
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                //Если не кириллица
                if (((int)(text[i]) < 1040) || ((int)(text[i]) > 1103))
                    result += text[i];
                //Если буква является строчной
                if ((Convert.ToInt16(text[i]) >= 1072) && (Convert.ToInt16(text[i]) <= 1103))
                {
                    //Если буква, после сдвига выходит за пределы алфавита
                    if (Convert.ToInt16(text[i]) + shift > 1103)
                        //Добавление в строку результатов символ
                        result += Convert.ToChar(Convert.ToInt16(text[i]) + shift - 32);
                    //Если буква может быть сдвинута в пределах алфавита
                    else
                        //Добавление в строку результатов символ
                        result += Convert.ToChar(Convert.ToInt16(text[i]) + shift);
                }
                //Если буква является прописной
                if ((Convert.ToInt16(text[i]) >= 1040) && (Convert.ToInt16(text[i]) <= 1071))
                {
                    //Если буква, после сдвига выходит за пределы алфавита
                    if (Convert.ToInt16(text[i]) + shift > 1071)
                        //Добавление в строку результатов символ
                        result += Convert.ToChar(Convert.ToInt16(text[i]) + shift - 32);
                    //Если буква может быть сдвинута в пределах алфавита
                    else
                        //Добавление в строку результатов символ
                        result += Convert.ToChar(Convert.ToInt16(text[i]) + shift);
                }
            }
            return result;
        }
        public string Decryption(string text)
        {
            //Выполение дешифрования
            //Цикл по каждому символу строки
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (Convert.ToInt16(text[i]) == 32)
                    result += ' ';
                //Если буква является строчной
                if ((Convert.ToInt16(text[i]) >= 1072) && (Convert.ToInt16(text[i]) <= 1103))
                {
                    //Если буква, после сдвига выходит за пределы алфавита
                    if (Convert.ToInt16(text[i]) - shift < 1072)
                        //Добавление в строку результатов символ
                        result += Convert.ToChar(Convert.ToInt16(text[i]) - shift + 32);
                    //Если буква может быть сдвинута в пределах алфавита
                    else
                        //Добавление в строку результатов символ
                        result += Convert.ToChar(Convert.ToInt16(text[i]) - shift);
                }
                //Если буква является прописной
                if ((Convert.ToInt16(text[i]) >= 1040) && (Convert.ToInt16(text[i]) <= 1071))
                {
                    //Если буква, после сдвига выходит за пределы алфавита
                    if (Convert.ToInt16(text[i]) - shift < 1040)
                        //Добавление в строку результатов символ
                        result += Convert.ToChar(Convert.ToInt16(text[i]) - shift + 32);
                    //Если буква может быть сдвинута в пределах алфавита
                    else
                        //Добавление в строку результатов символ
                        result += Convert.ToChar(Convert.ToInt16(text[i]) - shift);
                }
            }
            return result;
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            string _string = tbSend.Text;
            string crypt = Encryption(_string);
            string decrypt = Decryption(crypt);

            tbResalt.Text = crypt;
            textBox1.Text = decrypt;
        }

        private void tbLogin_Click(object sender, EventArgs e)
        {

        }

        private void btLoad_Click(object sender, EventArgs e)
        {

        }

        private void btSave_Click(object sender, EventArgs e)
        {

        }

        private void btGuide_Click(object sender, EventArgs e)
        {

        }

        private void btWrite_Click(object sender, EventArgs e)
        {

        }

        private void btMessage_Click(object sender, EventArgs e)
        {

        }

        private void btSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
