using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMTool_SaaS.Service
{
   public interface ITaskService : IService<Domain.Entities.Task>
    {
        IEnumerable<Domain.Entities.Task> Searchfilm(string ch);
    }
}
