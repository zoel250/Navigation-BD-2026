using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PPT : MonoBehaviour
{
    public string[] jugadas = {"roca","papel","tijera"};
    public int piedra;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            CheckResult("roca");
        } else if (Input.GetKeyDown(KeyCode.P))
        {
            CheckResult("papel");
        } else if(Input.GetKeyDown(KeyCode.T))
        {
            CheckResult("tijera");
        }
    }
    void CheckResult(string jugada)
    { 
        string jugadaContrincante = jugadas[Random.Range(0,3)];
    if (jugada == jugadaContrincante)
    {
        Debug.Log("Empate");
    }
    else if ((jugada == "roca" && jugadaContrincante == "tijeras") ||
            (jugada == "papel" && jugadaContrincante == "roca") ||
            (jugada == "tijeras" && jugadaContrincante == "papel"))
    {
        Debug.Log("Ganaste");
    }
    else if ((jugada == "roca" && jugadaContrincante == "papel") ||
            (jugada == "papel" && jugadaContrincante == "tijeras") ||
            (jugada == "tijeras" && jugadaContrincante == "roca"))
    {
        Debug.Log("Perdiste");
    }
    else
    {
        Debug.Log("Jugada invalida");
    }
  }
}
