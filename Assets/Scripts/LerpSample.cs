using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpSample : MonoBehaviour
{
    Vector3 startingPoz;
    [SerializeField] Transform _targetObject;
    [SerializeField] float speedCoof;
    float startTime = 0f;
    float journeyLength = 0f;
    // Start is called before the first frame update
    void Start()
    {
        startingPoz = transform.position;
        journeyLength = Vector3.Distance(startingPoz, _targetObject.position);
        //GetComponent<AnimationCurveScript>().OnAnimationFinished += TriggerParticle; AnimationCurve Scriptinden örnek olarak çektiğimiz kısım. Bir event tamamlandığında triggerparticle çalıştırmaya yarıyor.
    }

    // Update is called once per frame
    void Update()
    {
        float distanceCovered = (Time.time - startTime) * speedCoof;
        float journeyFraction = distanceCovered / journeyLength;

        transform.position = Vector3.Lerp(startingPoz, _targetObject.position, journeyFraction);
        //transform.position = Vector3.Slerp(startingPoz, _targetObject.position, journeyFraction); //Slerp eğrimli ilerliyor
        //transform.RotateAround(_targetObject.position, Vector3.up, speedCoof * Time.deltaTime); //Objeyi izleyerek etrafında dönüyor, aldığı parametleri incele
        //Mathf.Lerp(0, 1f, 0.2f);
    }
    // private void TriggerParticle(GameObject gameObject)
    // {

    // }
}
