using System;

namespace GenScv
{
    class InputParam
    {
        int _columns = 4;
        int _rows = 20;
        int _length = 15;
        string _encoding = "UTF-8";
        string _outFile = "out.csv";
        public int Columns => _columns;
        public int Rows => _rows;
        public int Length => _length;
        public string Encoding => _encoding;
        public string OutFile => _outFile;

        
    }
}
