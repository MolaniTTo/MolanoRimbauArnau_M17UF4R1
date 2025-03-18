using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BTSequence", menuName = "BehaviourTree/Sequence")]
public class BTSequence : BTNode
{
    public List<BTNode> children = new List<BTNode>();

    public override bool Execute(EnemyAI enemy)
    {
        foreach (BTNode node in children)
        {
            if (!node.Execute(enemy)) return false; // Si un nodo falla, la secuencia se detiene.
        }
        return true; // Todos los nodos tuvieron éxito.
    }
}
