using System;
using common;

namespace test2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Main 非同期処理を開始します...");

            Class1 common = new Class1();
            var res = await common.DoAsyncWork(); // MyClassの非同期メソッドを非同期的に呼び出す

            Console.WriteLine("Main 非同期処理が完了しました。");
        }
    }
}