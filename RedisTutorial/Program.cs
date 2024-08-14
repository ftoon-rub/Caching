// See https://aka.ms/new-console-template for more information
using Infrastructure;
using StackExchange.Redis;

Console.WriteLine("Hello, World!");

dMockDataService mockData = new();
var users = mockData.GetUsers();

// Create a connection to the Redis server
ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost");

// Access the Redis database
IDatabase db = redis.GetDatabase();

#region String
// Set a string value in Redis
db.StringSet("mystring", "Hello, Redis!");
// Retrieve the string value from Redis
string myString = db.StringGet("mystring");
Console.WriteLine($"String value: {myString}");
#endregion

#region List
// Add items to a Redis list
db.ListRightPush("mylist", "item1");
db.ListRightPush("mylist", "item2");
db.ListRightPush("mylist", "item3");
// Get the length of the list
var listLength = db.ListLength("mylist");
Console.WriteLine("List values:");
// Retrieve and print each item in the list
for (int i = 0; i < listLength; i++)
{
    Console.WriteLine(db.ListGetByIndex("mylist", i));
}
#endregion

#region Set
// Add members to a Redis set
db.SetAdd("myset", "value1");
db.SetAdd("myset", "value2");
db.SetAdd("myset", "value3");
// Retrieve and print all members of the set
var setMembers = db.SetMembers("myset");
Console.WriteLine("Set members:");
foreach (var member in setMembers)
{
    Console.WriteLine(member);
}
#endregion

#region Hash
// Set fields and values in a Redis hash
db.HashSet("myhash", "field1", "value1");
db.HashSet("myhash", "field2", "value2");
// Retrieve all fields and values from the hash
var hashEntries = db.HashGetAll("myhash");
Console.WriteLine("Hash entries:");
foreach (var entry in hashEntries)
{
    Console.WriteLine($"{entry.Name}: {entry.Value}");
}
#endregion

#region Sorted Set
// Add members with scores to a Redis sorted set
db.SortedSetAdd("mysortedset", "member1", 1);
db.SortedSetAdd("mysortedset", "member2", 2);
db.SortedSetAdd("mysortedset", "member3", 3);
// Retrieve and print members and their scores from the sorted set
var sortedSetMembers = db.SortedSetRangeByRankWithScores("mysortedset");
Console.WriteLine("Sorted Set members:");
foreach (var member in sortedSetMembers)
{
    Console.WriteLine($"{member.Element}: {member.Score}");
}
#endregion

#region Bitmap
// Set bits in a Redis bitmap
db.StringSetBit("mybitmap", 0, true); // Set bit 0 to 1
db.StringSetBit("mybitmap", 1, true); // Set bit 1 to 1
                                      // Retrieve and print the value of specific bits
bool bit0 = db.StringGetBit("mybitmap", 0); // Get bit 0
bool bit1 = db.StringGetBit("mybitmap", 1); // Get bit 1
Console.WriteLine($"Bitmap bit 0: {bit0}");
Console.WriteLine($"Bitmap bit 1: {bit1}");
#endregion

#region HyperLogLog
// Add items to a HyperLogLog for approximating cardinality
db.HyperLogLogAdd("myhll", "item1");
db.HyperLogLogAdd("myhll", "item2");
db.HyperLogLogAdd("myhll", "item3");
// Retrieve and print the approximate count of unique items
long hllCount = db.HyperLogLogLength("myhll");
Console.WriteLine($"HyperLogLog count: {hllCount}");
#endregion

#region Stream
//var streamKey = "mystream";
//// Add entries to a Redis stream
//db.StreamAdd(streamKey, "field1", "value1");
//db.StreamAdd(streamKey, "field2", "value2");
//// Read and print all entries from the stream starting from ID 0
//var streamEntries = db.StreamRead(streamKey, "0");
//Console.WriteLine("Stream entries:");
//foreach (var entry in streamEntries)
//{
//    Console.WriteLine($"ID: {entry.Id}");
//    foreach (var pair in entry.Values)
//    {
//        Console.WriteLine($"{pair.Name}: {pair.Value}");
//    }
//}
#endregion

// Close the connection
redis.Close();

Console.ReadLine();
