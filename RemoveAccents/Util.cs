using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using MMLib.Extensions;

namespace RemoveAccents
{
    namespace Utils
    {
        class Util
        {
            public Util()
            {

            }

            public void RemoveAccents(string fullPath)
            {
                string fileContent;
                Encoding encoding;
                //System.IO.File.Copy(fullPath, fullPath + ".bck");

                using (StreamReader sr = new StreamReader(fullPath))
                {
                    encoding = sr.CurrentEncoding;
                    String input = sr.ReadToEnd();
                    fileContent = RemoveDiacritics(input);
                    //fileContent = AnotherRemoveDiacritics(input,encoding);
                    //fileContent = input.RemoveDiacritics();
                }

                System.IO.File.WriteAllText(fullPath, fileContent);
            }

            public void ChangeEncoding(string fullPath,string encoding)
            {
                //Encoding ANSI = Encoding.GetEncoding(1252);
                //Encoding DEST_ENCO = Encoding.GetEncoding("iso-8859-1");
                //Encoding DEST_ENCO = Encoding.GetEncoding("ISO-8859-1");
                Encoding ORIG_ENCO = AnotherGetEncoding(fullPath);
                Encoding DEST_ENCO = Encoding.GetEncoding(encoding);
                //Encoding DEST_ENCO = Encoding.GetEncoding(28591);

                byte[] srcBytes;
                byte[] desBytes;

                try
                {
                    //using (StreamReader sr = new StreamReader(fullPath))
                    //{
                    //if (sr.CurrentEncoding == DEST_ENCO ) { return; }
                    //srcBytes = sr.CurrentEncoding.GetBytes(sr.ReadToEnd());
                    //desBytes = Encoding.Convert(sr.CurrentEncoding, DEST_ENCO, srcBytes);
                    //}
                    srcBytes = File.ReadAllBytes(fullPath);
                    desBytes = Encoding.Convert(ORIG_ENCO, DEST_ENCO, srcBytes);
                }
                catch (Exception e) 
                {
                    throw e;
                }

                System.IO.File.WriteAllText(fullPath, DEST_ENCO.GetString(desBytes),DEST_ENCO);
                //System.IO.File.WriteAllText(fullPath, ISO8859_1.GetString(desBytes),ISO8859_1);
            }

            public string GetEncoding(string fullPath)
            {
                string encoding = "";
                try
                {
                    using (StreamReader sr = new StreamReader(fullPath))
                    {
                        encoding = sr.CurrentEncoding.ToString();
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }

                return encoding;
            }

            public Encoding AnotherGetEncoding(string filename)
            {
                // Read the BOM
                var bom = new byte[4];
                using (var file = new FileStream(filename, FileMode.Open, FileAccess.Read))
                {
                    file.Read(bom, 0, 4);
                }

                // Analyze the BOM
                if (bom[0] == 0x2b && bom[1] == 0x2f && bom[2] == 0x76) return Encoding.UTF7;
                if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf) return Encoding.UTF8;
                if (bom[0] == 0xff && bom[1] == 0xfe) return Encoding.Unicode; //UTF-16LE
                if (bom[0] == 0xfe && bom[1] == 0xff) return Encoding.BigEndianUnicode; //UTF-16BE
                if (bom[0] == 0 && bom[1] == 0 && bom[2] == 0xfe && bom[3] == 0xff) return Encoding.UTF32;
                return Encoding.ASCII;
            }

            private string AnotherRemoveDiacritics(string text,Encoding encoding)
            {
                byte[] tempBytes;
                //tempBytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(text);
                tempBytes = Encoding.GetEncoding("ISO-8859-8").GetBytes(text);
                //tempBytes = encoding.GetBytes(text);
                string asciiStr = System.Text.Encoding.UTF8.GetString(tempBytes);
                //string asciiStr = Encoding.GetEncoding("ISO-8859-8").GetString(tempBytes);
                //string asciiStr = System.Text.Encoding.ASCII.GetString(tempBytes);
                return asciiStr;
            }

            private string RemoveDiacritics(string text)
            {
                var normalizedString = text.Normalize(NormalizationForm.FormD);
                var stringBuilder = new StringBuilder();

                foreach (var c in normalizedString)
                {
                    var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                    if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                    {
                        stringBuilder.Append(c);
                    }
                }

                return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
            }
        }

    }
}
