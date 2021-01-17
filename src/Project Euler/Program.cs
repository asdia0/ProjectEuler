namespace ProjectEuler
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Reflection;
    using Newtonsoft.Json;

    /// <summary>
    /// Main class of the project.
    /// </summary>
    public partial class Program
    {
        /// <summary>
        /// Entry point for the project.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Which problem would you like to check?");
            int problem = int.Parse(Console.ReadLine());
            Type type = typeof(Solutions);
            MethodInfo method = type.GetMethod($"Problem{problem}");
            Solutions c = new Solutions();
            var result = method.Invoke(c, null);
            Console.WriteLine($"\nProblem {problem}: {JsonConvert.SerializeObject(result)}\n\n");
        }
    }
}
