using UnityEngine;

namespace Managers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }
        public PlayerAttributesManager AttributesManager { get; private set; }
        public PlayerLevelManager LevelManager { get; private set; }

        private void Awake()
        {
            if (!Instance)
            {
                Instance = this;
                AttributesManager = GetComponent<PlayerAttributesManager>();
                LevelManager = GetComponent<PlayerLevelManager>();
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
