using UnityEngine;

namespace Player
{
    public class PlayerInput : MonoBehaviour
    {
        private PlayerInputActions _playerInputActions;
    
        private void Start()
        {
            _playerInputActions = new PlayerInputActions();
            _playerInputActions.Player.Enable();
        }
    
        public PlayerInputActions GetPlayerInputActions()
        {
            return _playerInputActions;
        }
    }
}
