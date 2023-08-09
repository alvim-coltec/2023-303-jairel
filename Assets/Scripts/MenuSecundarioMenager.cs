using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSecundarioMenager : MonoBehaviour
{

    [SerializeField] private AudioSource somAvancar;
    [SerializeField] private AudioSource somVoltar;

    public void Voltar()
    {
        somVoltar.Play();
        Invoke("CarregarCenaMenuPrincipal", somVoltar.clip.length);
        SceneManager.LoadScene(0);
    }

    public void VoltarInventario()
    {
        somVoltar.Play();
        Invoke("CarregarCenaInventario", somVoltar.clip.length);
    }

    public void AvancaFases()
    {
        somAvancar.Play();
        SceneManager.LoadScene(3);
        //Invoke("CarregarCenaFases", somAvancar.clip.length);
    }

    private void CarregarCenaMenuPrincipal()
    {
        SceneManager.LoadScene(0);
    }

    private void CarregarCenaInventario()
    {
        SceneManager.LoadScene(2);
    }

    private void CarregarCenaFases()
    {
        SceneManager.LoadScene(3);
    }
    
    public void FaseMula(){
        SceneManager.LoadScene(1);
        Jogador.instance.SetControlsEnabled(true);
        Time.timeScale = 1;
    }
}
