using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.Serialization;

namespace Player
{
    public class PlayerLook : MonoBehaviour
    {
        private float _mouseSensitivity = 100f;
        [SerializeField] private Transform playerBody;
        [SerializeField] private Transform turret;
        private CinemachineCamera _virtualCamera;
        private float _verticalRotation;

        private void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
            _virtualCamera = GetComponentInChildren<CinemachineCamera>();
        }

        private void Update()
        {
            var mouseX = Input.GetAxis("Mouse X") * _mouseSensitivity * Time.deltaTime;
            var mouseY = Input.GetAxis("Mouse Y") * _mouseSensitivity * Time.deltaTime;
            
            RotateHorizontally(mouseX);

            RotateVertically(mouseY);
        }

        private void RotateVertically(float mouseY)
        {
            _verticalRotation -= mouseY;
            _verticalRotation = Mathf.Clamp(_verticalRotation, -45f, 20f);
            _virtualCamera.transform.localRotation = Quaternion.Euler(_verticalRotation, 0f, 0f);
            turret.transform.localRotation = Quaternion.Euler(_verticalRotation + 90, 0f, 0f);
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