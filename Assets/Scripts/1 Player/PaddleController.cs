using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PaddleController : MonoBehaviour
{
    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.touchCount > 0)
        {
            Touch touch0 = Input.GetTouch(0);
            

            movePaddle1(touch0);

        }
    }
    void movePaddle1(Touch touch)
    {
        Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

        touchPosition.x = -7.68f;
        touchPosition.z = 0f;

        transform.position = touchPosition;
    }
}

