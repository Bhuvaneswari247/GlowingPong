using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMusic : MonoBehaviour
{

    private static BackGroundMusic backgroundMusic;

    private void Awake()
    {
        if(backgroundMusic == null )
        {
            backgroundMusic = this;
            DontDestroyOnLoad( backgroundMusic );
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
