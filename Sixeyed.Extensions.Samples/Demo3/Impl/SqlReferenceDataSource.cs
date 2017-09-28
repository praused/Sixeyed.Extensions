using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sixeyed.Extensions.Samples.Demo3.Impl
{
    public abstract class SqlDataSource
    {
        public string Name = "SQL";
    }

    public class SqlReferenceDataSource : SqlDataSource, IReferenceDataSource
    {
        public IEnumerable<ReferenceDataItem> GetItems()
        {
            return new List<ReferenceDataItem>
            {
                new ReferenceDataItem { Code = "xyx", Description = "from SQL" },
                new ReferenceDataItem { Code = "xyz", Description = "from SQL 2" }
            };
        }
    }
}
