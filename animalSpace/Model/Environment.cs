using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalSpace.Model
{
    internal class Environment
    {
        public string EnvironmentName;

        public Environment(string environment)
        {
            EnvironmentName = environment;
        }

        public string getEnvironmentName()
        {
            return EnvironmentName;
        }

        public void setEnvironmentName(string environmentName)
        {
            EnvironmentName = environmentName;
        }
    }
}
