# UniEnumExtensionMethods

列挙型の拡張メソッド

## 使用例

```cs
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private enum Hoge
    {
        HOGE_1,
        HOGE_2,
        HOGE_3,
    }

    private void Awake()
    {
        var hoge = Hoge.HOGE_1;

        hoge = hoge.Next();
        Debug.Log( hoge ); // HOGE_2
        hoge = hoge.Next();
        Debug.Log( hoge ); // HOGE_3
        hoge = hoge.Next();
        Debug.Log( hoge ); // HOGE_3

        hoge = Hoge.HOGE_1;

        hoge = hoge.NextLoop();
        Debug.Log( hoge ); // HOGE_2
        hoge = hoge.NextLoop();
        Debug.Log( hoge ); // HOGE_3
        hoge = hoge.NextLoop();
        Debug.Log( hoge ); // HOGE_1

        hoge = Hoge.HOGE_3;

        hoge = hoge.Prev();
        Debug.Log( hoge ); // HOGE_2
        hoge = hoge.Prev();
        Debug.Log( hoge ); // HOGE_1
        hoge = hoge.Prev();
        Debug.Log( hoge ); // HOGE_1

        hoge = Hoge.HOGE_3;

        hoge = hoge.PrevLoop();
        Debug.Log( hoge ); // HOGE_2
        hoge = hoge.PrevLoop();
        Debug.Log( hoge ); // HOGE_1
        hoge = hoge.PrevLoop();
        Debug.Log( hoge ); // HOGE_3
    }
}
```
