using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsSample : MonoBehaviour
{
    [SerializeField] Transform _targetObject;
    [SerializeField] float speedCoof;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movementSpeed = speedCoof * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, _targetObject.position, movementSpeed);
    }
}
