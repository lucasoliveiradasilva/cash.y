using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraficoDeAtivos : MonoBehaviour
{

    private bool graficoAtivo;

    public GameObject graficos;
    
    public void ExibirGrafico()
    {
        if (graficoAtivo == false)
        {
            graficos.SetActive(true);
            graficoAtivo = true;
        }
        else if (graficoAtivo == true)
        {
            graficos.SetActive(false);
            graficoAtivo = false;
        }
    }

}
