using Xunit;

public class PhoneNumberTests
{
    /*[Fact]
    public void Parse_ValidNumber_FormatsCorrectly()
    {
        // Arrange
        var phone = new PhoneNumber();

        // Act
        phone.Parse("5145551234");

        // Assert
        Assert.Equal("(514)555-1234", phone.ToString());
    }
    
    
    [Fact]
    public void Parse_ValidNumber_FormatsCorrectly_SecondNumber()
    {
        // Arrange
        var phone = new PhoneNumber();

        // Act
        phone.Parse("2120007890");

        // Assert
        Assert.Equal("(212)000-7890", phone.ToString());
    }*/

    [Theory]
    [InlineData("5145551234","(514)555-1234")]
    [InlineData("2120007890" ,"(212)000-7890")]
    public void Parse_ValidNumber_FormatsCorrectly(string input, string expected)
    {
        var phone = new PhoneNumber();

        phone.Parse(input);

         Assert.Equal(expected, phone.ToString());
    }


    [Fact]
    public void Parse_InvalidLength_ThrowsException()
    {
        // Arrange
        var phone = new PhoneNumber();

        // Act & Assert
        Assert.Throws<Exception>(() => phone.Parse("12345"));
    }

    [Fact]
    public void Parse_AnotherValidNumber_WorksCorrectly()
    {
        var phone = new PhoneNumber();

        phone.Parse("1234567890"); //Act - parse input

        var result = phone.ToString(); //Get formatted result

        Assert.Equal("(123)456-7890", result);//Assert - verify
    }
}