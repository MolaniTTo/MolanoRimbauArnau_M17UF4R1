using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public float health = 100f;
    public Transform[] patrolPoints;
    private int patrolIndex = 0;

    public BTNode behaviourTree;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        behaviourTree.Execute(this);
    }

    public void NextPatrolPoint()
    {
        patrolIndex = (patrolIndex + 1) % patrolPoints.Length;
        agent.SetDestination(patrolPoints[patrolIndex].position);
    }

    public bool CanSeePlayer()
    {
        return Vector3.Distance(transform.position, player.position) < 10f;
    }
}
