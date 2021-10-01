using System;

namespace GenScv
{
    class InputParam
    {
        int columns = 4;
        int rows = 20;
        int length = 15;
        string encoding = "UTF-8";
        string outFile = "out.csv";
        public int Columns => columns;
        public int Rows => rows;
        public int Length => length;
        public string Encoding => encoding;
        public string OutFile => outFile;

        
    }
}
