using Microsoft.Xna.Framework.Input;

namespace TractorMod.Framework
{
    public class TractorConfig
    {
        public class ToolConfig
        {
            public string name { get; set; } = "";
            public int minLevel { get; set; } = 0;
            public int effectRadius { get; set; } = 1;
            public int activeEveryTickAmount { get; set; } = 1;
            private int activeCount = 0;

            public ToolConfig() { }

            public ToolConfig(string nameInput)
            {
                name = nameInput;
            }

            public ToolConfig(string nameInput, int minLevelInput, int radiusInput, int activeEveryTickAmountInput)
            {
                name = nameInput;
                minLevel = minLevelInput;
                effectRadius = radiusInput;
                if (activeEveryTickAmountInput <= 0)
                    activeEveryTickAmount = 1;
                else
                    activeEveryTickAmount = activeEveryTickAmountInput;
            }

            public void incrementActiveCount()
            {
                activeCount++;
                activeCount %= activeEveryTickAmount;
            }

            public bool canToolBeActive()
            {
                return (activeCount == 0);
            }
        }
        public string info1 = "Add tool with exact name you would like to use with Tractor Mode.";
        public string info2 = "Also custom minLevel and effective radius for each tool.";
        public string info3 = "Ingame tools included: Pickaxe, Axe, Hoe, Watering Can.";
        public string info4 = "I haven't tried tools like Shears or Milk Pail but you can :)";
        public string info5 = "Delete Scythe entry if you don't want to harvest stuff.";
        public ToolConfig[] tool { get; set; } = {
            new ToolConfig("Scythe", 0, 2, 1),
            new ToolConfig("Hoe"),
            new ToolConfig("Watering Can")
        };

        public int ItemRadius { get; set; } = 1;
        public int holdActivate { get; set; } = 0;
        public Keys tractorKey { get; set; } = Keys.B;
        public int tractorSpeed { get; set; } = -2;
        public Keys horseKey { get; set; } = Keys.None;
        public Keys PhoneKey { get; set; } = Keys.N;
        public int TractorHousePrice { get; set; } = 150000;
        public Keys updateConfig { get; set; } = Keys.P;
    }
}
