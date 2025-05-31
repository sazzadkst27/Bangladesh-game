using UnityEngine;

public class ElectionSystem : MonoBehaviour
{
    public string president = "None";

    public void HoldElection(string winner)
    {
        president = winner;
        Debug.Log("নতুন প্রেসিডেন্ট নির্বাচিত: " + winner);
    }
}