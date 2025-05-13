using Xunit;

namespace CSharpDrills;

public class StackDrillTests
{
     [Fact]
     public void TestCheckExpressionBrackets()
     {
          string expressionInputOne = "(a + (b) + ((c + d)))";
          string expressionInputTwo = "(a + b)";
          string expressionInputThree = "((a+b))";
          

          Assert.True(StackDrills.CheckDuplicateBrackets(expressionInputOne));
          Assert.False(StackDrills.CheckDuplicateBrackets(expressionInputTwo));
          Assert.True(StackDrills.CheckDuplicateBrackets(expressionInputThree));
     }
}