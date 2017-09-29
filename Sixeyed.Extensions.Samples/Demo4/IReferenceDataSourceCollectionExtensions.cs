using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sixeyed.Extensions.Samples.Demo3 //Change namespace to match namespace of the interface we are using (IReferenceDataSource)
{
    public static  class IReferenceDataSourceCollectionExtensions
    {
        public static IEnumerable<ReferenceDataItem> GetAllItemsByCode(this IEnumerable sources, string code)
        {
            var items = new List<ReferenceDataItem>();
            foreach (var source in sources)
            {
                var refDataSource = source as IReferenceDataSource;
                if (refDataSource != null)
                {
                    items.AddRange(refDataSource.GetItemsByCode(code));
                }
            }
            return items;
        }
    }
}
