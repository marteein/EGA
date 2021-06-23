using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    public bool isDragging;
    public Vector3 LastPosition;
    private Collider2D _collider;
    private DragController _dragController;

    private float _movementTime = 15f;
    private System.Nullable<Vector3> _movementDestination;

    void Start(){
        _collider = GetComponent<Collider2D>();
        _dragController = FindObjectOfType<DragController>();
    }

    void FixedUpdate(){
        if(_movementDestination.HasValue){
            if(isDragging){
                _movementDestination = null;
                return;
            }
            if(transform.position == _movementDestination){
                gameObject.layer = Layer.Default;
                _movementDestination = null;
            }
            else{
                transform.position = Vector3.Lerp(transform.position, _movementDestination.Value, _movementTime*Time.fixedDeltaTime);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        Debug.Log("Hit");
        Draggable collidedDraggable = other.GetComponent<Draggable>();
        if(collidedDraggable != null && _dragController.LastDragged.gameObject == gameObject){
            ColliderDistance2D colliderDistance2D = other.Distance(_collider);
            Vector3 diff = new Vector3(colliderDistance2D.normal.x, colliderDistance2D.normal.y)* colliderDistance2D.distance;
            transform.position -= diff;
        }

        if(other.CompareTag("DropValid")){
            _movementDestination = new Vector2(other.transform.position.x, other.transform.position.y+1.5f);
            
        }
        else if(other.CompareTag("InvalidDrop")){
            _movementDestination = LastPosition;
        }
    }
}
