using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassA : InterfaceA
{
    public ClassB BReference { get; private set; }

    public ClassA()
    {
        BReference = new ClassB(this);
    }

    public int GetSomething()
    {
        return 1;
    }

    public void DoB()
    {
        BReference.Do();
    }
}
