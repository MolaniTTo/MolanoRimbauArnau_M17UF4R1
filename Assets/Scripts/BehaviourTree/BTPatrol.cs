using UnityEngine;

[CreateAssetMenu(fileName = "BTPatrol", menuName = "BehaviourTree/Patrol")]
public class BTPatrol : BTNode
{
    public override bool Execute(EnemyAI enemy)
    {
        if (enemy.agent.remainingDistance < 0.5f)
        {
            enemy.NextPatrolPoint();
        }
        return true;
    }
}
