using UnityEngine;

public class Base : MonoBehaviour
{
    [SerializeField] private int PV;

    private void Mort(int PV)
    {
        Destroy(gameObject);
    }

    public void PrendreDegats(int Degats)
    {
        this.PV -= PV;
        if (this.PV <= 0)
        {
            this.PV = 0;
            Mort(PV);
        }
    }
}
