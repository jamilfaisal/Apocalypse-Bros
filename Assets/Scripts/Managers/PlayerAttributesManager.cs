using UnityEngine;

namespace Managers
{
    public class PlayerAttributesManager : MonoBehaviour
    {
        public PlayerAttributes loadedAttributes;
        private PlayerAttributes _currentAttributes;

        private void Start()
        {
            _currentAttributes = Instantiate(loadedAttributes);
        }

        public void LevelUp()
        {
            _currentAttributes.LevelUp();
            Debug.Log($"Level: {_currentAttributes.playerLevel}");
        }

        public PlayerAttributes GetPlayerAttributes()
        {
            return _currentAttributes;
        }
    }
}