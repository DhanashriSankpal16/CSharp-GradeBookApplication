using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
   public class RankedGradeBook : BaseGradeBook

    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = RankedGradeBook.Ranked;
        }

        public static object Ranked { get; }
        public object Type { get; }
    }
}
