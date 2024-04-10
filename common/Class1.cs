namespace common;
public class Class1
{
    public async Task<string> DoAsyncWork()
    {
        Console.WriteLine("非同期処理を開始します...");
        await Task.Delay(2000); // 2秒待機する非同期処理の例
        Console.WriteLine("非同期処理が完了しました。");
        return "aaa";

    }
}

