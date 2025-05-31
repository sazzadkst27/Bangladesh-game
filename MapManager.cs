using UnityEngine;

public class MapManager : MonoBehaviour
{
    public string[] divisions = { "ঢাকা", "চট্টগ্রাম", "রাজশাহী", "সিলেট", "বরিশাল", "খুলনা", "রংপুর", "ময়মনসিংহ" };

    void Start()
    {
        foreach (string division in divisions)
        {
            Debug.Log("বিভাগ: " + division);
        }
    }
}