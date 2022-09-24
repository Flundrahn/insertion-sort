using FluentAssertions;

namespace InsertionSort.Tests;

public class UnitTests
{
    [Fact]
    public void DoInsertionSort_should_return_sorted_array()
    {
        // Arrange
        var testArray1 = new int[] { 4, 3, 2, 1 };
        var testArray2 = new int[] { 1, 1, 1, 2, 2 };
        var testArray3 = new int[] { 2, 1, 3, 1, 2 };

        // Act
        var sorted1 = Result.DoInsertionSort(testArray1);
        var sorted2 = Result.DoInsertionSort(testArray2);
        var sorted3 = Result.DoInsertionSort(testArray3);

        // Assert
        sorted1.Should().BeEquivalentTo(new int[] { 1, 2, 3, 4 }, options => options.WithStrictOrdering());
        sorted2.Should().BeEquivalentTo(new int[] { 1, 1, 1, 2, 2 }, options => options.WithStrictOrdering());
        sorted3.Should().BeEquivalentTo(new int[] { 1, 1, 2, 2, 3 }, options => options.WithStrictOrdering());
    }

    [Fact]
    public void DoFredSort_should_sort_array_of_two()
    {
        // Arrange
        var testArray = new int[] { 2, 1 };

        // Act
        var sorted = Result.DoFredSort(testArray);

        // Assert
        sorted.Should().BeEquivalentTo(new int[] { 1, 2 }, options => options.WithStrictOrdering());
    }

    [Fact]
    public void DoFredSort_should_sort_array_of_three()
    {
        // Arrange
        var testArray = new int[] { 3, 2, 1 };

        // Act
        var sorted = Result.DoFredSort(testArray);

        // Assert
        sorted.Should().BeEquivalentTo(new int[] { 1, 2, 3 }, options => options.WithStrictOrdering());
    }

    [Fact]
    public void DoFredSort_should_sort_array_of_four()
    {
        // Arrange
        var testArray = new int[] { 4, 3, 2, 1 };

        // Act
        var sorted = Result.DoFredSort(testArray);

        // Assert
        sorted.Should().BeEquivalentTo(new int[] { 1, 2, 3, 4 }, options => options.WithStrictOrdering());
    }

    [Fact]
    public void DoFredSort_should_handle_alrady_sorted()
    {
        // Arrange
        var testArray1 = new int[] { 1, 2, 3, 4 };
        var testArray2 = new int[] { 1, 2 };

        // Act
        var sorted1 = Result.DoFredSort(testArray1);
        var sorted2 = Result.DoFredSort(testArray2);

        // Assert
        sorted1.Should().BeEquivalentTo(new int[] { 1, 2, 3, 4 }, options => options.WithStrictOrdering());
        sorted2.Should().BeEquivalentTo(new int[] { 1, 2 }, options => options.WithStrictOrdering());
    }

    [Fact]
    public void DoFredSort_should_handle_multiple_same_values()
    {
        // Arrange
        var testArray1 = new int[] { 3, 2, 3, 4, 5 };

        // Act
        var sorted1 = Result.DoFredSort(testArray1);

        // Assert
        sorted1.Should().BeEquivalentTo(new int[] { 2, 3, 3, 4, 5 }, options => options.WithStrictOrdering());
    }
}