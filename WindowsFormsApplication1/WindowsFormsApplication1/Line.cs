﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Line
    {
        public static void CreatePerson(string filename, string name, Person p)
        {
            File.AppendAllText(filename, Environment.NewLine);
            File.AppendAllText(filename, "    Person " + name + ";" + Environment.NewLine);
            File.AppendAllText(filename, "    " + name + ".x = " + p.x1 + "; " + Environment.NewLine);
            File.AppendAllText(filename, "    " + name + ".y = " + p.y1 + "; " + Environment.NewLine);
            File.AppendAllText(filename, "    " + name + ".x2 = " + p.x2 + "; " + Environment.NewLine);
            File.AppendAllText(filename, "    " + name + ".y2 = " + p.y2 + "; " + Environment.NewLine);
            File.AppendAllText(filename, "    " + name + ".nomer_kadra = 0; " + Environment.NewLine);
            File.AppendAllText(filename, "    " + name + ".texture = txLoadImage(\"Pictures\\\\" + Path.GetFileName(p.adress) + "\"); " + Environment.NewLine);
            File.AppendAllText(filename, Environment.NewLine);
        }

        public static void MovePerson(string filename, string name, Person p)
        {
            File.AppendAllText(filename, "        if ((myTime >= " + p.time1 + ") && (myTime <= " + p.time2 + ")) {" + Environment.NewLine);
            File.AppendAllText(filename, "            " + name + ".x+= (" + name + ".x2 - " + name + ".x) / (" + p.time2 + "-" + p.time1 + ");" + Environment.NewLine);
            File.AppendAllText(filename, "            " + name + ".y+= (" + name + ".y2 - " + name + ".y) / (" + p.time2 + "-" + p.time1 + ");" + Environment.NewLine);
            File.AppendAllText(filename, "            txTransparentBlt(txDC(), " + name + ".x, " + name + ".y, " +
                p.width + "/" + p.sprite + ", " +
                p.height + "," +
                name + ".texture, " +
                p.width + "/" + p.sprite + " * " + name + ".nomer_kadra, 0, RGB(255, 255, 255));" + Environment.NewLine);
            File.AppendAllText(filename, Environment.NewLine);
            File.AppendAllText(filename, "            " + name + ".nomer_kadra++;" + Environment.NewLine);
            File.AppendAllText(filename, Environment.NewLine);
            File.AppendAllText(filename, "            if (" + name + ".nomer_kadra >= " + p.sprite + ")" + Environment.NewLine);
            File.AppendAllText(filename, "            {" + Environment.NewLine);
            File.AppendAllText(filename, "               " + name + ".nomer_kadra = 0;" + Environment.NewLine);
            File.AppendAllText(filename, "            }" + Environment.NewLine);
            File.AppendAllText(filename, "        }" + Environment.NewLine);
            File.AppendAllText(filename, Environment.NewLine);
        }
    }
}
