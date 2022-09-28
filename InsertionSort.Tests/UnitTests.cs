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

    // [Fact]
    // public void insertionSort_should_sort_array_of_two()
    // {
    //     // Arrange
    //     var testArray = new List<int> { 2, 1 };

    //     // Act
    //     var (_, sorted) = Result.CountInsertionSort(testArray);

    //     // Assert
    //     sorted.Should().BeEquivalentTo(new List<int> { 1, 2 }, options => options.WithStrictOrdering());
    // }

    // [Fact]
    // public void insertionSort_should_sort_array_of_three()
    // {
    //     // Arrange
    //     var testArray = new List<int> { 3, 2, 1 };

    //     // Act
    //     var (_, sorted) = Result.CountInsertionSort(testArray);

    //     // Assert
    //     sorted.Should().BeEquivalentTo(new List<int> { 1, 2, 3 }, options => options.WithStrictOrdering());
    // }

    // [Fact]
    // public void insertionSort_should_sort_array_of_four()
    // {
    //     // Arrange
    //     var testArray = new List<int> { 4, 3, 2, 1 };

    //     // Act
    //     var (_, sorted) = Result.CountInsertionSort(testArray);

    //     // Assert
    //     sorted.Should().BeEquivalentTo(new List<int> { 1, 2, 3, 4 }, options => options.WithStrictOrdering());
    // }

    //     [Fact]
    //     public void insertionSort_should_handle_already_sorted()
    //     {
    //         // Arrange
    //         var testArray1 = new List<int> { 1, 2, 3, 4 };
    //         var testArray2 = new List<int> { 1, 2 };
    //         var testArray3 = new List<int> { 1, 1, 1, 2, 2 };

    //         // Act
    //         var (_, sorted1) = Result.CountInsertionSort(testArray1);
    //         var (_, sorted2) = Result.CountInsertionSort(testArray2);
    //         var (_, sorted3) = Result.CountInsertionSort(testArray3);

    //         // Assert
    //         sorted1.Should().BeEquivalentTo(testArray1, options => options.WithStrictOrdering());
    //         sorted2.Should().BeEquivalentTo(testArray2, options => options.WithStrictOrdering());
    //         sorted3.Should().BeEquivalentTo(testArray3, options => options.WithStrictOrdering());
    //     }

    //     [Fact]
    //     public void insertionSort_should_handle_multiple_same_values()
    //     {
    //         // Arrange
    //         var testArray1 = new List<int> { 3, 2, 3, 4, 5 };

    //         // Act
    //         var (_, sorted) = Result.CountInsertionSort(testArray1);

    //         // Assert
    //         sorted.Should().BeEquivalentTo(new List<int> { 2, 3, 3, 4, 5 }, options => options.WithStrictOrdering());
    //     }

    //     [Fact]
    //     public void insertionSort_should_finish_faster_when_find_equal_value()
    //     {
    //         // Arrange
    //         var testArray1 = new List<int> { 1, 2, 3, 4, 5, 3 };

    //         // Act
    //         var (_, sorted) = Result.CountInsertionSort(testArray1);

    //         // Assert
    //         sorted.Should().BeEquivalentTo(new List<int> { 1, 2, 3, 3, 4, 5 }, options => options.WithStrictOrdering());
    //     }

    [Fact]
    public void insertionSort_should_handle_already_sorted_unique_numbers()
    {
        // Arrange
        var testArray1 = new int[] { 1, 2, 3, 4, 5 };

        // Act
        var numberOfMoves = Result.CountFredSort(testArray1);

        // Assert
        numberOfMoves.Should().Be(0);
    }

    [Fact]
    public void insertionSort_should_handle_ordered_multiples_of_same()
    {
        // Arrange
        var testArray1 = new int[] { 1, 1, 1, 2, 2 };

        // Act
        var numberOfMoves = Result.CountFredSort(testArray1);

        // Assert
        numberOfMoves.Should().Be(0);
    }

    [Fact]
    public void insertionSort_should_handle_unordered_multiples()
    {
        // Arrange
        var testArray2 = new int[] { 2, 1, 3, 1, 2 };

        // Act
        var numberOfMoves = Result.CountFredSort(testArray2);

        // Assert
        numberOfMoves.Should().Be(4);
    }

}
