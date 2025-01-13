using UnityEngine;

namespace Managers
{
    public class MetaManager : MonoBehaviour
    {
        public static MetaManager Instance { get; private set; }
        public PlayerAttributesManager PlayerAttributesManager { get; private set; }
        public PlayerLevelManager LevelManager { get; private set; }

        private void Awake()
        {
            if (!Instance)
            {
                Instance = this;
                PlayerAttributesManager = GetComponent<PlayerAttributesManager>();
                LevelManager = GetComponent<PlayerLevelManager>();
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
