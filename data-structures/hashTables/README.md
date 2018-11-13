# Hash Tables

## Challenge

Implement a Hashtable with the following methods

1. Add(key, value) - void return
1. Find(string key) - returns the value from key/value pair
1. Contains(string key) - returns bool
1. GetHash(key) - returns array index

## Strategry

I created three classes to make this data structure work. I have a special HashNode class that have Key, Value, and Next properties. They have Next properties because they will be inserted into HashLists which are basically just linked lists. The HashLists make up the HashTables where each index in the table is a HashList to handle collisions.

## How to Run

You can interact with this and run a short demo by running `dotnet run` from the hashTables directory. This also features a full test suite which can be run with the `dotnet test` command from the TestHashtables directory.