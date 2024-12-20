using UnityEngine;

namespace Managers
{
    [CreateAssetMenu(fileName = "PlayerAttributes", menuName = "Game/Player Attributes", order = 1)]
    public class PlayerAttributes : ScriptableObject
    {
        public string playerName;
        public int playerLevel = 1;
        public int techPoints;
        private int _maxHealth = 100;
        private int _currentHealth = 100;
        public int damage = 1;
        public double reloadRate = 1;
        private int _healthRegenerationRate = 0;
        public void LevelUp()
        {
            playerLevel++;
            techPoints++;
        }
    }
}