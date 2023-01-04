// using System.Collections.Immutable;
// using Microsoft.CodeAnalysis;
// using Microsoft.CodeAnalysis.Diagnostics;
//
// namespace HypeProxy.Entities;
//
// [DiagnosticAnalyzer(LanguageNames.CSharp)]
// public class BaseEntityAnalyzer : DiagnosticAnalyzer
// {
//     public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; }
//     
//     private static readonly DiagnosticDescriptor UnsupportedTypeRule = new(
//         id: "HYPE004",
//         title: "Unsupported type",
//         messageFormat: "{0} is unsupported type",
//         category: "Usage",
//         defaultSeverity: DiagnosticSeverity.Warning,
//         isEnabledByDefault: true,
//         description: "Unsupported type.");   
//     
//     public override void Initialize(AnalysisContext context)
//     {
//         
//         context.RegisterSymbolAction(AnalyzeSymbol, SymbolKind.NamedType);
//     }
//
//     private static void AnalyzeSymbol(SymbolAnalysisContext context)
//     {
//         // var attributeSymbol = context.Compilation.GetTypeByMetadataName("Tapper.TranspilationSourceAttribute");
//
//         // var supportTypeSymbols = SupportTypes
//         //     .Select(x => context.Compilation.GetTypeByMetadataName(x.FullName)!)
//         //     .ToArray();
//
//         // if (attributeSymbol is null)
//         // {
//         //     return;
//         // }
//
//         if (context.Symbol is INamedTypeSymbol namedTypeSymbol)
//         {
//             Console.WriteLine("FUCK" + namedTypeSymbol);
//         }
//     }
// }