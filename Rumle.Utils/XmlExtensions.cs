using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Rumle.Utils
{
    public static class XmlExtensions
    {
        private const NumberStyles DefaultNumberStyles = NumberStyles.Any;
        private const DateTimeStyles DefaultDateTimeStyles = DateTimeStyles.None;

        #region ValueOrDefault

        public static T ValueOrDefault<T>(this XmlNode node, T defaultValue)
        {
            return ValueOrDefault<T>(node, DefaultDateTimeStyles, DefaultNumberStyles, CultureInfo.CurrentCulture, defaultValue);
        }

        public static T ValueOrDefault<T>(this XmlNode node, CultureInfo culture)
        {
            return ValueOrDefault<T>(node, DefaultDateTimeStyles, DefaultNumberStyles, culture, default(T));
        }

        public static T ValueOrDefault<T>(this XmlNode node, CultureInfo culture, T defaultValue)
        {
            return ValueOrDefault<T>(node, DefaultDateTimeStyles, DefaultNumberStyles, culture, defaultValue);
        }

        public static T ValueOrDefault<T>(this XmlNode node, NumberStyles numberStyles)
        {
            return ValueOrDefault<T>(node, DefaultDateTimeStyles, numberStyles, CultureInfo.CurrentCulture, default(T));
        }

        public static T ValueOrDefault<T>(this XmlNode node, DateTimeStyles dateTimeStyles)
        {
            return ValueOrDefault<T>(node, dateTimeStyles, DefaultNumberStyles, CultureInfo.CurrentCulture, default(T));
        }

        public static T ValueOrDefault<T>(this XmlNode node, NumberStyles numberStyles, T defaultValue)
        {
            return ValueOrDefault<T>(node, DefaultDateTimeStyles, numberStyles, CultureInfo.CurrentCulture, defaultValue);
        }

        public static T ValueOrDefault<T>(this XmlNode node, DateTimeStyles dateTimeStyles, T defaultValue)
        {
            return ValueOrDefault<T>(node, dateTimeStyles, DefaultNumberStyles, CultureInfo.CurrentCulture, defaultValue);
        }

        public static T ValueOrDefault<T>(this XmlNode node, NumberStyles numberStyles, CultureInfo culture)
        {
            return ValueOrDefault<T>(node, DefaultDateTimeStyles, numberStyles, culture, default(T));
        }

        public static T ValueOrDefault<T>(this XmlNode node, DateTimeStyles dateTimeStyles, CultureInfo culture)
        {
            return ValueOrDefault<T>(node, dateTimeStyles, DefaultNumberStyles, culture, default(T));
        }

        public static T ValueOrDefault<T>(this XmlNode node, NumberStyles numberStyles, CultureInfo culture, T defaultValue)
        {
            return ValueOrDefault<T>(node, DefaultDateTimeStyles, numberStyles, culture, defaultValue);
        }

        public static T ValueOrDefault<T>(this XmlNode node, DateTimeStyles dateTimeStyles, CultureInfo culture, T defaultValue)
        {
            return ValueOrDefault<T>(node, dateTimeStyles, DefaultNumberStyles, culture, defaultValue);
        }

        private static T ValueOrDefault<T>(XmlNode node, DateTimeStyles dateTimeStyles, NumberStyles numberStyles, CultureInfo culture, T defaultValue)
        {
            if (node != null && !string.IsNullOrEmpty(node.Value))
            {
                return Converter.ConvertOrDefault<T>(node.Value, numberStyles, dateTimeStyles, culture, defaultValue);
            }
            else
            {
                return defaultValue;
            }
        }

        #endregion

        #region AttributeOrDefault

        public static T AttributeOrDefault<T>(this XmlElement node, string attribute, T defaultValue)
        {
            return AttributeOrDefault<T>(node, attribute, DefaultDateTimeStyles, DefaultNumberStyles, CultureInfo.CurrentCulture, defaultValue);
        }

        public static T AttributeOrDefault<T>(this XmlElement node, string attribute, CultureInfo culture)
        {
            return AttributeOrDefault<T>(node, attribute, DefaultDateTimeStyles, DefaultNumberStyles, culture, default(T));
        }

        public static T AttributeOrDefault<T>(this XmlElement node, string attribute, CultureInfo culture, T defaultValue)
        {
            return AttributeOrDefault<T>(node, attribute, DefaultDateTimeStyles, DefaultNumberStyles, culture, defaultValue);
        }

        public static T AttributeOrDefault<T>(this XmlElement node, string attribute, NumberStyles numberStyles)
        {
            return AttributeOrDefault<T>(node, attribute, DefaultDateTimeStyles, numberStyles, CultureInfo.CurrentCulture, default(T));
        }

        public static T AttributeOrDefault<T>(this XmlElement node, string attribute, DateTimeStyles dateTimeStyles)
        {
            return AttributeOrDefault<T>(node, attribute, dateTimeStyles, DefaultNumberStyles, CultureInfo.CurrentCulture, default(T));
        }

        public static T AttributeOrDefault<T>(this XmlElement node, string attribute, NumberStyles numberStyles, T defaultValue)
        {
            return AttributeOrDefault<T>(node, attribute, DefaultDateTimeStyles, numberStyles, CultureInfo.CurrentCulture, defaultValue);
        }

        public static T AttributeOrDefault<T>(this XmlElement node, string attribute, DateTimeStyles dateTimeStyles, T defaultValue)
        {
            return AttributeOrDefault<T>(node, attribute, dateTimeStyles, DefaultNumberStyles, CultureInfo.CurrentCulture, defaultValue);
        }

        public static T AttributeOrDefault<T>(this XmlElement node, string attribute, NumberStyles numberStyles, CultureInfo culture)
        {
            return AttributeOrDefault<T>(node, attribute, DefaultDateTimeStyles, numberStyles, culture, default(T));
        }

        public static T AttributeOrDefault<T>(this XmlElement node, string attribute, DateTimeStyles dateTimeStyles, CultureInfo culture)
        {
            return AttributeOrDefault<T>(node, attribute, dateTimeStyles, DefaultNumberStyles, culture, default(T));
        }

        public static T AttributeOrDefault<T>(this XmlElement node, string attribute, NumberStyles numberStyles, CultureInfo culture, T defaultValue)
        {
            return AttributeOrDefault<T>(node, attribute, DefaultDateTimeStyles, numberStyles, culture, defaultValue);
        }

        public static T AttributeOrDefault<T>(this XmlElement node, string attribute, DateTimeStyles dateTimeStyles, CultureInfo culture, T defaultValue)
        {
            return AttributeOrDefault<T>(node, attribute, dateTimeStyles, DefaultNumberStyles, culture, defaultValue);
        }

        private static T AttributeOrDefault<T>(XmlElement node, string attribute, DateTimeStyles dateTimeStyles, NumberStyles numberStyles, CultureInfo culture, T defaultValue)
        {
            if (node != null && node.HasAttribute(attribute) && node.Attributes[attribute] != null)
            {
                return Converter.ConvertOrDefault<T>(node.Attributes[attribute].Value, numberStyles, dateTimeStyles, culture, defaultValue);
            }
            else
            {
                return defaultValue;
            }
        }

        #endregion

    }
}
