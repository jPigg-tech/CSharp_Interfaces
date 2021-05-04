using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            // Instead of Console.WriteLine we use the Ilogger
            // interface for dependency injection and pass the message

            _logger.LogInfo("Migration started at {0}" + DateTime.Now);
            
            // Details of migrating the database 

            _logger.LogInfo("Migration started at {0}" + DateTime.Now);

            // This is open closed priciple, Open for extension but closed
            // for modifacation
            // we extended it by creating new logger classes
            // but did not change anything in this class
            
        }
    }
}
