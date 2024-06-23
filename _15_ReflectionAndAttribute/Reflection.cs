using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _15_ReflectionAndAttribute
{
    public static class ReflectionClass
    {
        public static void Run()
        {
            // Assembly assembly = Assembly.GetExecutingAssembly();
            //
            // foreach (Type type in assembly.GetTypes())
            // {
            //     Console.WriteLine(type.Name);
            // }

            // string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            // string solutionDirectory = Directory.GetParent(baseDirectory).Parent.Parent.Parent.Parent.FullName;
            // string path = solutionDirectory + @"\_14_Predicate\bin\Debug\net6.0\_14_Predicate.dll";
            //
            // Assembly predicateAssembly = Assembly.LoadFrom(path);
            //
            // foreach (Type type in predicateAssembly.GetTypes())
            // {
            //     Console.WriteLine(type.Name);
            // }

            // Module[] modules = Assembly.GetExecutingAssembly().GetModules();
            // foreach (Module module in modules)
            // {
            //     Console.WriteLine(module.Name);
            // }
        }
    }
}
