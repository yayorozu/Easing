# Easing

Easing は、Unity プロジェクト向けにスムーズな遷移やアニメーションのためのイージング関数を提供するライブラリです。  
このライブラリでは、Linear や Quadratic、Cubic、Quartic、Quintic、Sine、Exponential、Circular、Back、Bounce、Elastic など、さまざまなイージング関数が実装されています。

<img src="https://github.com/yayorozu/ImageUploader/blob/master/Easing/Top.png" width="700">

# 使い方

各イージング関数は、`Ease` クラスの静的メソッドとして利用できます。  
例えば、0 から 1 への補間値を計算するには、以下のように使用します。

```csharp
var calc = Ease.Eval(EaseType.Linear, t, 0, 1);
```
