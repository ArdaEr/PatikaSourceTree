using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsMovement : MonoBehaviour
{
    Rigidbody _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        StartCoroutine(GetKeyTest());
    }

    // Update is called once per frame
    void Update()
    {   
    if(!_rigidbody)
        return;

        if(Input.GetKey(KeyCode.UpArrow))
        {
            _rigidbody.AddForce(new Vector3(0, 0, -10f), ForceMode.Force); // Mass'e bağlı Accelaration da ise mass ile alakasız. Sadece ivme veriyorsun.
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            _rigidbody.AddForce(new Vector3(0, 0, 10f), ForceMode.Force); // Impulse ise patlama gücü ekliyor. VelocityChange massden bağımsız aynısın yapar.
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            _rigidbody.AddForce(new Vector3(10, 0, 0f), ForceMode.Force);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            _rigidbody.AddForce(new Vector3(-10, 0, 0), ForceMode.Force);
        }
        
    }

    IEnumerator GetKeyTest()
    {
        while(true)
        {
            yield return new WaitForEndOfFrame();
            if(Input.GetKey(KeyCode.UpArrow))
                {Debug.Log("Get Key");}
            if(Input.GetKeyDown(KeyCode.UpArrow))
                {Debug.Log("Get Key Down");}
            if(Input.GetKeyUp(KeyCode.UpArrow))
                {Debug.Log("Get Key Up");}
        }
    }
}
