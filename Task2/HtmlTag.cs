using System;
using System.Collections.Generic;

namespace Task2
{
    public class HtmlTag : Component
    {
        List<Component> _components = new List<Component>();
        public HtmlTag(string tagName, string textString) : base(tagName, textString)
        {
        }
        public override void AddComponent(Component c)
        {
            _components.Add(c);
        }
        public override void RemoveComponent(Component c)
        {
            _components.Remove(c);
        }
        public override void Render()
        {
            Console.Write($"<{TagName}>{TextString}");
            if (true)
            {
                foreach (var tag in _components)
                    tag?.Render();
            }
            Console.Write($"<{TagName}/>");
        }
    }
}
