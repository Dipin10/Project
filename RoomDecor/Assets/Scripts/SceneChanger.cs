using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeToLoginScene()
    {
        SceneManager.LoadScene(1);
    }
    public void ChangeToRegisterScene()
    {
        SceneManager.LoadScene(2);
    }
    public void ChangeScenesignOut()
    {
        PlayerPrefs.SetString("Name","");
        SceneManager.LoadScene(1);
        // Login.isLoggedIn = false;
       
    }
    public void backButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1 );
    }
    
}