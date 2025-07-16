// SortedList - A key–value pair collection, like Dictionary, but always sorted by key

SortedList<int, string> players = new SortedList<int, string>();
players.Add(3, "Alice");
players.Add(1, "Bob");
players.Add(2, "Charlie");

// Output is sorted by key: 1 → Bob, 2 → Charlie, 3 → Alice


// SortedSet - The same as the normal HashSet but the output is always sorted
SortedSet<int> scores = new SortedSet<int>();
scores.Add(30);
scores.Add(10);
scores.Add(20);
scores.Add(10);  // ignored

// Output: 10, 20, 30
