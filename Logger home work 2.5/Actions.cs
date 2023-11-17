using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger_home_work_2._5
{
    public class Actions
    {
        private readonly Logger logger;

        public Actions(Logger logger)
        {
            this.logger = logger;
        }

        public void StartMethod()
        {
            logger.LogInfo("Start method: StartMethod");
        }

        public void SkipLogic()
        {
            throw new BusinessException("Skipped logic in method");
        }

        public void BreakLogic()
        {
            throw new Exception("I broke a logic");
        }
    }
}
