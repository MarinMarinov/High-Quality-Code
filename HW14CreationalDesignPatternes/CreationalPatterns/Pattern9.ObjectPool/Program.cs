using System;
using System.Collections.Generic;

namespace Pattern9.ObjectPool
{
    public class Program
    {
        public static void Main()
        {
            ToolDepot<Tool> warehouse = new ToolDepot<Tool>();

            Tool hammer = warehouse.GetTool();
            hammer.ToolType = "Hammer";
            hammer.WorkerName = "Pesho Goshov";
            Console.WriteLine("Tool type: {0}, orderd by: {1}, ordered at: {2:MM/dd/yyyy hh:mm:ss.fff tt}", hammer.ToolType, hammer.WorkerName, hammer.TimeOfOrder);

            Tool screwdriver = warehouse.GetTool();
            screwdriver.ToolType = "Screwdriver";
            screwdriver.WorkerName = "Tosho Dimitrov";
            Console.WriteLine("Tool type: {0}, orderd by: {1}, ordered at: {2:MM/dd/yyyy hh:mm:ss.fff tt}", screwdriver.ToolType, screwdriver.WorkerName, screwdriver.TimeOfOrder);

            CheckForAvailableTools(warehouse.availableTools); // TODO doesn't work
            CheckForToolsInUse(warehouse.usedTools);

            Console.WriteLine("Realeasing hammer!");
            warehouse.ReleaseTool(hammer);
            CheckForAvailableTools(warehouse.availableTools);

            Console.WriteLine("Releasing screwdriver");
            warehouse.ReleaseTool(screwdriver);
            CheckForAvailableTools(warehouse.availableTools);
            CheckForToolsInUse(warehouse.usedTools); // TODO doesn't work
        }

        public static void CheckForAvailableTools(List<Tool> tools)
        {
            foreach (Tool tool in tools)
            {
                if (tools.Count != 0)
                {

                    Console.WriteLine("Available tools: " + tool.ToolType);
                }
                else
                {
                    Console.WriteLine("No available tools in the Warehouse availabel list");
                }
            }
        }

        public static void CheckForToolsInUse(List<Tool> tools)
        {
            foreach (var tool in tools)
            {
                if (tools.Count != 0)
                {
                    Console.WriteLine("Tool in use now: " + tool.ToolType);
                }
                else if(tools.Count == 0)
                {
                    Console.WriteLine("No used tools in the Warehouse tools in use list");
                }
            }
        }
    }
}
