using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class GradesTests
{
    [Test]
    public void Test_GetBestStudents_ReturnsBestThreeStudents()
    {
        // Arrange
        Dictionary<string, int> gradesDictionary = new()
        {
            ["Denis"] = 5,
            ["Yoko"] = 4,
            ["Ivan"] = 6,
            ["Dragan"] = 3,
            ["Petkan"] = 2,
        };
        // Act
        string result = Grades.GetBestStudents(gradesDictionary);
        string expected = $"Ivan with average grade 6.00" +
            $"{Environment.NewLine}Denis with average grade 5.00" +
            $"{Environment.NewLine}Yoko with average grade 4.00";
        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetBestStudents_EmptyGrades_ReturnsEmptyString()
    {
        // Arrange
        Dictionary<string, int> gradesDictionary = new()
        {
        };
        // Act
        string result = Grades.GetBestStudents(gradesDictionary);
        string expected = "";
        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetBestStudents_LessThanThreeStudents_ReturnsAllStudents()
    {
        // Arrange
        Dictionary<string, int> gradesDictionary = new()
        {
            ["Denis"] = 5,
            ["Yoko"] = 4,
            
        };
        // Act
        string result = Grades.GetBestStudents(gradesDictionary);
        string expected = $"Denis with average grade 5.00" +
                            $"{Environment.NewLine}Yoko with average grade 4.00";
        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetBestStudents_SameGrade_ReturnsInAlphabeticalOrder()
    {
        // Arrange
        Dictionary<string, int> gradesDictionary = new()
        {
            ["Denis"] = 6,
            ["Yoko"] = 6,
            ["Ivan"] = 6,
            ["Dragan"] = 3,
            ["Petkan"] = 2,
        };
        // Act
        string result = Grades.GetBestStudents(gradesDictionary);
        string expected = $"Denis with average grade 6.00" +
                            $"{Environment.NewLine}Ivan with average grade 6.00" +
                            $"{Environment.NewLine}Yoko with average grade 6.00";
        
        // Assert
        Assert.AreEqual(expected, result);
    }
}
