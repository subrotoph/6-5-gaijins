using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseUp() {
      GetComponent<Renderer>().material.color=Color.blue;
      Application.LoadLevel(1);
    }
	
}
