using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumle.Utils
{
    public static class Converter
    {
        #region any

        public static T ConvertOrDefault<T>(string value)
        {
            return ConvertOrDefault<T>(value, NumberStyles.Any, DateTimeStyles.None, CultureInfo.CurrentCulture, default(T));
        }

        public static T ConvertOrDefault<T>(string value, T defaultValue)
        {
            return ConvertOrDefault<T>(value, NumberStyles.Any, DateTimeStyles.None, CultureInfo.CurrentCulture, defaultValue);
        }

        public static T ConvertOrDefault<T>(string value, CultureInfo culture)
        {
            return ConvertOrDefault<T>(value, NumberStyles.Any, DateTimeStyles.None, culture, default(T));
        }

        public static T ConvertOrDefault<T>(string value, CultureInfo culture, T defaultValue)
        {
            return ConvertOrDefault<T>(value, NumberStyles.Any, DateTimeStyles.None, culture, defaultValue);
        }

        #endregion

        #region numbers

        public static T ConvertOrDefault<T>(string value, NumberStyles numberStyles)
        {
            return ConvertOrDefault<T>(value, numberStyles, DateTimeStyles.None, CultureInfo.CurrentCulture, default(T));
        }

        public static T ConvertOrDefault<T>(string value, NumberStyles numberStyles, T defaultValue)
        {
            return ConvertOrDefault<T>(value, numberStyles, DateTimeStyles.None, CultureInfo.CurrentCulture, defaultValue);
        }

        public static T ConvertOrDefault<T>(string value, NumberStyles numberStyles, CultureInfo culture)
        {
            return ConvertOrDefault<T>(value, numberStyles, DateTimeStyles.None, culture, default(T));
        }

        public static T ConvertOrDefault<T>(string value, NumberStyles numberStyles, CultureInfo culture, T defaultValue)
        {
            return ConvertOrDefault<T>(value, numberStyles, DateTimeStyles.None, culture, defaultValue);
        }

        #endregion

        #region dates

        public static T ConvertOrDefault<T>(string value, DateTimeStyles dateTimeStyles)
        {
            return ConvertOrDefault<T>(value, NumberStyles.Any, dateTimeStyles, CultureInfo.CurrentCulture, default(T));
        }

        public static T ConvertOrDefault<T>(string value, DateTimeStyles dateTimeStyles, T defaultValue)
        {
            return ConvertOrDefault<T>(value, NumberStyles.Any, dateTimeStyles, CultureInfo.CurrentCulture, defaultValue);
        }

        public static T ConvertOrDefault<T>(string value, DateTimeStyles dateTimeStyles, CultureInfo culture)
        {
            return ConvertOrDefault<T>(value, NumberStyles.Any, dateTimeStyles, culture, default(T));
        }

        public static T ConvertOrDefault<T>(string value, DateTimeStyles dateTimeStyles, CultureInfo culture, T defaultValue)
        {
            return ConvertOrDefault<T>(value, NumberStyles.Any, dateTimeStyles, culture, defaultValue);
        }

        #endregion


        #region any

        public static bool TryConvert<T>(string value, out T converted)
        {
            return TryConvert<T>(value, NumberStyles.Any, DateTimeStyles.None, CultureInfo.CurrentCulture, out converted);
        }

        public static bool TryConvert<T>(string value, T defaultValue, out T converted)
        {
            return TryConvert<T>(value, NumberStyles.Any, DateTimeStyles.None, CultureInfo.CurrentCulture, out converted);
        }

        public static bool TryConvert<T>(string value, CultureInfo culture, out T converted)
        {
            return TryConvert<T>(value, NumberStyles.Any, DateTimeStyles.None, culture, out converted);
        }

        public static bool TryConvert<T>(string value, CultureInfo culture, T defaultValue, out T converted)
        {
            return TryConvert<T>(value, NumberStyles.Any, DateTimeStyles.None, culture, out converted);
        }

        #endregion

        #region numbers

        public static bool TryConvert<T>(string value, NumberStyles numberStyles, out T converted)
        {
            return TryConvert<T>(value, numberStyles, DateTimeStyles.None, CultureInfo.CurrentCulture, out converted);
        }

        public static bool TryConvert<T>(string value, NumberStyles numberStyles, T defaultValue, out T converted)
        {
            return TryConvert<T>(value, numberStyles, DateTimeStyles.None, CultureInfo.CurrentCulture, out converted);
        }

        public static bool TryConvert<T>(string value, NumberStyles numberStyles, CultureInfo culture, out T converted)
        {
            return TryConvert<T>(value, numberStyles, DateTimeStyles.None, culture, out converted);
        }

        public static bool TryConvert<T>(string value, NumberStyles numberStyles, CultureInfo culture, T defaultValue, out T converted)
        {
            return TryConvert<T>(value, numberStyles, DateTimeStyles.None, culture, out converted);
        }

        #endregion

        #region dates

        public static bool TryConvert<T>(string value, DateTimeStyles dateTimeStyles, out T converted)
        {
            return TryConvert<T>(value, NumberStyles.Any, dateTimeStyles, CultureInfo.CurrentCulture, out converted);
        }

        public static bool TryConvert<T>(string value, DateTimeStyles dateTimeStyles, T defaultValue, out T converted)
        {
            return TryConvert<T>(value, NumberStyles.Any, dateTimeStyles, CultureInfo.CurrentCulture, out converted);
        }

        public static bool TryConvert<T>(string value, DateTimeStyles dateTimeStyles, CultureInfo culture, out T converted)
        {
            return TryConvert<T>(value, NumberStyles.Any, dateTimeStyles, culture, out converted);
        }

        public static bool TryConvert<T>(string value, DateTimeStyles dateTimeStyles, CultureInfo culture, T defaultValue, out T converted)
        {
            return TryConvert<T>(value, NumberStyles.Any, dateTimeStyles, culture, out converted);
        }

        #endregion

        public static T ConvertOrDefault<T>(string value, NumberStyles numberStyles, DateTimeStyles dateTimeStyles, CultureInfo culture, T defaultValue)
        {
            T result;
            return TryConvert<T>(value, numberStyles, dateTimeStyles, culture, out result)
                ? result
                : defaultValue;
        }

        private static bool TryConvert<T>(string value, NumberStyles numberStyles, DateTimeStyles dateTimeStyles, CultureInfo culture, out T outResult)
        {
            TypeCode tc;
            object result = null;

            try
            {
                if (Enum.TryParse(typeof(T).Name, out tc))
                {

                    switch (tc)
                    {
                        case TypeCode.Boolean:
                            result = bool.Parse(value);
                            break;
                        case TypeCode.Char:
                            result = char.Parse(value);
                            break;
                        case TypeCode.SByte:
                            result = sbyte.Parse(value, numberStyles, culture);
                            break;
                        case TypeCode.Byte:
                            result = byte.Parse(value, numberStyles, culture);
                            break;
                        case TypeCode.Int16:
                            result = Int16.Parse(value, numberStyles, culture);
                            break;
                        case TypeCode.UInt16:
                            result = UInt16.Parse(value, numberStyles, culture);
                            break;
                        case TypeCode.Int32:
                            result = Int32.Parse(value, numberStyles, culture);
                            break;
                        case TypeCode.UInt32:
                            result = UInt32.Parse(value, numberStyles, culture);
                            break;
                        case TypeCode.Int64:
                            result = Int64.Parse(value, numberStyles, culture);
                            break;
                        case TypeCode.UInt64:
                            result = UInt64.Parse(value, numberStyles, culture);
                            break;
                        case TypeCode.Single:
                            result = Single.Parse(value, numberStyles, culture);
                            break;
                        case TypeCode.Double:
                            result = double.Parse(value, numberStyles, culture);
                            break;
                        case TypeCode.Decimal:
                            result = decimal.Parse(value, numberStyles, culture);
                            break;
                        case TypeCode.DateTime:
                            result = DateTime.Parse(value, culture, dateTimeStyles);
                            break;
                        case TypeCode.String:
                            result = value;
                            break;
                        case TypeCode.Empty:
                        case TypeCode.Object:
                        case TypeCode.DBNull:
                        default:
                            break;
                    }
                }
                else
                {
                    result = (T)Convert.ChangeType(value, typeof(T), culture);
                }

                if (result != null)
                {
                    outResult = (T)result;
                    return true;
                }
            }
            catch (ArgumentNullException e)
            {
            }
            catch (FormatException e)
            {
            }
            catch (OverflowException e)
            {
            }
            catch (ArgumentException e)
            {
            }
            catch (InvalidCastException e)
            {
            }

            outResult = default(T);
            return false;
        }
    }
}
