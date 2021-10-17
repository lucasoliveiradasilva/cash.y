using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GeradorDeMoedas : MonoBehaviour
{

    public GameObject moeda;

    public TextMeshPro contadorMoedas;

    private bool rendaAtiva;

    private int pontos;

    void Start()
    {
        rendaAtiva = true;
        StartCoroutine(GerarMoedas());
        contadorMoedas.text = "$" + pontos;
    }
    
    IEnumerator GerarMoedas()
    {
        while (rendaAtiva == true)
        {
            yield return new WaitForSeconds(3f);
            Instantiate(moeda);
        }      

    }
    public void AtualizaPontos(int pontosAdd)
    {
        pontos = pontos + pontosAdd;
        contadorMoedas.text = "$" + pontos;
    }
}
