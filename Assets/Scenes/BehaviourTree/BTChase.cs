using UnityEngine;

[CreateAssetMenu(fileName = "BTChase", menuName = "BehaviourTree/Chase")]
public class BTChase : BTNode
{
    public override bool Execute(EnemyAI enemy)
    {
        if (enemy.CanSeePlayer())
        {
            enemy.agent.SetDestination(enemy.player.position);
            return true;
        }
        return false;
    }
}
