using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InpManager : MonoBehaviour
{

    

    [SerializeField]
    private Player playerObj;
    private Vector3 movementVector = new Vector3();

    #region Singletone
    private static InpManager _instance;

    public static InpManager Instance{

        get
        {

            return _instance;

        }

    }
    #endregion

    private void Awake() {
        _instance = this;
    }

    private void Update() {
        if(playerObj){
            MoveInput();
        }

    }

    public void SetPlayer(Player pl){

        playerObj = pl;

    }


    private void MoveInput (){
        movementVector.x = Input.GetAxis("Horizontal");
        movementVector.z = Input.GetAxis("Vertical");

        playerObj.CmdMovePlayer(movementVector);  
    }


}
