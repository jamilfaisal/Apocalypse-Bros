using UnityEngine;

namespace Managers
{
    [CreateAssetMenu(fileName = "PlayerAttributes", menuName = "Game/Player Attributes", order = 1)]
    public class PlayerAttributes : ScriptableObject
    {
        public string playerName;
        public int playerLevel = 1;
        public int techPoints;
        public int maxHealth = 100;
        public int currentHealth = 100;
        public int damage = 1;
        public double reloadRate = 1;
        public int healthRegenerationRate = 0;
    }
}