using UnityEngine;

namespace Player
{
    public class PlayerAnimator : MonoBehaviour
    {
        private static Animator _animator;
        private static readonly int PlayerTakesDamage = Animator.StringToHash("PlayerTakesDamage");

        private void Start()
        {
            _animator = GetComponent<Animator>(); 
        }

        public static void PlayerTakeDamage()
        {
            _animator.SetTrigger(PlayerTakesDamage);
        }
    }
}
