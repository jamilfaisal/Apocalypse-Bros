using UnityEngine;
using System;
using Random = System.Random;

namespace Mob
{
    public class MobSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject mobPrefab;
        private Vector3 _floorDimensions;
        private int _radius;
        private double _randomAngleRadians;
        private int _xCoordinate;
        private int _zCoordinate;
        private double _timeSinceLastSpawn;
        private readonly Random _randomNumber = new Random();
        private const int DistanceFromMapEdge = 10;

        private void Start()
        {
            _floorDimensions = transform.localScale;
            _radius = ((int)_floorDimensions.x / 2) - DistanceFromMapEdge;
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
            MobSpawnCoordinates();
            Instantiate(mobPrefab, new Vector3(_xCoordinate, 10, _zCoordinate), Quaternion.identity);
        }

        private void MobSpawnCoordinates()
        {
            _randomAngleRadians = _randomNumber.Next(360)*(Math.PI/180);
            _xCoordinate = (int)(_radius * Math.Sin(_randomAngleRadians));
            _zCoordinate = (int)(_radius * Math.Cos(_randomAngleRadians));
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
