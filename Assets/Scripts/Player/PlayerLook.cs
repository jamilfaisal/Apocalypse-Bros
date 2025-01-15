using Unity.Cinemachine;
using UnityEngine;

namespace Player
{
    public class PlayerLook : MonoBehaviour
    {
        private const float MinLookDown = 40f;
        private const float MaxLookUp = 115f;
        private float _mouseSensitivity = 1f;
        [SerializeField] private Transform playerBody;
        [SerializeField] private Transform turret;
        [SerializeField] private CinemachineCamera virtualCamera;
        private float _verticalRotation;
        private PlayerInputActions _playerInputActions;

        private void Start()
        {
            _playerInputActions = GetComponent<PlayerInput>().GetPlayerInputActions();
            Cursor.lockState = CursorLockMode.Locked;
        }

        private void Update()
        {
            var moveInput = _playerInputActions.Player.MoveCamera.ReadValue<Vector2>() * _mouseSensitivity;

            RotateHorizontally(moveInput.x);
            RotateVertically(moveInput.y);
        }

        private void RotateVertically(float mouseY)
        {
            _verticalRotation -= mouseY * _mouseSensitivity;
            _verticalRotation = Mathf.Clamp(_verticalRotation, MinLookDown, MaxLookUp);
            virtualCamera.transform.localRotation = Quaternion.Euler(_verticalRotation, 0f, 0f);
            turret.transform.localRotation = Quaternion.Euler(_verticalRotation, 0f, 0f);
        }

        private void RotateHorizontally(float mouseX)
        {
            playerBody.Rotate(Vector3.up * mouseX);
        }

        public void SetSensitivity(float sensitivity)
        {
            _mouseSensitivity = sensitivity;
        }
    }
}
