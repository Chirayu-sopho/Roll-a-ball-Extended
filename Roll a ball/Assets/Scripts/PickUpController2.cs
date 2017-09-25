using UnityEngine;
using System.Collections;

public class PickUpController2 : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);

      /*  if (attach == 1)
        {
            transform.Translate(moveHorizontal, 0.0f, moveVertical);
        }
      */
    }
}
