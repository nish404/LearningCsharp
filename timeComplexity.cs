using System.Collections.Generic;
using System.Diagnostics;

List<int> orderedList = new List<int>() { 1, 4, 5, 6, 10, 11, 15 };
List<int> orderedList2 = new List<int>() { 1, 4, 5, 6, 6, 10, 11, 15 };

List<int> list = new List<int>() { 5, 3, 10, 2, 8, 7, 8, 1, 15 };



bool duplicates = ContainsDuplicatesOrderedList(orderedList2);

if (duplicates == true)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}

/// <summary>
/// Returns true if the orderedlist has any duplicate items, otherwise false
/// </summary>
bool ContainsDuplicatesOrderedList(List<int> orderedList)
{
    // Time complexity is O(n)
    for(int i = 0; i < orderedList.Count - 1; i++)
    {
        if(orderedList[i] == orderedList[i+1])
        {
            return true;
        }
    }
    return false;
}

/// <summary>
/// Returns true if the list has any duplicate items, otherwise false
/// </summary>
bool ContainsDuplicates(List<int> list)
{
    // Time complexity is O(n*n) = O(n^2): we itereate n times through n items 
    for(int i = 0; i < list.Count; i++) // n elemenst
    {
        for(int j = 0; j < list.Count; j++) // n elements
        {
            if(i != j && list[i] == list[j])
            {
                return true;
            }
        }
    }
    return false;
}

/// <summary>
/// Returns true if the list has any duplicate items, otherwise false
/// </summary>
bool ContainsDuplicatesImprovement1(List<int> list)
{
    // Time complexity is O(n*lg(n))
    for (int i = 0; i < list.Count; i++) // n elemenst
    {
        for (int j = i + 1; j < list.Count; j++) // lg(n)
        {
            if (list[i] == list[j])
            {
                return true;
            }
        }
    }
    return false;
}

/// <summary>
/// Returns true if the list has any duplicate items, otherwise false
/// </summary>
bool ContainsDuplicatesImprovement2(List<int> list)
{
    // sort the list
    list.Sort(); // O(n * lg(n))

    return ContainsDuplicatesOrderedList(list); // O(n)

}

/// <summary>
/// Returns true if the ordered list contains the given value, otherwise false
/// </summary>
bool Contains(List<int> orderedList, int value)
{
    // Time complexity is O(n) -> because we have a loop that loop through every item in the list
    for(int i = 0; i < orderedList.Count; i++)
    {
        if (orderedList[i] == value)
        {
            return true;
        }
    }
    return false;
}

/// <summary>
/// Returns true if the ordered list contains the given value, otherwise false
/// </summary>
bool ContainsImproved(List<int> orderedList, int value)
{
    // Time complexity is O(n) -> worst case we have to go through every item in the list
    for (int i = 0; i < orderedList.Count; i++)
    {
        if (orderedList[i] == value)
        {
            return true;
        }
        if(value < orderedList[i])
        {
            return false;
        }
    }
    return false;
}
