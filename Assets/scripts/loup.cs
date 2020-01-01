using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class loup : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    bool isMagnet1 = true;
    bool isMagnet2 = false;
    int walkLayerIndex, dropLayerIndex, baseLayerIndex, detachLayerIndex;
    float currWalkLayerWeight, currDropLayerWeight, currUnmagnetLayerWeight;
    float speed;
    Vector3 unMagnetRotation = new Vector3(0, 0, 0);
    Rigidbody rb;
    float deltaX;
    public camover cam;
    public PathCreator path;
    enum loupState {LEAN, DETACH, DROP, WALK }
    loupState state = loupState.LEAN;


    void Start()
    {
        anim = this.GetComponent<Animator>();
        currWalkLayerWeight = currDropLayerWeight = currDropLayerWeight = 0;
        walkLayerIndex = anim.GetLayerIndex("Unmagnet");
        dropLayerIndex = anim.GetLayerIndex("Walk");
        baseLayerIndex = anim.GetLayerIndex("Base Layer");
        detachLayerIndex = anim.GetLayerIndex("Unmagnet");
        speed = 1f;
        rb = this.GetComponent<Rigidbody>();
        deltaX = this.transform.position.x;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("notPressing", false);
            if (state == loupState.LEAN || state == loupState.DETACH)
            {
                state = loupState.DETACH;
                
                anim.SetBool("detaching", true);
                anim.SetBool("isDroping", true);
                anim.SetBool("pressing",true);

            }
        }
        //else if (anim.GetBool("pressing"))  { anim.SetBool("notPressing", false); }
         
        else
        {
            anim.SetBool("notPressing", true);
            anim.SetBool("detaching", false);
            anim.SetBool("isDroping", false);
            state = loupState.LEAN;
        }


        /*if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (state == loupState.LEAN || state == loupState.DETACH)
            {
                state = loupState.DETACH;
                currDropLayerWeight = anim.GetLayerWeight(detachLayerIndex);
                isMagnet1 = false;
                anim.SetLayerWeight(detachLayerIndex, currDropLayerWeight + Time.deltaTime * 2f * speed);
                if (anim.GetLayerWeight(detachLayerIndex) >= 1)
                {
                    anim.SetBool("is_detachMagnet", true);
                    //anim.SetLayerWeight(detachLayerIndex, 0);
                    currDropLayerWeight = 0;
                    state = loupState.DROP;
                }
            }
            else if(state == loupState.DROP)
            {

            }
        }
        if (state == loupState.DETACH)
        {
           
        }*/

        /*
        if (Input.GetKey(KeyCode.LeftArrow) ) 

        {
            currWalkLayerWeight = anim.GetLayerWeight(walkLayerIndex);
            isMagnet1 = false;
            
            anim.SetLayerWeight(walkLayerIndex, currWalkLayerWeight + Time.deltaTime * 2*speed);
            if (!(unMagnetRotation.y >= 180))
            {
                transform.Rotate(new Vector3(0, 1, 0) * speed * 4);
                unMagnetRotation += new Vector3(0, 1, 0) * speed * 4;
                

            }
            else
            {
                rb.velocity = rb.velocity + new Vector3(0.02f, 0, 0);
                deltaX = deltaX - this.transform.position.x;
                Debug.Log(deltaX);
              //  cam.Move(-deltaX);
            }
            
        }
        else
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
        */
    }
}
