using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class SearchZone : MonoBehaviour
{
    public NavMeshSurface navMeshSurface;
    public Transform[] searchPoints;

    void Start()
    {
        GenerateNavMesh();
    }

    public void GenerateNavMesh()
    {
        navMeshSurface.BuildNavMesh();
    }
}
