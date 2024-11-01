using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class SqlQueryBuilder
    {
        private string _tableName;
        private string _operation;
        private List<string> _columns = new List<string>();
        private List<string> _values = new List<string>();
        private string _whereClause;

        public SqlQueryBuilder SetTable(string tableName)
        {
            _tableName = tableName;
            return this;
        }

        public SqlQueryBuilder SetOperation(string operation)
        {
            _operation = operation.ToLower();
            return this;
        }

        public string Build(Type classType)
        {
            // Set columns and values based on the operation
            SetColumnsFromClass(classType);

            switch (_operation)
            {
                case "insert":
                    return BuildInsert();
                case "update":
                    return BuildUpdate();
                case "delete":
                    return BuildDelete();
                case "select":
                    return BuildSelect();
                case "create table":
                    return BuildCreateTable(classType);
                default:
                    throw new InvalidOperationException("Operación no válida");
            }
        }

        private void SetColumnsFromClass(Type classType)
        {
            foreach (var property in classType.GetProperties())
            {
                _columns.Add(property.Name);
                _values.Add($"@{property.Name}");
            }
        }

        private string BuildInsert()
        {
            var columns = string.Join(", ", _columns);
            var values = string.Join(", ", _values);
            return $"INSERT INTO {_tableName} ({columns}) VALUES ({values});";
        }

        private string BuildUpdate()
        {
            var setClause = string.Join(", ", _columns.Select((col, idx) => $"{col} = {_values[idx]}"));
            return $"UPDATE {_tableName} SET {setClause} WHERE Id = @Id;";
        }

        private string BuildDelete()
        {
            return $"DELETE FROM {_tableName} WHERE Id = @Id;";
        }

        private string BuildSelect()
        {
            var columns = string.Join(", ", _columns);
            return $"SELECT {columns} FROM {_tableName} WHERE Id = @Id;";
        }

        private string BuildCreateTable(Type classType)
        {
            var columnDefinitions = new List<string>();

            foreach (var property in classType.GetProperties())
            {
                string sqlType = MapToSqlType(property.PropertyType);
                columnDefinitions.Add($"{property.Name} {sqlType}");
            }

            // Agregar clave primaria si se requiere (puedes ajustar según tus necesidades)
            columnDefinitions.Insert(0, "Id INT PRIMARY KEY IDENTITY(1,1)");

            var columns = string.Join(", ", columnDefinitions);
            return $"CREATE TABLE {_tableName} ({columns});";
        }

        private string MapToSqlType(Type type)
        {
            if (type == typeof(int)) return "INT";
            if (type == typeof(string)) return "VARCHAR(255)";
            if (type == typeof(double)) return "DECIMAL(18, 2)";
            if (type == typeof(bool)) return "BIT";
            if (type == typeof(DateTime)) return "DATETIME";
            if (type == typeof(float)) return "FLOAT";
            // Agregar otros mapeos de tipos según sea necesario
            return "VARCHAR(255)";
        }
    }

}
