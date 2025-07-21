// Generic classes are classes that can receive any type and do some logic with that types

public class Box<T> where T : TestClass // We can limit generic types that our class can Receive by "GenericClassName<T> where T : LimitingClassName"
                                        // Adding interfaces to limiting rules will include every type that realize that interface
                                        // Same with inherited classes - limiting class also includes classes that inherit that limiting class
                                        // It also can be just 'class' or 'struct' so Generic Class can only receive classes or structures
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

// That is example of Generic Class for Unity logic (Object Spawner)

public class Spawner<T> where T : MonoBehaviour
{
    public T prefab; // Prefab can be of any type

    public T Spawn(Vector3 position)
    {
        return GameObject.Instantiate(prefab, position, Quaternion.identity);
    }
}

  
