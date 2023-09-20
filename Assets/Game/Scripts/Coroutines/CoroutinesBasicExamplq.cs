//using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class CoroutinesBasicExamplq : MonoBehaviour
//{
//    private bool _isPaused;
//    Coroutine ddd;

//    private void Start()
//    {
//        // _isPaused = true;
//        // StartCoroutine(SimpleCoroutine());
//        //StartCoroutine(CoroutineWithCondition());
//        //TestForEachWithEnumerator();
//    }

//    private void Update()
//    {
//        if (Input.GetKeyDown(KeyCode.W))
//        {
//            Debug.Log("Update: unpaused");
//            _isPaused = false;
//        }
//    }

//    private void TestForEachWithEnumerator()
//    {
//        foreach(var element in GetNumberEnumerator())
//        {
//            Debug.Log($"{GetType().Name}.TestForEachWithEnumerator: element = {element}");
//        }
//    }

//    private IEnumerable GetNumberEnumerator()
//    {
//        yield return "111";
//        yield return "afff";
//        yield return "`233";
//        yield return "5ykgkg";        
//        yield return "ruf47du";    
//    }

//    private IEnumerator CoroutineWithCondition()
//    {
//        Debug.Log($"{GetType().Name}.CoroutineWithCondition: Time.time = {Time.time} -1");

//        while (_isPaused)
//        {
//            yield return new WaitForSeconds(10f);
//        }

//        Debug.Log($"{GetType().Name}.CoroutineWithCondition: Time.time = {Time.time} -2");
//    }

//    private IEnumerator SimpleCoroutine()
//    {
//        Debug.Log($"{GetType().Name}.SimpleCoroutine: Time.time = {Time.time}");
//        yield return new WaitForSeconds( 1.0f );
//        Debug.Log($"{GetType().Name}.SimpleCoroutine: Time.time = {Time.time}");
//        Debug.Log($"{GetType().Name}.SimpleCoroutine: Time.time = {Time.time}");


//        yield return null;
//        Debug.Log($"{GetType().Name}.SimpleCoroutine: Time.time = {Time.time}");
//    }

//    private void TestForWithEndlessList()
//    {
//        foreach(var element in GetEndlessList())
//        {
//            Debug.Log($"{GetType().Name}.TestForEachWithEnumerator: element = {element}");
//        }
//    }

//    private IEnumerable<object> GetEndlessList()
//    {
//        throw new NotImplementedException();
//    }
    
//}
