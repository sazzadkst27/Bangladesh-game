using UnityEngine;

public class ArmySystem : MonoBehaviour
{
    public int armyCount = 0;

    public void TrainArmy(int number)
    {
        armyCount += number;
        Debug.Log(number + " সেনা তৈরি হয়েছে");
    }
}