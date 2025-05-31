using UnityEngine;

public class BuildingSystem : MonoBehaviour
{
    public int roads = 0;
    public int houses = 0;

    public void BuildRoad()
    {
        roads++;
        Debug.Log("রাস্তা নির্মাণ হয়েছে");
    }

    public void BuildHouse()
    {
        houses++;
        Debug.Log("বাড়ি নির্মাণ হয়েছে");
    }
}