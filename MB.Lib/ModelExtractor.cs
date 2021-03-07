using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MB.Lib
{
    public class ModelExtractor
    {
        public string FileName { get; }

        public ModelExtractor(string fileName)
        {
            FileName = fileName;
        }

        public string BuildModel()
        {
            string[] fields = null;
            FileReader fr = new FileReader(FileName);

            foreach (var line in fr.GetLines())
            {
                if (fields == null) fields = line;

                bool anyNull = false;
                for (int i = 0; i < fields.Length; i++)
                {
                    if (fields[i] == "\\N") fields[i] = null;

                    if (line[i] != "\\N")
                    {
                        // try allow a bigger text
                        if (fields[i] == null || fields[i].Length < line[i].Length) fields[i] = line[i];
                    }

                    if (fields[i] == null) anyNull = true;
                }
                if (!anyNull) break;
            }

            string[] dataTypes = new string[fields.Length];
            for (int i = 0; i < fields.Length; i++)
            {
                dataTypes[i] = guessType(fields[i]);
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("public class Model");
            sb.AppendLine("{");
            for (int i = 0; i < dataTypes.Length; i++)
            {
                string name = $"C{i + 1:00}";

                if (i == 0 && dataTypes[i] == "int") name = "Id";
                else if (i == 1 && dataTypes[i] == "Guid") name = "UID";

                sb.AppendLine($"    // Sample: {fields[i]}");
                sb.AppendLine($"    public {dataTypes[i]} {name} {{ get; set; }}");
            }
            sb.AppendLine("}");
            return sb.ToString();
        }

        private string guessType(string example)
        {
            if (example.Length == 36 && example.Contains("-")) return "Guid";
            else if (example.Contains("-") && example.Contains(":") && !example.Any(c=> char.IsLetter(c))) return "DateTime";
            else if (example == "f" || example == "t") return "bool";
            else if (example.All(c => char.IsNumber(c))) return "int";
            else if (example.All(c => char.IsNumber(c) || c == '.')) return "decimal";
            else
            {
            }

            return "string";
        }
    }
}
