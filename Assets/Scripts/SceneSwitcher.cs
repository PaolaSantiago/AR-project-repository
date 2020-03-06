using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Start is called before the first frame update
    public void AR_Test()
    {
        SceneManager.LoadScene("AR_Test");
    }
    public void EULA()
    {
        SceneManager.LoadScene("EULA");
    }
}
