# シングルトンでどこからでも使えるタイマー
シングルトンでどこからでも取得できるタイマーです！  
Updateやコルーチンを使わずにその時々の時刻を取得し、その差を経過時間として計測しています。

### 使い方
以下のメソッドを実行して時間を測定します。

    StartTimer():測定開始

    StopTimer():一時停止

    ResetTimer():リセット

    GetTime():経過時間の取得
