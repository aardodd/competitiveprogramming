namespace CompetitiveProgramming;

public class BestTimeToBuyAndSellStockTests
{
    private static int MaximumProfit(int[] prices)
    {
        var maxProfit = 0;
        var minPrice = prices[0];

        foreach (var currentPrice in prices)
        {
            minPrice = Math.Min(currentPrice, minPrice);
            maxProfit = Math.Max(currentPrice - minPrice, maxProfit);
        }

        return maxProfit;
    }

    [Theory]
    [InlineData(new[] { 0 }, 0)]
    [InlineData(new[] { 0, 0 }, 0)]
    [InlineData(new[] { 0, 1 }, 1)]
    [InlineData(new[] { 7, 1, 5, 3, 6, 4 }, 5)]
    [InlineData(new[] { 7, 6, 4, 3, 1 }, 0)]
    public void MaximumProfit_Tests(int[] prices, int expectedProfit)
    {
        var actualProfit = MaximumProfit(prices);
        actualProfit.Should().Be(expectedProfit);
    }
}