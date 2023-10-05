using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variaveis : MonoBehaviour
{
    int numero1, numero2;

    // Start is called before the first frame update
    void Start()
    {
        numero1 = 10;
        numero2 = 5;
        Soma();
        Multiplicacao(numero1, numero2);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Soma()
    {
        int resultado;
        resultado = numero1 + numero2;
        Debug.Log(resultado);
    }

    void Multiplicacao(int valorA, int valorB)
    {
        int resultado;
        resultado = valorA * valorB;
        Debug.Log(resultado);
    }
}
