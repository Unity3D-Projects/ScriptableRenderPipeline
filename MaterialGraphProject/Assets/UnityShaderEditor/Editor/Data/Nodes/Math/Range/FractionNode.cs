using System.Reflection;

namespace UnityEngine.MaterialGraph
{
    [Title("Math/Range/Fraction")]
    public class FractionNode : CodeFunctionNode
    {
        public FractionNode()
        {
            name = "Fraction";
        }

        protected override MethodInfo GetFunctionToConvert()
        {
            return GetType().GetMethod("Unity_Fraction", BindingFlags.Static | BindingFlags.NonPublic);
        }

        static string Unity_Fraction(
            [Slot(0, Binding.None)] DynamicDimensionVector In,
            [Slot(1, Binding.None)] out DynamicDimensionVector Out)
        {
            return
                @"
{
    Out = frac(In);
}
";
        }
    }
}
