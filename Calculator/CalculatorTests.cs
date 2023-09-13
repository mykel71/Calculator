using System;
using Domain;
using FluentAssertions;

namespace CalculatorTest;

public class CalculatorTests
{
    [Fact]
    public void Sum_of_2_and_2_Should_be_4()
    => new Calculator()
        .Sum(2, 2)
        .Should().Be(4);

    [Fact]
    public void Diff_of_10_and_5_Should_be_5()
    => new Calculator()
        .Diff(10, 5)
        .Should().Be(5);

    [Fact]
    public void Div_of_10_by_2_Should_be_5()
        => new Calculator()
            .Div(10, 2)
            .Should().Be(5);

    [Fact]
    public void Multiple_of_2_and_3_Should_be_6()
        => new Calculator()
            .Multiply(2, 3)
            .Should().Be(6);

}