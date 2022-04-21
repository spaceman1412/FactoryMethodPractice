using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodPattern.Model;

namespace FactoryMethodPattern.Factory
{
    public interface DeadlineFactory
    {
        public List<Deadline> GetDeadlines();
    }

}
