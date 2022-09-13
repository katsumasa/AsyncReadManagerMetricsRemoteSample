# AsyncReadManagerMetricsRemoteSample
AsyncReadManagerMetricsRemote Sample

## 概要

AsyncReadManagerMetricsRemoteのサンプルプロジェクトです。
AssetBundleにパッキングされた複数のSpriteを順に切り替える際の非同期読み込みを計測します。

## インストール

```:console
git clone --recursive https://github.com/katsumasa/AsyncReadManagerMetricsRemoteSample.git
```

アップデート
```:console
git submodule update --init --recursive
```

### 使い方

1. `AssetBundle > Build`でAssetBundleのビルドを行います。
2. Androidプラットフォームのビルドを行います。(Development Buildが有効な状態でビルドを行ってください。)
3. ビルドされたバイナリをAndroid端末で実行します。(画面上のスプライトが連続して切り替わっていることが確認できます。)
4. Window > UTJ > AsyncRemoteMetricsRemoteSampleを実行します。
5. Startボタンを押すと計測が開始します。


