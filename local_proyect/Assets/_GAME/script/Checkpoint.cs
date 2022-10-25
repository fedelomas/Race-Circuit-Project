using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] private float cantidadPuntos;

    public GameObject Check;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ControladorPuntos.Instance.SumarPuntos(cantidadPuntos);
        }
    }

}
