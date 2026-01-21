using System;
using System.Globalization;
using Antelcat.I18N.Avalonia;
using LangKeys = NotWorkingDemo.Resources.LangKeys;

internal sealed class Program
{
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void Main(string[] args)
    {
        LangKeys.LanguageProvider.Initialize();

        I18NExtension.Culture = new CultureInfo("zh-CN");
        Console.WriteLine(I18NExtension.Translate("accept"));
        I18NExtension.Culture = new CultureInfo("en-US");
        Console.WriteLine(I18NExtension.Translate("accept"));
    }
}