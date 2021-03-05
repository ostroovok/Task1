using System;

namespace Task2
{
    public abstract class Component : IComponent
    {
        protected string TagName { get; }
        public string TextString { get; set; }
        public Component(string tagName, object textString)
        {
            TagName = tagName;
            TextString = textString?.ToString() ?? "";
        }
        public virtual void AddComponent(Component c) { }
        public virtual void RemoveComponent(Component c) { }
        public virtual void Render()
        {
            Console.WriteLine(TagName + TextString);
        }
    }
}
