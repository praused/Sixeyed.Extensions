using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace System //Piggybacking on the System namespace
{
    public static class DateTimeExtensions
    {
        /***************
        public static string ToXmlDateTime(this DateTime dateTime)
        {
            //return XmlConvert.ToString(dateTime, XmlDateTimeSerializationMode.Utc);
            ////Better to call the other ToXmlDateTime overload, less duplicate code...
            //return dateTime.ToXmlDateTime(XmlDateTimeSerializationMode.Utc);
            ////...or invoke the static method on the class.
            //return ToXmlDateTime(dateTime, XmlDateTimeSerializationMode.Utc);
            //Best way is to remove this method entirely and provide a default value for XmlDateTimeSerializationMode on the following method.
            //This option makes mode an optional parameter.
        }
        ***************/

        public static string ToXmlDateTime(this DateTime dateTime, XmlDateTimeSerializationMode mode = XmlDateTimeSerializationMode.Utc)
        {
            return XmlConvert.ToString(dateTime, mode);
        }
    }
}
