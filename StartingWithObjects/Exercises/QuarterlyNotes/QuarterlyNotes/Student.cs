using System;
using System.Globalization;

namespace QuarterlyNotes
{
    class Student
    {
        public string Name;
        public double Note1;
        public double Note2;
        public double Note3;

        public double Total()
        {
            return Note1 + Note2 + Note3;
        }

        public string Status;

    }
}
