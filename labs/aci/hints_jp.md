# 実験ヒント

`az` コマンドを使用してACI上でWindowsコンテナを実行できますが、Docker CLIプラグインはLinuxコンテナのみをサポートしています。

コンテナイメージは特定のOSとCPUアーキテクチャ用にビルドされます。`courselabs/simple-web:6.0`はマルチアーキテクチャイメージなので、Linux上で実行するとLinuxバージョンが、Windows上で実行するとWindowsバージョンが取得されます。

Azure CLIを使用すると、コンテナを作成するときに使用するOSを設定でき、ACIが適切なイメージを選択します。または、Docker Hubをチェックして、特定のWindowsイメージタグとOSの設定を見つけることができます。

Azureは（まだ）ARMプロセッサをサポートしていませんので、Linux ARM64イメージを使用してコンテナを実行しようとすると、エラーが発生することを期待してください。

> もっと必要ですか？こちらが[解決策](solution_jp.md)です。
