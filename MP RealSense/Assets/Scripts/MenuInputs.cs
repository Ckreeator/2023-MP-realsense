using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInputs : MonoBehaviour
{
    public void StartButtonPressed()
    {
        SceneManager.LoadScene("MainScene");
    }

}
