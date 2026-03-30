# NeetCode – Data structures and algorithms practice

This repository is for **learning** and **reviewing** **data structures** and **algorithms**, using the NeetCode roadmap and problem set as a guide ([NeetCode](https://neetcode.io/)).

Each folder is one problem. Solutions are written in **C#** on **.NET 8** as small console apps (`dotnet run`) so they are easy to run and edit locally.

## Goals

- Strengthen core **data structures** (dynamic arrays, linked lists, binary trees, and more).
- Practice **algorithmic thinking** (two pointers, hash maps, stacks, tree traversal, and more).
- Get comfortable with **NeetCode / LeetCode**-style problems in small steps, and grow along the roadmap.

## Requirements

- [.NET 8 SDK](https://dotnet.microsoft.com/download) (or a compatible newer version).

## Project layout

Each problem is its own project:

| Folder | Topic hint |
|--------|------------|
| `DesignDynamicArray` | Dynamic array |
| `MergeTwoSortedLists` | Linked list |
| `InvertBinaryTree` | Binary tree |
| `TwoSum` | Hash map / two pointers |
| `ValidAnagram` | Strings, character counts |
| `ValidPalindrome` | Strings, two pointers |
| `ValidParentheses` | Stack |
| `TimeToBuyAndSellStock` | Arrays, extrema |

Typical files per problem: `Program.cs` (entry point), `Solution.cs` (logic), plus helper types when needed (`ListNode.cs`, `TreeNode.cs`, etc.).

## Run a problem

From a terminal, `cd` into the problem folder and run:

```bash
cd TwoSum
dotnet run
```

Replace `TwoSum` with any other folder name (e.g. `ValidParentheses`, `InvertBinaryTree`).

## References

- [NeetCode](https://neetcode.io/) – curated roadmap and walkthrough videos.
- [LeetCode](https://leetcode.com/) – official problem statements and test cases for cross-checking.

---

*Personal learning repo: add new problems by creating another .NET console project in the same style as the existing folders.*
