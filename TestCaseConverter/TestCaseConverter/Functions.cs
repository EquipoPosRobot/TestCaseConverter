using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCaseConverter
{
    static public class Functions
    {
        private const int MAX_BYTES = 500;
        public static void WriteAsIntellibot(FileStream stream, IEnumerable<PosRobotTestCase> testCases, WriteEncoding enc)
        {
            foreach (PosRobotTestCase tc in testCases)
            {
                Write(stream, enc, "<meta>\n");
                Write(stream, enc, "Testcase=\"" + tc.Name + "\"\n");
                Write(stream, enc, "Group=\"" + "parsed" + "\"\n");
                Write(stream, enc, "Dependent=" + tc.Dependent.ToString() + "\n");
                Write(stream, enc, "ExecutionCount=" + "1" + "\n");
                Write(stream, enc, "Title=\"" + tc.Name + "\"\n");
                Write(stream, enc, "Description=\"" + tc.Description + "\"\n");
                Write(stream, enc, "Priority=\"" + "Medium" + "\"\n");
                Write(stream, enc, "Tags=\"" + "parsed" + "\"\n");
                Write(stream, enc, "</meta>\n");

                Write(stream, enc, String.Format("function Test_{0:0000}() {{\n", tc.Number));
                foreach (String line in tc.CodeLines)
                {
                    Write(stream, enc, "\t" + line + "\n");
                }
                Write(stream, enc, "}\n\n");
            }
        }

        private static void Write(FileStream st, WriteEncoding enc, String text)
        {
            int len = GetBytes(enc, text).Length;
            st.Write(GetBytes(enc, text), 0, len);
        }

        private static byte[] GetBytes(WriteEncoding enc, String text)
        {
            switch (enc)
            {
                case WriteEncoding.ASCII:
                    return Encoding.ASCII.GetBytes(text);
                case WriteEncoding.UTF8:
                    return Encoding.UTF8.GetBytes(text);
                case WriteEncoding.Unicode:
                    return Encoding.Unicode.GetBytes(text);
                default:
                    throw new ArgumentException("Se debe especificar una codificacion valida");
            }
        }

        public enum WriteEncoding
        {
            ASCII,
            Unicode,
            UTF8

        }
    }
}
