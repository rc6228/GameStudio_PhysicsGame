using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{ 
    public GameObject prefabToSpawn;
    public Transform spawnPoint;

  
    public void SpawnObject()
    {
        if (prefabToSpawn == null)
        {
            Debug.LogWarning("No prefab assigned to ObjectSpawner!");
            return;
        }
        
        Vector3 position = spawnPoint != null ? spawnPoint.position : Vector3.zero;
        Quaternion rotation = spawnPoint != null ? spawnPoint.rotation : Quaternion.identity;

        Instantiate(prefabToSpawn, position, rotation);
    }
}