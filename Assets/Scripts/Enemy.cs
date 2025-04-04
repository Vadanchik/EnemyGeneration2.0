using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    [SerializeField] private Target _target;

    private void Update()
    {
        Move();
        Rotate();
    }

    public void Init(Target target)
    {
        _target = target;
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.transform.position, _movementSpeed * Time.deltaTime);
    }

    private void Rotate()
    {
        transform.rotation = Quaternion.LookRotation(_target.transform.position - transform.position);
    }
}