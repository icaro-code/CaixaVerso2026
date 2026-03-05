using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MiniSerializador
{
    public class MiniSerializer
    {
        public string Serializar(object obj)
        {
            if (obj == null) return string.Empty;

            var type = obj.GetType();
            var props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            var sb = new StringBuilder();
            foreach (var prop in props)
            {
                // Ignorar indexadores
                if (prop.GetIndexParameters().Length > 0) continue;

                // Ignorar propriedades com [Ocultar]
                if (prop.GetCustomAttribute<OcultarAttribute>() != null) continue;

                var value = prop.GetValue(obj);
                if (value == null) continue;

                string strValue;

                if (prop.PropertyType.IsEnum)
                {
                    strValue = EnumHelper.GetDisplayName((Enum)value);
                }
                else if (prop.PropertyType == typeof(DateTime))
                {
                    strValue = ((DateTime)value).ToString("yyyy-MM-dd");
                }
                else if (!prop.PropertyType.IsPrimitive && prop.PropertyType != typeof(string))
                {
                    // Suporte a objetos aninhados (recursividade)
                    strValue = SerializarNested(value, prop.Name);
                    if (!string.IsNullOrEmpty(strValue))
                    {
                        if (sb.Length > 0) sb.Append(";");
                        sb.Append(strValue);
                    }
                    continue;
                }
                else
                {
                    strValue = value.ToString();
                }

                if (sb.Length > 0) sb.Append(";");
                sb.Append($"{prop.Name}={strValue}");
            }

            return sb.ToString();
        }
        private string SerializarNested(object obj, string prefix)
        {
            var type = obj.GetType();
            var props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            var sb = new StringBuilder();

            foreach (var prop in props)
            {
                if (prop.GetIndexParameters().Length > 0) continue;
                if (prop.GetCustomAttribute<OcultarAttribute>() != null) continue;

                var value = prop.GetValue(obj);
                if (value == null) continue;

                string strValue;

                if (prop.PropertyType.IsEnum)
                {
                    strValue = EnumHelper.GetDisplayName((Enum)value);
                }
                else if (prop.PropertyType == typeof(DateTime))
                {
                    strValue = ((DateTime)value).ToString("yyyy-MM-dd");
                }
                else if (!prop.PropertyType.IsPrimitive && prop.PropertyType != typeof(string))
                {
                    strValue = SerializarNested(value, $"{prefix}.{prop.Name}");
                    if (!string.IsNullOrEmpty(strValue))
                    {
                        if (sb.Length > 0) sb.Append(";");
                        sb.Append(strValue);
                    }
                    continue;
                }
                else
                {
                    strValue = value.ToString();
                }

                if (sb.Length > 0) sb.Append(";");
                sb.Append($"{prefix}.{prop.Name}={strValue}");
            }

            return sb.ToString();
        }
    }
}
