using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshUpdater : MonoBehaviour
{
    private NavMeshSurface navMeshSurface;

    void Start()
    {
        navMeshSurface = GetComponent<NavMeshSurface>();
        navMeshSurface.BuildNavMesh(); // Construye el NavMesh al inicio
    }

    public void UpdateNavMesh()
    {
        navMeshSurface.BuildNavMesh(); // Llamar cuando se añadan o eliminen obstáculos
    }
}
