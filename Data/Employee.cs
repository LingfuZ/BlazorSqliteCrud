using Microsoft.EntityFrameworkCore;

namespace Employees.Data
{
    public class Employee
    {
        public int Id { get; set; }

        public String Timestamp { get; set; }

        public required String SerializedValue { get; set; }

        public QueueValueType ValueType { get; set; }

        public int EsuIndex { get; set; }

        public int QueueIndex { get; set; }
    }
}
