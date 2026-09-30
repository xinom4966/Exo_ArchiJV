using UnityEngine;

public class Base : MonoBehaviour
{
    [SerializeField] private int PV;

    private void Mort(int PV)
    {
        this.PV -= PV;
        if (this.PV <= 0)
        {
            this.PV = 0;
            Application.Quit();
        }
    }
}
