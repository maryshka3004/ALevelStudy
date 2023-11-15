using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger_home_work_2._5
{
    public class App
    {
        public void Run()
        {
            Logger logger = new Logger();
            Actions actions = new Actions(logger);
            FileService fileService = new FileService("Logs");

            for (int i = 0; i < 100; i++)
            {
                try
                {
                    Random random = new Random();
                    int actionIndex = random.Next(1, 4);

                    switch (actionIndex)
                    {
                        case 1:
                            actions.StartMethod();
                            break;
                        case 2:
                            actions.SkipLogic();
                            break;
                        case 3:
                            actions.BreakLogic();
                            break;
                    }
                }
                catch (BusinessException ex)
                {
                    logger.LogWarning($"Action got this custom Exception: {ex.Message}");
                }
                catch (Exception ex)
                {
                    logger.LogError($"Action failed by reason: {ex}");
                }
            }
        }
    }
}
