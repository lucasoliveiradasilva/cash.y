using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciadorDeBotões : MonoBehaviour
{
    public string nomeCena;
    
    public void Jogar()
    {
        //Troca para uma outra cena
        SceneManager.LoadScene(nomeCena);
    }
    public void Sair()
    {
        
        Application.Quit();
    }
 
}
