using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace NChart.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value, bool useNameAsDefault = true)
        {
            var description = value.GetType().GetMember(value.ToString()).FirstOrDefault()?.GetCustomAttribute<DescriptionAttribute>()?.Description;
            return description ?? (useNameAsDefault ? value.ToString() : string.Empty);
        }
    }
}
