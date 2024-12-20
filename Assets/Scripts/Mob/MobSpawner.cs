using UnityEngine;
using System;
using Random = System.Random;

namespace Mob
{
    public class MobSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject mobPrefab;
        private int _radius;
        private double _timeSinceLastSpawn;
        private readonly Random _randomNumber = new Random();
        private const int DistanceFromMapEdge = 10;

        private void Start()
        {
            _radius = ((int)transform.localScale.x / 2) - DistanceFromMapEdge;
        }

        private void Update()
        {
            if (SpawnTimer())
            {
                SpawnMob();
            }
        }

        private void SpawnMob()
        {
            Vector3 mobSpawnCoordinates = CalculateMobSpawnCoordinates();
            Instantiate(mobPrefab, mobSpawnCoordinates, Quaternion.identity);
        }

        private Vector3 CalculateMobSpawnCoordinates()
        {
            double randomAngleRadians = _randomNumber.Next(360)*(Math.PI/180);
            int xCoordinate = (int)(_radius * Math.Sin(randomAngleRadians));
            int zCoordinate = (int)(_radius * Math.Cos(randomAngleRadians));
            int yCoordinate = (int)(transform.position.y + 10);
            return new Vector3(xCoordinate, yCoordinate, zCoordinate);
        }

        private bool SpawnTimer()
        {
            if (_timeSinceLastSpawn > 2)
            {
                _timeSinceLastSpawn = 0;
                return true;
            }
            _timeSinceLastSpawn += Time.deltaTime;
            return false;
                
        }
    }
}
