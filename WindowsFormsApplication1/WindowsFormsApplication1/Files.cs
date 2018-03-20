﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Files
    {
        public static void Beginning(string filename)
        {
            File.WriteAllText(filename, "");
            File.AppendAllText(filename, "#include \"TXLib.h\"" + Environment.NewLine);
            File.AppendAllText(filename, Environment.NewLine);
            File.AppendAllText(filename, "struct Person" + Environment.NewLine);
            File.AppendAllText(filename, "{" + Environment.NewLine);
            File.AppendAllText(filename, "double x;" + Environment.NewLine);
            File.AppendAllText(filename, "double y;" + Environment.NewLine);
            File.AppendAllText(filename, "double angle;" + Environment.NewLine);
            File.AppendAllText(filename, "  double nomer_kadra;" + Environment.NewLine);
            File.AppendAllText(filename, "HDC texture;" + Environment.NewLine);
            File.AppendAllText(filename, " int MID_x;" + Environment.NewLine);
            File.AppendAllText(filename, " int MID_y;" + Environment.NewLine);
            File.AppendAllText(filename, " int rad;" + Environment.NewLine);
            File.AppendAllText(filename, "  int skorost;" + Environment.NewLine);
            File.AppendAllText(filename, "  int gr_dvigx;" + Environment.NewLine);
            File.AppendAllText(filename, "int gr_dvigy;" + Environment.NewLine);
            File.AppendAllText(filename, "int nach_dv;" + Environment.NewLine);
            File.AppendAllText(filename, "int ampl_y;" + Environment.NewLine);
            File.AppendAllText(filename, " int ampl_x;" + Environment.NewLine);
            File.AppendAllText(filename, "double BeginTime;" + Environment.NewLine);
            File.AppendAllText(filename, "double EndTime;" + Environment.NewLine);
            File.AppendAllText(filename, "double Time;" + Environment.NewLine);
            File.AppendAllText(filename, "};" + Environment.NewLine);

            File.AppendAllText(filename, "int main()" + Environment.NewLine);
            File.AppendAllText(filename, "{" + Environment.NewLine);
            File.AppendAllText(filename, Environment.NewLine);
            File.AppendAllText(filename, "txCreateWindow(800, 600);" + Environment.NewLine);

        }
    
        public static void Ending(string filename)
        {
            File.AppendAllText(filename, "   return 0;" + Environment.NewLine);
            File.AppendAllText(filename, "}" + Environment.NewLine);
        }
    }
}