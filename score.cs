using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        playerController component = other.gameObject.GetComponent<playerController>();
        if(component != null)
        {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
}
