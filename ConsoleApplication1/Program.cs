using System;
using System.IO;
using System.Text;

namespace ConsoleApplication1
{
    internal class Homework
    {
        private const string FILE_PATH = @"E:\temp.txt";
        private byte var1;
        private short var2;
        private char var3;
        private int var4;
        private long var5;
        private float var6;
        private double var7;

        public static void Main(string[] args)
        {
            Homework homework = new Homework();
            var var1 = (byte) homework.var2;
            var var2 = (short) homework.var3;
            var var3 = (char) homework.var4;
            var var4 = (int) homework.var5;

            string line = new StringBuilder()
                .Append(var1)
                .Append(var2)
                .Append(var3)
                .Append(var4)
                .Append(homework.var1)
                .Append(homework.var2)
                .Append(homework.var3)
                .Append(homework.var4)
                .Append(homework.var5)
                .Append(homework.var6)
                .Append(homework.var7)
                .ToString();

            using (StreamWriter streamWriter = new StreamWriter(FILE_PATH))
            {
                streamWriter.WriteLine(line);
            }
            Console.Out.WriteLine("line = {0}", File.ReadAllText(FILE_PATH));
        }
    }
}