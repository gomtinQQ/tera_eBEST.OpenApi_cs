# eBEST.OpenApi C# Wrapper

eBEST.OpenApi C# Wrapper�� eBEST OpenAPI�� C#���� ����ϱ� ���� Wrapper�Դϴ�.

## ����ȯ��
NET8.0, Visual Studio 2022

## ����

### 1. eBEST.OpenApi nuget ��Ű���� �����մϴ�.
### 2. eBEST.OpenApi.OpenApi Ŭ������ �����մϴ�.
### 3. �α����� TR�� ��û�մϴ�.

	* �Ϻ�TR���� �����Ͱ� �Ŵ���� ���������� ���̳��� ��찡 �ֽ��ϴ�. Ȯ�� �� ����Ͻñ� �ٶ��ϴ�.

```csharp
	_client = new eBEST.OpenApi.EBestOpenApi();
	_client.OnConnectEvent += (sender, e) =>
	{
		if (e.Ok)
		{
			// �α��� ����
		}
		else
		{
			// �α��� ����
		}
	};

	// �α���
	_client.ConnectAsync(AccKey, AccSecretKey);

	// TR ��û
	t1102 �ֽ����簡 = new()
	{
		t1102InBlock = new(code),
	};
	_client.GetTRData(�ֽ����簡).Wait();
	if (�ֽ����簡.t1102OutBlock != null)
	{
		ResultText = $"\r\n{�ֽ����簡.t1102OutBlock}";
	}


![](./Samples/img/run-001.png)

![](./Samples/img/run-002.png)

![](./Samples/img/run-003.png)

![](./Samples/img/run-004.png)
