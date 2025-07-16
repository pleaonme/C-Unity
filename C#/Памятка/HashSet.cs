// HashSet - basically a List, where all items are unique
// HashSets are fast
// HashSets are not sorted, use SortedSet<> to have both uniqueness and sortation

private HashSet<string> userID = new HashSet<string>();

userID.Add("245"); // Add elements to HashSet
userID.Add("321");
userID.Add("111");
userID.Add("111"); // Will be ignored

Console.WriteLine(userID.Count); // (3)

// Add(item)	Adds item if not present
// Remove(item)	Removes item if found
// Contains(item)	Checks if item is in the set
// Clear()	Removes all items
// SetEquals(otherSet)	Checks if two sets are equal
// UnionWith(set)	Adds elements from another set
// IntersectWith(set)	Keeps only elements that exist in both
// ExceptWith(set)	Removes elements that exist in the other set
