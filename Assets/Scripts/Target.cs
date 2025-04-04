using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private List<Waypoint> _waypoints;
    [SerializeField] private float _movementSpeed;

    private int _currentWaypointIndex = 0;

    private void Update()
    {
        if ((_waypoints[_currentWaypointIndex].transform.position - transform.position).magnitude == 0)
        {
            ToogleCurrentWaypoint();
        }

        Rotate();
        Move();
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _waypoints[_currentWaypointIndex].transform.position, _movementSpeed * Time.deltaTime);
    }

    private void Rotate()
    {
        transform.rotation = Quaternion.LookRotation(_waypoints[_currentWaypointIndex].transform.position - transform.position);
    }

    private void ToogleCurrentWaypoint()
    {
        _currentWaypointIndex = (_currentWaypointIndex + 1) % _waypoints.Count;
    }
}
