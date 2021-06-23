using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace Proyecto_DPEE.Utilerias
{
    public static class ClsUtilerias
    {

        #region -  PARSEOS  -

        public static int ToInteger(this string x)
        {
            try
            {
                return x.IsNullOrEmpty() ? 0 : Int32.Parse(x);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static decimal ToDecimal(this string x)
        {
            try
            {
                return x.IsNullOrEmpty() ? 0 : Convert.ToDecimal(x);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static DateTime ToDateTime(this string x)
        {
            x = x.IsNullOrEmpty() ? null : x;
            return Convert.ToDateTime(x);
        }

        public static bool ToBool(this string x)
        {
            bool result = false;

            if (bool.TryParse(x, out _))
            {
                result = bool.Parse(x);
            }
            else if (x.Length == 1)
            {
                result = x == "1";
            }

            return result;
        }

        public static bool? ToBoolNulleable(this string x)
        {
            bool? result = null;

            if (bool.TryParse(x, out _))
            {
                result = bool.Parse(x);
            }
            else if (x.Length == 1)
            {
                result = x == "1";
            }

            return result;
        }

        public static bool IsNullOrEmpty(this string x)
        {
            return String.IsNullOrEmpty(x);
        }

        public static TimeSpan ToTime(this string x)
        {
            if (!TimeSpan.TryParse(x, out TimeSpan time))
            {
                time = new TimeSpan(0, 0, 0);
            }
            return time;
        }

        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }

        #endregion

        #region -  ENCRIPTADO  -

        public static string Encriptar(this string x)
        {
            try
            {
                return ClsEncriptar.Encriptar(x);
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static string Desencriptar(this string x)
        {
            try
            {
                return ClsEncriptar.Desencriptar(x);
            }
            catch (Exception)
            {
                return "";
            }
        }

        #endregion

    }
}
