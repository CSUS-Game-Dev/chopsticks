using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{

    public int point = 1;
    public GameObject handUsed;
    public GameObject lPointer;
    public GameObject lMiddile;
    public GameObject lRing;
    public GameObject lPinkie;
    public GameObject lThumb;

    // Use this for initialization
    void Start()
    {
        point = 1;
        lMiddile.SetActive(false);
        lRing.SetActive(false);
        lPinkie.SetActive(false);
        lThumb.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.touchCount > 0)
        for (var i = 0; i < Input.touchCount; i++)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                {
                    print("Touched");

                    RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint((Input.GetTouch(0).position)), Vector2.zero);
                    print(Camera.main.ScreenToWorldPoint((Input.GetTouch(0).position)));


                    if (hit.collider != null && hit.collider.gameObject == handUsed)
                    {
                        point++;
                        print("Clicked on " + gameObject);
                    }
                    if (point == 1)
                    {
                        lPointer.SetActive(true);
                        lMiddile.SetActive(false);
                        lRing.SetActive(false);
                        lPinkie.SetActive(false);
                        lThumb.SetActive(false);
                    }
                    else if (point == 2)
                    {
                        lPointer.SetActive(true);
                        lMiddile.SetActive(true);
                        lRing.SetActive(false);
                        lPinkie.SetActive(false);
                        lThumb.SetActive(false);
                    }
                    else if (point == 3)
                    {
                        lPointer.SetActive(true);
                        lMiddile.SetActive(true);
                        lRing.SetActive(true);
                        lPinkie.SetActive(false);
                        lThumb.SetActive(false);
                    }
                    else if (point == 4)
                    {
                        lPointer.SetActive(true);
                        lMiddile.SetActive(true);
                        lRing.SetActive(true);
                        lPinkie.SetActive(true);
                        lThumb.SetActive(false);
                    }
                    else if (point == 5)
                    {
                        lPointer.SetActive(true);
                        lMiddile.SetActive(true);
                        lRing.SetActive(true);
                        lPinkie.SetActive(true);
                        lThumb.SetActive(true);
                    }
                    else if (point == 6)
                    {
                        point = 1;
                        lPointer.SetActive(true);
                        lMiddile.SetActive(false);
                        lRing.SetActive(false);
                        lPinkie.SetActive(false);
                        lThumb.SetActive(false);
                    }
                }

            }
        }
    }
}
