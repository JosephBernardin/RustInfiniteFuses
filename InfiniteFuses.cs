using Oxide.Core.Plugins;
using System;

namespace Oxide.Plugins
{
    [Info("InfiniteFuses", "Penguin", "1.0.2")]
    public class InfiniteFuses : RustPlugin
    {
        private void Init()
        {
            Puts("InfiniteFuses plugin loaded.");
        }

        object OnLoseCondition(Item item, ref float amount)
        {
            // For debugging purposes
            // Initial Condition of a full fuse is 200
            
            // Puts($"Item: {item.info.shortname}, Initial Condition: {item.condition}, Damage Attempt: {amount}"); 
            
            // Checks if its a fuse being damaged
            if (item.info.shortname == "fuse")
            {
                amount = 0;  // Set the amount of condition loss to 0
            }
            return null;
        }
    }
}