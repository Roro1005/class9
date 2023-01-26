using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPoint : MonoBehaviour
{
    [SerializeField]
    private Input MyInput;

    [SerializeField]
    private View MyView;

    private void Start()
    {
        ViewModel vm = new ViewModel();

        Domain domain= new Domain(vm);

        MyView.Inject(vm);
        MyInput.Inject(domain);



        BitCalculate.Test();
        
    }
}
