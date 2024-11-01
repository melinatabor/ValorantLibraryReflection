using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class ReflectionHelper
    {
        private static Assembly assembly = typeof(ValorantLibrary.Agente).Assembly;

        public static List<string> GetClases()
        {
            return assembly.GetTypes()
            .Where(t => t.IsClass && t.Namespace == "ValorantLibrary")
            .Select(t => t.Name)
            .ToList();
        }

        public static Type GetTipoClase(string nombreClase)
        {
            return assembly.GetType($"ValorantLibrary.{nombreClase}");
        }

        public static List<PropertyInfo> GetPropiedades(Type classType)
        {
            return classType.GetProperties().ToList();
        }

        public static string GetTipoRepresentacion(PropertyInfo propiedad)
        {
            if (propiedad.PropertyType.IsEnum)
            {
                var enumValues = Enum.GetNames(propiedad.PropertyType);
                return $"{propiedad.PropertyType.Name} ({string.Join(", ", enumValues)})";
            }

            return propiedad.PropertyType.Name;
        }
    }
}
