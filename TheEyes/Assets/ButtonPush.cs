using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class ButtonPush : MonoBehaviour
{
    public GameObject Box;
    private int  k = 0;
    public int  p = 0;
    

    void OnMouseDown () {
        OnMouseUp();
            transform.position = new Vector2(transform.position.x, 0.3f);
            k++;
            NumberOfClicks();
    }
    void OnMouseUp()
    {
        transform.position = new Vector2(transform.position.x, -3.5f);
    }
    void NumberOfClicks(){
        if (k >= p)
            Destroy(Box);
    }
    
}
    
