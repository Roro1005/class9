using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassB
{
    public InterfaceA AReference { get; private set; }

    public ClassB(InterfaceA a)
    {
        AReference = a;
    }

    public void Do()
    {
        Debug.Log("bbb");
    }

    public void DoA()
    {
        int result = AReference.GetSomething();
        Debug.Log(result);
    }
}
