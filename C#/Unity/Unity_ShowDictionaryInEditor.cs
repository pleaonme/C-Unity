// Source of code to make Dictionary visible in Unity Editor
private enum ResourceType {
  Wood,
  iron,
  Gold,
  Other
}

[SerializeField] private Dictionary<ResourceType, int> resourceTypeAmountDictionary; // Doesn't work as expected - Dictionary is still unvisible in Editor

[Serializable]
public Class ResourceTypeAmount {
  public ResourceType resourceType;
  public int amount
}

[SerializeField] private List<ResourceTypeAmount> resourceTypeAmountList;

