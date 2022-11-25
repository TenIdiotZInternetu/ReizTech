// See https://aka.ms/new-console-template for more information

using Task2__Branches;

// Creating a similar structure
Branch structure = new Branch(3);

structure.AppendBranch(new Branch(3), 0)
    .AppendBranch(new Branch(4), 1)
    .AppendBranch(new Branch(2), 1);
    
structure.GetSubbranch(0)
    .GetSubbranch(1)
    .AppendBranch(new Branch(3), 0);

// Calculating its depth
Console.WriteLine(Branch.GetDepth(structure, true));

