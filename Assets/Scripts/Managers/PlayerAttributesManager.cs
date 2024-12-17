using UnityEngine;

namespace Managers
{
    public class PlayerAttributesManager : MonoBehaviour
    {
        public PlayerAttributes baseAttributes;
        private PlayerAttributes _currentAttributes;

        public int playerLevel = 1;

        private void Start()
        {
            _currentAttributes = Instantiate(baseAttributes);
        }

        public void LevelUp()
        {
            playerLevel++;
            UpdateAttributes();
        }

        private void UpdateAttributes()
        {
            _currentAttributes.ScaleStats(playerLevel);
            Debug.Log($"Level: {playerLevel}");
        }
        
        public PlayerAttributes GetPlayerAttributes()
        {
            return _currentAttributes;
        }
    }
}