using UnityEngine;
using System.Collections;

public class MouseController : MonoBehaviour  {
  public float jumpForce = 40.0f;
  private Rigidbody2D rigidBody;
  public float runningSpeed = 25f;
  public Animator animator;
  public int countJUmps = 0;
  //Esto hay que modificarlo en el Unity
  public LayerMask groundLayerMask;

  void Awake(){
    rigidBody = GetComponent<Rigidbody2D>();
  }
	void Start (){
	}

//Carga por cada Frame
	void Update () {
    if(Input.GetMouseButtonDown(0)){
      Jump();
    }
  }
//Tal como esta programado mantiene siempre la misma velocidad y nunca para
  void FixedUpdate(){
    if(rigidBody.velocity.x < runningSpeed){
      rigidBody.velocity = new Vector2(runningSpeed, rigidBody.velocity.y);
    }
  }

//Clase para Saltar
  void Jump(){
    //Compruebo que este en el suelo y salta
    if(IsOnTheFloor()){
      rigidBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
      }

//Si esta o no en el suelo para que solo salte una vez
      bool IsOnTheFloor(){
        //si esta en el suelo
        if (Physics2D.Raycast(this.transform.position, Vector2.down, 1.0f, groundLayerMask.value)){
          countJUmps =  countJUmps + 1;
          return true;

        }
        //Compruebo los clicks del salto
        if(countJUmps == 2 || countJUmps >2){
          //no esta
          countJUmps = 0;
          return false;
        }else{
          return false;
        }
      }

  }
