using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AnimationCurveScript : MonoBehaviour
{
    [SerializeField] AnimationCurve _animationCurve;
    [SerializeField] float animTime;
    //GameObject _testObject;
    //public event Action<GameObject> OnAnimationFinished; Variable çekmek için bunu kullanabilirsin.
    private void Start() 
    {
        StartCoroutine(AnimationCurveDemo());
        MathfTest();
    }

    IEnumerator AnimationCurveDemo()
    {
        float currentTime = 0f;
        _animationCurve = new AnimationCurve(new Keyframe(0f, transform.position.x), new Keyframe(0.5f, transform.position.x + 10), new Keyframe(1f, transform.position.x + 15));

        _animationCurve.SmoothTangents(0, 0.25f);
        _animationCurve.SmoothTangents(1, 1f);
        _animationCurve.SmoothTangents(2, 0.25f);
        while(currentTime < animTime)
        {
            transform.position = new Vector2(_animationCurve.Evaluate(currentTime / animTime), transform.position.y);
            currentTime += Time.deltaTime;
            yield return new WaitForEndOfFrame(); //Her frame sonu yapacak bunu
        } 

        //OnAnimationFinished.Invoke(_testObject);
    }
    private void MathfTest()
        {
        Mathf.Abs(50);
        Mathf.Abs(-50); //mutlak değer
        
        float a = 1.1f;
        float b = 1.200000000000000001f;

        if(Mathf.Approximately(a,b)){};

        Debug.Log("Ceil : " + Mathf.Ceil(b)); // tavana yuvarlama
        //Debug.Log("Ceil : " + Mathf.CeilToInt(b)); // int tavana yuvarlama
        Debug.Log("Floor : " + Mathf.Floor(b)); // tabana yuvarlama
        Debug.Log("Round : " + Mathf.Round(b)); // en yakına yuvarlama
        List<string> list = new List<string>() {"Cengizhan", "Büşra", "Arda", "Ali", "Berk"};
        int listElement = Mathf.Clamp(6, 0, list.Count - 1); //6.elemanı istiyor ama 6 eleman yok 0 ile 4 arasında 4.yü alıp veriyor oda Berk
        Debug.Log("List element: " + list[listElement]);
        }

}
