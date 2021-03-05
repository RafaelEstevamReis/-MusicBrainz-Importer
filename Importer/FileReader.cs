using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Importer
{
    public class FileReader
    {
        public string FileName { get; }

        public FileReader(string fileName)
        {
            FileName = fileName;
        }

        public IEnumerable<string[]> GetLines()
        {
            using (var sr = File.OpenText(FileName))
            {
                while (!sr.EndOfStream)
                {
                    yield return sr.ReadLine().Split('\t');
                }
            }
        }

        public IEnumerable<T> Get<T>()
        {
            var type = typeof(T);
            var props = type.GetProperties();

            foreach (var row in GetLines())
            {
                if (row.Length != props.Length) throw new InvalidOperationException("Row len mismatch");

                var nObj = (T)Activator.CreateInstance(type);

                for (int i = 0; i < row.Length; i++)
                {
                    var pType = props[i].PropertyType;
                    object val = row[i];

                    if (row[i] == "\\N")
                    {
                        val = null;
                    }
                    else
                    {
                        if (pType == typeof(string)) { }
                        else if (pType == typeof(Guid)) { val = Guid.Parse(row[i]); }
                        else if (pType == typeof(bool)) { val = row[i] == "t" ; }
                        else if (pType == typeof(DateTime)) { val = DateTime.Parse(row[i]); }
                        else
                        {
                            val = Convert.ChangeType(row[i], pType);
                        }

                    }

                    props[i].SetValue(nObj, val);
                }

                yield return nObj;

            }
        }

    }
}
