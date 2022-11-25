At first, I wasn't quite sure what the task requires of me. The tree-like structure made me think that depth represents the distance between the root of 
the structure and its most distant leaf. Then I realised that depth increases by appending new branches to the structure. So my perception of the problem changed.  

Method *GetDepth* finds how many branch appends are needed to create a given structure. The structure can be created by various operations,
one of which - *AppendBranch* - was defined in the task's description and required for its completion. The value depth can be then interpreted as the dimension of 
subbranches nested within subbranches.  

Each branch is constructed from empty subbranches, indicating the space between places where the branch splits in two. First node of a branch is shared with
its parent (if it has one), creating kind of a joint, where multiple branches can be appended at once. 

While creating the similar structure, I was inspired by the builder design pattern. With it's current implementation I was able to chain subbranches
one onto each other, significantly reducing the need of looking for a particular branch.
