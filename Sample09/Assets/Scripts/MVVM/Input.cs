using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class Input : MonoBehaviour
{
    [SerializeField]
    private Button CubeMoveButton;

    private CompositeDisposable Disposables=new CompositeDisposable();

    public Domain MyDomain { get; set; }

    public void Inject(Domain domain)
    {
        MyDomain = domain;
    }
    private void Start()
    {
        CubeMoveButton.OnClickAsObservable().Subscribe(_ =>
        {
            MyDomain.OnCubeMove();
        }).AddTo(Disposables);
    }

    private void OnDestroy()
    {
        Disposables.Dispose();
    }
}
