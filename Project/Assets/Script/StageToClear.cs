using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageToClear : MonoBehaviour
{
    private bool isToClear = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool IsToClear()
    {
        return isToClear;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.tag == PalyerTag)
        //{
        //    isToClear= true;
        //}
    }
}
