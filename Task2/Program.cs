using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Component body = new HtmlTag("body", null);

            Component divTag = new HtmlTag("div", null);
            Component pTag = new HtmlTag("p", "Строка1");
            divTag.AddComponent(pTag);

            Console.WriteLine();

            Component SecondDivTag = new HtmlTag("div", null);
            Component SecondPTag = new HtmlTag("p", "Строка2");
            SecondDivTag.AddComponent(SecondPTag);

            body.AddComponent(divTag);
            body.AddComponent(SecondDivTag);
            body.Render();
            Console.ReadLine();
        }
    }
}
