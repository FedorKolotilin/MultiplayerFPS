using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror; 

public class Player : NetworkBehaviour
{

    [SyncVar]
    [SerializeField]
    private float speed; 

    private Rigidbody rb;

    private void Start() {

        rb = this.GetComponent<Rigidbody>();

        if(isClient && isLocalPlayer){

            SetInpManagerPlayer();

        }

        if(isServer){

            speed = 3;

        }

    }

    private void SetInpManagerPlayer(){
        InpManager.Instance.SetPlayer(this);
    }


    public void CmdMovePlayer(Vector3 movementVector){

        rb.AddForce(movementVector.normalized * speed);



    }


}
