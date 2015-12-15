using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestCaseConverter
{
    public class PosRobotTestCase
    {
        private String _code;
        private String _desc;
        private String _functionName;
        private Boolean _dependent;

        private List<String> _codeLines;

        public static List<PosRobotTestCase> fromPosRobotFile(FileStream fileStream)
        {
            List<PosRobotTestCase> tcList = new List<PosRobotTestCase>();
            do
            {
                advanceUntilFunction(fileStream);

                String fncBody = readMethod(fileStream);

                List<String> functionLines = fncBody.Split(';').ToList();

                List<String> trimmedList = new List<string>();

                functionLines.ForEach(m => trimmedList.Add(m.Trim() + ";"));

                List<String> codes = trimmedList.FindAll(m => m.Contains("s[\"Excel"));
                List<String> descs = trimmedList.FindAll(m => m.Contains("s[\"Descr"));

                codes.ForEach(m => trimmedList.Remove(m));
                descs.ForEach(m => trimmedList.Remove(m));

                trimmedList.RemoveRange(0, trimmedList.IndexOf(trimmedList.Find(m => m.Contains("Rep::NextPrueba("))) + 1);

                foreach (String code in codes)
                {
                    PosRobotTestCase tmpCase = new PosRobotTestCase();
                    if (codes.IndexOf(code) == 0)
                    {
                        tmpCase._dependent = false;
                    } else
                    {
                        tmpCase._dependent = true;
                    }
                    tmpCase._code = code.Split('=').Last().Trim().Replace("\"", "").Replace(";", "");
                    tmpCase._desc = descs.ElementAt(codes.IndexOf(code)).Split('=').Last().Trim().Replace("\"", "").Replace(";", "");

                    int idxNextTest = trimmedList.IndexOf(trimmedList.Find(m => m.Contains("Rep::NextPrueba(")));

                    if (idxNextTest != -1)
                    {
                        trimmedList.GetRange(0, idxNextTest).ForEach(m => tmpCase._codeLines.Add(m));
                        trimmedList.RemoveRange(0, idxNextTest + 1);
                    }
                    else
                    {
                        trimmedList.ForEach(m => tmpCase._codeLines.Add(m.Contains("\0") && m.Replace("\0", "").Contains("};") ? m.Replace("\0", "").Replace("};", "") : m.Replace("\0", "")));
                    }


                    tcList.Add(tmpCase);
                }
            } while (fileStream.Length - fileStream.Position > 100);
            

            return tcList;
        }

        private PosRobotTestCase()
        {
            this._codeLines = new List<string>();
        }

        public String Name
        {
            get
            {
                return _code;
            }
        }

        public String Description
        {
            get
            {
                return _desc;
            }
        }

        public Boolean Dependent
        {
            get
            {
                return _dependent;
            }
        }

        public Int16 Number
        {
            get
            {
                return Int16.Parse(_code.Split('-').Last());
            }
        }

        public List<String> CodeLines
        {
            get
            {
                return _codeLines;
            }
        }

        public override String ToString()
        {
            return _code;
        }

        protected static String readMethod(FileStream stream)
        {
            byte[] buffer = new byte[100000];

            UInt16 currPos = 0;
            UInt16 openCount = 1;

            do
            {
                byte currChar = (byte) stream.ReadByte();
                switch ((char)currChar)
                {
                    case '{':
                        openCount++;
                        break;
                    case '}':
                        openCount--;
                        break;
                }
                buffer[currPos] = currChar;
                currPos++;
            } while (openCount > 0 && stream.Position != stream.Length);

            return Encoding.UTF8.GetString(buffer);

        }

        protected static void advanceUntilFunction(FileStream fs)
        {
            byte[] buffer = new byte[50000];
            string functionName;
            string tempString;

            do
            {
                byte currByte;
                UInt16 currPos = 0;

                do
                {
                    currByte = (byte)fs.ReadByte();
                    buffer[currPos] = currByte;
                    currPos++;

                } while (currByte != '{');

                tempString = Encoding.ASCII.GetString(buffer);
                if (tempString.ToLower().Contains("function"))
                {
                    functionName = tempString.Split(new string[] { "\r\n" }, StringSplitOptions.None).ToList().Find(m => m.ToLower().Contains("function")).Split(' ')[1];
                } else
                {
                    functionName = "";
                }
                
            } while (!functionName.ToLower().Contains("prueba"));
        }


    }
}
