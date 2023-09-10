using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneSelect : MonoBehaviour
{
    public void selectScene()
    {
        switch(this.gameObject.name)
        {
            case "Button1":
                SceneManager.LoadScene("scene1");
                break;
            case "Button2":
                SceneManager.LoadScene("scene2");
                break;
            case "homeButton":
                SceneManager.LoadScene("mainscene");
                break;
            case "Button3":
                SceneManager.LoadScene("scene3");
                break;
            case "Button4":
                SceneManager.LoadScene("scene4");
                break;
        }
    }
}
