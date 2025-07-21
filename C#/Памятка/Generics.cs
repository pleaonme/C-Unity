// Generic classes are classes that can receive any type and do some logic with that types

public class Box<T> where T : 
{
    public T Item;

    public void Store(T item)
    {
        Item = item;
    }

    public T Open()
    {
        return Item;
    }
}

public class TestClass {
  
}
  
