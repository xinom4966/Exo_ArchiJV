using UnityEngine;
using System.Collections.Generic;

public class Invocateur : MonoBehaviour
{
    private float VitesseGeneration;
    private Transform Position;
    private List<EnnemiMere> MonstresInvocables = new List<EnnemiMere>();
    private int NombreMonstres;
    private float Chronometre;

    private void Update()
    {
        Chronometre += Time.deltaTime;
        if (Chronometre > VitesseGeneration) { }
    }

    private void InvocationMonstre(List<EnnemiMere> MonstresInvocables, Transform Position, float VitesseGeneration)
    {

    }
}
