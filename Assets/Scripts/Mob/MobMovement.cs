using UnityEngine;
using UnityEngine.AI;

namespace Mob
{
    public class MobMovement : MonoBehaviour
    {
        [SerializeField] private Transform player;
        private NavMeshAgent _agent;
        
        private void Start()
        {
            _agent = GetComponent<NavMeshAgent>();
        }
        
        private void Update()
        {
            _agent.destination = player.position;
        }
    }
}
