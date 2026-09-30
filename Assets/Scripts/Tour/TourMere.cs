using UnityEngine;

public class TourMere : MonoBehaviour
{
    [SerializeField] private float Cadence;
    [SerializeField] private int DegatsTir;
    private Ennemi Cible;
    [SerializeField] private int Prix;
    [SerializeField] private float Portee;
    private RaycastHit Hit;

    private void Update()
    {
        Physics.SphereCast(transform.position, Portee, transform.forward, out Hit, Portee);
    }

    private Ennemi Ciblage(float Portee)
    {
        return null;
    }

    private void Tir(int DegatsTir, float Cadence, Ennemi Cible)
    {

    }
}
