using CsvHelper;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;

namespace CoreService.Utils
{
    public static class Trace
    {
        private static Dictionary<string, string> requirementsDict = new Dictionary<string, string>();

        public static void REQ(string reqCode, [CallerMemberName] string methodName = null)
        {
            if (methodName != null)
            {
                requirementsDict[methodName] = reqCode;
            }
        }

        public static void GenerateMatrix()
        {
            // Project directory path
            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var projectDirectory = Path.GetFullPath(Path.Combine(baseDirectory, @"..\..\..\..\..\..\..\"));

            // Define the relative path where the CSV file will be saved
            var relativePath = Path.Combine(projectDirectory, "docs", "outros");
            var filePath = Path.Combine(relativePath, "traceability_matrix.csv");

            // Check if the directory exists and create it if it doesn't
            if (!Directory.Exists(relativePath))
            {
                Directory.CreateDirectory(relativePath);
            }

            // Generate the CSV file
            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteHeader(new { Método = string.Empty, CódigoDoRequisito = string.Empty }.GetType());
                csv.NextRecord();
                foreach (var entry in requirementsDict)
                {
                    csv.WriteRecord(new { Método = entry.Key, CódigoDoRequisito = entry.Value });
                    csv.NextRecord();
                }
            }
        }

        public static void RegisterAnnotatedMethods()
        {
            var controllers = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => typeof(ControllerBase).IsAssignableFrom(type));

            foreach (var controller in controllers)
            {
                var methods = controller.GetMethods(BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic)
                    .Where(m => m.GetCustomAttributes(typeof(REQAttribute), false).Length > 0);

                foreach (var method in methods)
                {
                    var attribute = method.GetCustomAttribute<REQAttribute>();
                    if (attribute != null)
                    {
                        REQ(attribute.ReqCode, method.Name);
                    }
                }
            }
        }
    }

    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public sealed class REQAttribute : Attribute
    {
        public string ReqCode { get; }

        public REQAttribute(string reqCode)
        {
            ReqCode = reqCode;
        }
    }
}
