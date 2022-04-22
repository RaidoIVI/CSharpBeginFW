using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession5Task1_2_3FW
{
    internal class FileIO
    {
        private const string _fileName = "ToDo.bin";

        internal void ReadList(List<Task> Tasks)
        {
            var file = new FileInfo(_fileName);
            if (!file.Exists)
            {
                file.Create();
            }
            var tasksString = File.ReadAllBytes(file.FullName).ToString;
            foreach (var task in tasksString)
            {
                Tasks.Append(new Task(task.Remove(task.Length - 1), bool.Parse(task.Substring(task.Length - 1))));
            }
        }
    }
}
