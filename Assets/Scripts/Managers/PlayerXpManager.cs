using UnityEngine;

namespace Managers
{
    public class PlayerXpManager : MonoBehaviour
    {
        public PlayerAttributesManager attributesManager;
        private int _playerXp;
        private const int XpToNextLevel = 100;

        public void AddXp(int xp)
        {
            _playerXp += xp;
            if (_playerXp >= XpToNextLevel)
            {
                LevelUp();
            }
        }

        private void LevelUp()
        {
            _playerXp = 0;
            attributesManager.LevelUp();
        }
    }
}