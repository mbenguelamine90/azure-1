# ラボの解決策

AKS サブネットからのトラフィックのみが許可されるように、ストレージアカウントのファイアウォールルールを設定する必要があります。

## ポータルで

ストレージアカウントを開きます。_ネットワーキング_ で _無効_ に設定し、アプリが壊れていることを確認します。

次に、_選択した仮想ネットワークと IP アドレスから有効_ に切り替えてサブネットを追加します。アプリが再び動作していることを確認します。

> これらの変更が有効になるまでに1、2分かかりますが、期待される結果を確実に得る必要があります

## CLI で



```
# パブリックアクセスをオフにする：
az storage account update -g labs-aks-apps --default-action Deny -n <sa-name>
```


これでアプリが壊れるはずです。



```
# AKS サブネットを許可するルールを追加する：
az storage account network-rule add -g labs-aks-apps  --vnet appnet --subnet aks --account-name <sa-name>
```


これでアプリが再び動作します。