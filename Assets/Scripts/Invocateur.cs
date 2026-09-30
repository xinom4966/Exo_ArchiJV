using UnityEngine;
using System.Collections.Generic;

public class Invocateur : MonoBehaviour
{
    [SerializeField] private float VitesseGeneration;
    private Transform Position;
    [SerializeField] private List<EnnemiMere> MonstresInvocables = new List<EnnemiMere>();
    private int NombreMonstres = 0;
    private float Chronometre;

    private void Start()
    {
        Position = transform;
    }

    private void Update()
    {
        Chronometre += Time.deltaTime;
        if (Chronometre > 1 / VitesseGeneration)
        {
            InvocationMonstre(MonstresInvocables, Position, VitesseGeneration);
            NombreMonstres++;
            Chronometre = 0;
        }
    }

    private void InvocationMonstre(List<EnnemiMere> MonstresInvocables, Transform Position, float VitesseGeneration)
    {
        EnnemiMere EnnemiAInvoquer = MonstresInvocables[Random.Range(0, MonstresInvocables.Count-1)];
        GameObject.Instantiate(EnnemiAInvoquer, Position.position, Quaternion.identity);
    }
}
