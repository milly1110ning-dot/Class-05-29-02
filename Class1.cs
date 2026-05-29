using System;
public abstract class Person
{
	public virtual string GetName()
	{
		return "Person";
	}
} 
public class Student :Person
{
	public sealed override string GetName()
	{
		return "Student";
	}
}
public class Teacher : Student
{
    public override string GetName()
    {
        return "Student";
    }
}
