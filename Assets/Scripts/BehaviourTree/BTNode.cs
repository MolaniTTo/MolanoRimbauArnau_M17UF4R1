using UnityEngine;

public abstract class BTNode : ScriptableObject
{
    public abstract bool Execute(EnemyAI enemy);
}