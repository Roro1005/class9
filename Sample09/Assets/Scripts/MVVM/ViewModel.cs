using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class ViewModel
{
    public ReactiveProperty<Vector3> CubePosition=new ReactiveProperty<Vector3>();
}
