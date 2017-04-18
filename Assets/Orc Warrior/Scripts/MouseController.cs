using UnityEngine;
using System.Collections;

public class MouseController : MonoBehaviour  {
  public float jumpForce = 15.0f;
  private Rigidbody2D rigidBody;
  public float runningSpeed =5f;
  public Animator animator;
  public LayerMask groundLayerMas;


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
      rigidBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
      }

      /*bool IsOnTheFloor(){
        if (Physics2D.Raycast(this.transform.position, Vector2)){

        }
      }*/

  }
