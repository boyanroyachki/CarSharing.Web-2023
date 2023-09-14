using OpenQA.Selenium;

namespace ToolsLibrary
{
    public static class HumanTypingSimulator
    {
        public static void SimulateText(string text, IWebElement element)
        {
            var symbols = text.ToCharArray();
            foreach (var symbol in symbols)
            {
                element.SendKeys(symbol.ToString());
                Thread.Sleep(100);
            }
        }
    }
}
