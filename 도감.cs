using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class 도감 : MonoBehaviour
{
    // Start is called before the first frame update
    public void SceneChanage()
    {
        SceneManager.LoadScene("book");
    }

}
