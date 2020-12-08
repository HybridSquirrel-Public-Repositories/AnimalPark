using System;
using System.Runtime.Loader;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System.Reflection;
using System.IO;
using System.Linq;

namespace AnimalCompiler
{

    public class AnimalParkCompiler
    {

        public void Starter(string code)
        {
            var tree = SyntaxFactory.ParseSyntaxTree(code);
            
            Console.WriteLine(tree);
            PrintDiagnostics(tree);

            var compilation = CSharpCompilation.Create("test.exe").WithOptions(
                new CSharpCompilationOptions(OutputKind.ConsoleApplication)).AddReferences(
                MetadataReference.CreateFromFile(typeof(object).GetTypeInfo().Assembly.Location)).
                AddSyntaxTrees(tree);

            var fileName = "test.exe";
            var path = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            compilation.Emit(path);

            var asm = AssemblyLoadContext.Default.LoadFromAssemblyPath(path);
            asm.GetType("MathFunctions.MathHelper").GetMethod("CalculaterCircleArea").
                Invoke(null, new object[] { });

            Console.ReadLine();


        }







        private static void PrintDiagnostics(SyntaxTree tree)
        {
            var diagnostics = tree.GetDiagnostics();
            if (diagnostics.Any())
            {
                foreach (var diagnostic in diagnostics)
                {
                    Console.WriteLine($"{diagnostic.GetMessage()} {diagnostic.Location.GetLineSpan()}");
                }
            }
        }
    }
}