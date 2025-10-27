namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Lueders()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Lueders()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Lueders()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}
}

[TestClass]
public class Subtraction
{
	[TestMethod]
	public void Sub_Valid_Lueders()
	{
		Assert.AreEqual(3, Program.Subtract("7","4"));
		Assert.AreEqual(5, Program.Subtract("9","4"));
		Assert.AreEqual(12, Program.Subtract("20","8"));
	}
	[TestMethod]
	public void Sub_Invalid_Lueders()
	{
		Assert.ThrowsException<FormatException>(() => Program.Subtract("a","1"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("1","a"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("a","a"));
	}
	[TestMethod]
	public void Sub_Null_Lueders()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1",null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null,"1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null,null));
	}
}

[TestClass]
public class Multiplication
{
	[TestMethod]
	public void Multiply_Valid_Lueders()
	{
		Assert.AreEqual(3, Program.Multiply("1","3"));
		Assert.AreEqual(5, Program.Multiply("5","1"));
		Assert.AreEqual(12, Program.Multiply("4","3"));
	}
	[TestMethod]
	public void Multiply_Invalid_Lueders()
	{
		Assert.ThrowsException<FormatException>(() => Program.Multiply("a","1"));
		Assert.ThrowsException<FormatException>(() => Program.Multiply("1","a"));
		Assert.ThrowsException<FormatException>(() => Program.Multiply("a","a"));
	}
	[TestMethod]
	public void Multiply_Null_Lueders()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("1",null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null,"1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null,null));
	}
}

[TestClass]
public class Division
{
	[TestMethod]
	public void Divide_Valid_Lueders()
	{
		Assert.AreEqual(3, Program.Divide("12","4"));
		Assert.AreEqual(5, Program.Divide("10","2"));
		Assert.AreEqual(12, Program.Divide("36","3"));
	}
	[TestMethod]
	public void Divide_Invalid_Lueders()
	{
		Assert.ThrowsException<FormatException>(() => Program.Divide("a","1"));
		Assert.ThrowsException<FormatException>(() => Program.Divide("1","a"));
		Assert.ThrowsException<FormatException>(() => Program.Divide("a","a"));
	}
	[TestMethod]
	public void Divide_Null_Lueders()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null,"1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("1",null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null,null));
	}
}

[TestClass]
public class Power
{
	[TestMethod]
	public void Power_Valid_Lueders()
	{
		Assert.AreEqual(4, Program.Power("2","2"));
		Assert.AreEqual(27, Program.Power("3","3"));
		Assert.AreEqual(625, Program.Power("5","4"));
	}
	[TestMethod]
	public void Power_Invalid_Lueders()
	{
		Assert.ThrowsException<FormatException>(() => Program.Power("a","2"));
		Assert.ThrowsException<FormatException>(() => Program.Power("3","a"));
		Assert.ThrowsException<FormatException>(() => Program.Power("a","a"));
	}
	[TestMethod]
	public void Power_Null_Lueders()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null,"2"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power("3",null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null,null));
	}
}
	
													  
		
		
		
	
