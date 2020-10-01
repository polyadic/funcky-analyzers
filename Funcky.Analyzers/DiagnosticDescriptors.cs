using Microsoft.CodeAnalysis;

namespace Funcky.Analyzers
{
    internal static class DiagnosticDescriptors
    {
        public static readonly DiagnosticDescriptor UseFunctionalIdentity = new DiagnosticDescriptor(
            id: "ƛ0001",
            title: "Use Functional.Identity",
            messageFormat: "Use Functional.Identity instead of writing your own identity function",
            category: "Style",
            DiagnosticSeverity.Warning,
            isEnabledByDefault: true);

        public static readonly DiagnosticDescriptor UseFunctionalTrue = new DiagnosticDescriptor(
            "ƛ0002",
            "Use Functional.True",
            "Use Functional.True instead of writing your own always-true predicate",
            "Style",
            DiagnosticSeverity.Warning,
            isEnabledByDefault: true);

        public static readonly DiagnosticDescriptor UseFunctionalFalse = new DiagnosticDescriptor(
            "ƛ0003",
            "Use Functional.False",
            "Use Functional.False instead of writing your own always-false predicate",
            "Style",
            DiagnosticSeverity.Warning,
            isEnabledByDefault: true);
    }
}
