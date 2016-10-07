using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    public class Calculator
    {
        public ArrayList ItemMount<T>(int ccountNum, List<T> dataTable,string colname) {


            var resultAry = new ArrayList();
            var resultMount = 0;
            var count = 0;


            foreach (var item in dataTable)
            {
                count++;
                resultMount += Convert.ToInt32(item.GetType().GetProperty(colname).GetValue(item));

                if (count % ccountNum == 0)
                {
                    resultAry.Add(resultMount);
                    resultMount = 0;
                }
            }


            if (count == dataTable.Count && (count % ccountNum != 0))
            {
                resultAry.Add(resultMount);
            }

            return resultAry;

        }
    }
}
