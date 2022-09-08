using System;
using System.IO;
using System.Diagnostics;

class launcher{
	public static void Main(){
		var wnd = new Process{StartInfo = new ProcessStartInfo{FileName = "cmd.exe", RedirectStandardInput = true, UseShellExecute = false}};
		wnd.Start();
		using(StreamWriter stdo = wnd.StandardInput) stdo.WriteLine("start \"\" \"%cd%/index.html\"");
		Console.Write("\n\nFTKLauncher, build10000\nPyXleb, 2022\n\nИсходники доступны по ссылке в readme!\n\nНажмите любую клавишу, чтобы закрыть окно...\n");
		Console.ReadKey();
	}
}