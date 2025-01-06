using Player;
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
        
        public void PlayerTakeDamage(int mobDamage)
        {
            _currentAttributes.currentHealth -= mobDamage;
            PlayerAnimator.PlayerTakeDamage();
            // if (_currentAttributes._currentHealth <= 0)
            // {
            //     _currentAttributes._currentHealth = 0;
            //     MetaManager.Instance.GameOver();
            // }
        }
        
        public void LevelUp()
        {
            _currentAttributes.playerLevel++;
            _currentAttributes.techPoints++;
            Debug.Log($"Level: {_currentAttributes.playerLevel}");
        }

        public PlayerAttributes GetPlayerAttributes()
        {
            return _currentAttributes;
        }
    }
}