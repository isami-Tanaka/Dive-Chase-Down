using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKeyDown(KeyCode.R)||Input.GetButtonDown("Fire1"))
        {
            SceneManager.LoadScene("TitleStage 1", LoadSceneMode.Single);
        }
    }
}
