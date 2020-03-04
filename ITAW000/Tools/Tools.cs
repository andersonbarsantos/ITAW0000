using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ITAW000.Tools
{
    public static class Tools
    {
        public static string SafeGetString(this SqlDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
            {
                return reader.GetString(colIndex);
            }
            else
            {
                return null;
            }
        }

        public static string SafeGetString(this SqlDataReader reader, string colName)
        {
            int colIndex = reader.GetOrdinal(colName);

            if (!reader.IsDBNull(colIndex))
            {
                return reader.GetString(colIndex);
            }
            else
            {
                return null;
            }
        }

        public static int? SafeGetInt(this SqlDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
            {
                return reader.GetInt32(colIndex);
            }
            else
            {
                return null;
            }
        }

        //public static DateTime SafeGetDate(this SqlDataReader reader, string colName)
        //{
        //    int colIndex = reader.GetOrdinal(colName);

        //    if (!reader.IsDBNull(colIndex))
        //    {
        //        return Convert.ToDateTime(reader.GetString(colIndex)) ;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
    }
}