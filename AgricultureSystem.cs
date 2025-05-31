using UnityEngine;

public class AgricultureSystem : MonoBehaviour
{
    public int foodProduced = 0;

    public void CultivateLand()
    {
        foodProduced += 100;
        Debug.Log("১০০ ইউনিট খাদ্য উৎপাদন হয়েছে");
    }
}