namespace Task2__Branches;

public class Branch
{
    private List<Branch> branches;
    
    public Branch(int branchLength)
    {
        branches = new List<Branch>();
        
        // Appends empty branches to the list for easier indexing
        for (int i = 0; i < branchLength; i++)
        {
            branches.Add(new Branch(0));
        }
    }

    // Adds a new subbranch to the list at given position index
    public Branch AppendBranch(Branch newBranch, int index)
    {
        branches[index] = newBranch;
        return newBranch;
    }

    // Returns subbranch stored in list at given position index
    public Branch GetSubbranch(int index)
    {
        return branches[index];
    }
    
    public List<Branch> GetBranches()
    {
        return branches;
    }

    // Returns the minimal amount of subbranches needed to create the given branch
    public static int GetDepth(Branch branch, bool isRoot = false)
    {
        // The root branch is also considered a subbranch
        int depth = Convert.ToInt32(isRoot);
        
        // Every time a branch splits into two,
        // add depth and calculate depth of the subbranch
        foreach (Branch subbranch in branch.GetBranches())
        {
            if (subbranch.GetBranches().Count < 2) continue;
            depth += 1 + GetDepth(subbranch);
        }

        return depth;
    }
    
    // Assigns string representation to the Branch instance for easier debugging
    // Branch[a0, a1, a2, ..., ]
    //        ^ where an is length of subbranch at branches[n]
    public override string ToString()
    {
        string str = "Branch[";
        
        foreach (Branch subbranch in branches)
        {
            string subbranchLength = subbranch.GetBranches().Count.ToString();
            str += $"{subbranchLength}, ";
        }

        return str + "]";
    }
}
