using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models.Attributes
{
    public class UnicodeAttribute : ColumnAttribute
    {
        public UnicodeAttribute(int length)
        {
            TypeName = $"nvarchar({length})";
        }
    }
}
