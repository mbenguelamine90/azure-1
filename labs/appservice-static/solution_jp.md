# ラボの解決策

PortalでNode.jsのApp Serviceを開きます。

左メニューから _認証_ を選択し、_ID プロバイダーの追加_ ボタンをクリックします：

- ID プロバイダーとして _Microsoft_ を選択
- サポートされるアカウントタイプで _Any Azure AD directory & personal Microsoft accounts_ を選択
- すべてのオプションをデフォルト値のままに

_追加_ をクリックし、プライベートブラウザウィンドウでNodeアプリのURLを開きます。

> 認証の設定に数分かかる場合があります。ログインページが表示されない場合は、少し待ってからもう一度試してみてください。

Microsoftのログインページが表示され、Azureアカウントでログインできます。アプリがアカウントの詳細を読むことを確認するよう求められます。ここではコードに変更はありません。認証をアプリに追加しただけです。

ログインした後、サイトの /user にアクセスすると、IdPとしてAzureが表示されます (_aad_ = Azure Active Directory) およびあなたのAzureアカウントのメールアドレスが表示されます。
