using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class View : MonoBehaviour
{
    [SerializeField]
    private Transform CubeTransform;

    private ViewModel MyVM { get; set; }

    private CompositeDisposable Disposables = new CompositeDisposable();

    public void Inject(ViewModel vm)
    {
        MyVM = vm;
        SubscribeVM();
    }

    private void Start()
    {
        
    }

    private void SubscribeVM()
    {
        MyVM.CubePosition.Subscribe(cubePosition =>
        {
            CubeTransform.position = cubePosition;
        });
    }

    private void OnDestroy()
    {
        Disposables.Dispose();
    }
}
