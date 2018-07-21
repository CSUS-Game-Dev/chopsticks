using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPoint : MonoBehaviour {

    public int point = 0;

    // Use this for initialization
    void Start() { 
       
    }
     

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
            print("Touched");
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint((Input.GetTouch(0).position)), Vector2.zero);

            if (hit.collider != null)
            {
                point++;
                print("Clicked on " + gameObject);
                //Destroy(hit.transform.gameObject);
            }
        }
    }
}
