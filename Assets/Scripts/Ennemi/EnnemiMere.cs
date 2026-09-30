using UnityEngine;

public class EnnemiMere : MonoBehaviour
{
    [SerializeField] private int PV;
    [SerializeField] private int Degats;
    [SerializeField] private float VitesseDeplacement;
    [SerializeField] private float VitesseAttaque;
    private bool ObjectifAtteint = false;
    private float Chronometre = 0;
    private Base Base;

    private void Start()
    {
        Base = FindAnyObjectByType<Base>();
    }

    private void Update()
    {
        //vérification de cohérence
        if (Base == null)
        {
            Destroy(gameObject);
            return;
        }
        if (!ObjectifAtteint)
        {
            Deplacement(VitesseDeplacement, Base);
            return;
        }
        Chronometre += Time.deltaTime;
        if (Chronometre > 1 / VitesseAttaque)
        {
            Attaque(VitesseAttaque, Degats, Base);
            Chronometre = 0;
        }
    }

    private void DegatsSubis(int DegatsTir, int PV)
    {

    }

    private void Mort(int PV)
    {

    }

    private void Deplacement(float VitesseDeplacement, Base Base)
    {
        transform.position = Vector3.MoveTowards(transform.position, Base.transform.position, VitesseDeplacement);
        ObjectifAtteint = transform.position == Base.transform.position;
    }

    private void Attaque(float VitesseAttaque, int Degats, Base Base)
    {
        Base.PrendreDegats(Degats);
    }
}
