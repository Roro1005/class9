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

    [SerializeField]
    private Transform CubeTransform;
    // Start is called before the first frame update
    private void Start()
    {
        CubeMoveButton.OnClickAsObservable().Subscribe(_ =>
        {

        }).AddTo(Disposables);
    }

    private void OnDestroy()
    {
        Disposables.Dispose();
    }
}
