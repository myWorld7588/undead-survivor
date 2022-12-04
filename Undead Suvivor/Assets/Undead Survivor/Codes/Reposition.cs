using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reposition : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.CompareTag("Area"))
            return;

        Vector3 playerPos = GameManager.instance.player.transform.position;
        Vector3 myPos = transform.position;
        float diffX = Mathf.Abs(playerPos.x - myPos.x);
        float diffY = Mathf.Abs(playerPos.y - myPos.y);


        Vector3 playerDir = GameManager.instance.player.inputVec;

        switch (transform.tag) {
            case "Ground":
                if (diffX > diffY)
                {
                    transform.Translate(Vector3.right * 40);
                }
                else if (diffX > diffY)
                {
                    transform.Translate(Vector3.up * 40);
                }
                break;
            case "Enemy":

                break;



        }



    }
}
