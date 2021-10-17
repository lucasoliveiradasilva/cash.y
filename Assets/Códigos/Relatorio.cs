using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relatorio : MonoBehaviour
{
    private bool relatorioAtivo;

    public GameObject relatorio;

    public void ExibirGrafico()
    {
        if (relatorioAtivo == false)
        {
            relatorio.SetActive(true);
            relatorioAtivo = true;
        }
        else if (relatorioAtivo == true)
        {
           relatorio.SetActive(false);
           relatorioAtivo = false;
        }
    }
}
