using System;
using Example;

namespace SwaggerCodeDefinitionPoc
{
    class Program
    {
        static void Main(string[] args)
        {
            var pet = new Pet { Name = "Teddy" };
            Console.WriteLine("Hello " + pet.ToJson());
        }
    }
}
