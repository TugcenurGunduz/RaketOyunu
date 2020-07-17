using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
   public void Load(int index) // public olması lazım başka türlü onclik'i ekleyemezsin.
    {
        SceneManager.LoadScene(index); // Sahneyi verdiğim zaman ilgili sahneyi yüklettim.
    }
    public void Quit()
    {
        Application.Quit();
    }
}
