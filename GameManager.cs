using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int budget = 1000;
    public int population = 1000000;
    public int environment = 50;
    public int armyStrength = 100;

    void Start()
    {
        Debug.Log("দেশ পরিচালনা গেম শুরু হয়েছে!");
    }
}