using UnityEngine;

public class EnvironmentSystem : MonoBehaviour
{
    public int treeCount = 0;

    public void PlantTree()
    {
        treeCount++;
        Debug.Log("একটি গাছ লাগানো হয়েছে");
    }
}