using UnityEngine;
using UnityEngine.AI;

namespace Mob
{
    public class MobMovement : MonoBehaviour
    {
        [SerializeField] private Transform player;
        private NavMeshAgent _agent;
        
        void Start()
        {
            _agent = GetComponent<NavMeshAgent>();
        }
        
        void Update()
        {
            _agent.destination = player.position;
        }
    }
}
