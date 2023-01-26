using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Domain
{
    private ViewModel MyVM { get; set; }

    public Domain(ViewModel vm)
    {
        MyVM = vm;
    }

    //キューブの位置
    private  Vector3 CubePosition { get; set; }= Vector3.zero;

    public  void OnCubeMove()
    {
        CubePosition += new Vector3(0f, 0f, 1f);

        MyVM.CubePosition.Value = CubePosition;
    }
}
