using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public class Sensors
    {
        public static void WriteDataToFile()
        {
            var fs = new FileStream(Data.ArrayOfObjects[6] + ".txt", FileMode.Append, FileAccess.Write);
            using (var sw = new StreamWriter(fs))
            {
                for (int i = 0; i < 6; i++)
                    sw.Write(DataStruct.ArrayOfObjects[i] + Data.ArrayOfObjects[i] + ", ");
                sw.Write("\n");
            }
        }
    }
}