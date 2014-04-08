using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumle.Utils
{
    public static class DbExtensions
    {
        public static IDataParameter AddParameterWithValue(this IDbCommand command, string parameterName, object parameterValue)
        {
            var parameter = command.CreateParameter();
            parameter.ParameterName = parameterName;
            parameter.Value = parameterValue;
            command.Parameters.Add(parameter);
            return parameter;
        }
    }
}
