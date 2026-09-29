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
            Debug.Log("Fin de la partie");
            Application.Quit();
        }
    }
}
