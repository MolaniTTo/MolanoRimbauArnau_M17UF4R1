using UnityEngine;

[CreateAssetMenu(fileName = "BTFlee", menuName = "BehaviourTree/Flee")]
public class BTFlee : BTNode
{
    public override bool Execute(EnemyAI enemy)
    {
        if (enemy.health < 50)
        {
            Vector3 fleeDirection = enemy.transform.position - enemy.player.position;
            enemy.agent.SetDestination(enemy.transform.position + fleeDirection.normalized * 10f); // Huye en dirección opuesta al jugador
            return true;
        }
        return false;
    }
}
