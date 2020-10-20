using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
   public class Basla : MonoBehaviour
{

    public void digersahne()
    {
        SceneManager.LoadScene("oyun");

    }
   
    public void cıkıs()
    {
        Application.Quit();

    }
}
