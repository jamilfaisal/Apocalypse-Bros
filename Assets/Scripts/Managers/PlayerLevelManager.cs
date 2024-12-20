using System;
using UnityEngine;

namespace Managers
{
    public class PlayerLevelManager : MonoBehaviour
    {
        private PlayerAttributesManager _attributesManager;
        private int _playerXp;
        private int _xpToNextLevel = 100;

        private void Start()
        {
            _attributesManager = MetaManager.Instance.AttributesManager;
        }

        public void AddXp(int xp)
        {
            _playerXp += xp;
            if (_playerXp >= _xpToNextLevel)
            {
                LevelUp();
            }
        }

        private void LevelUp()
        {
            _playerXp = 0;
            _xpToNextLevel = CalculateXpToNextLevel();
            _attributesManager.LevelUp();
        }

        private int CalculateXpToNextLevel()
        {
            return _xpToNextLevel + 100;
        }
    }
}