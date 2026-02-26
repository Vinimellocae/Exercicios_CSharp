List<int> ints = new List<int> {1,2,3,4,5,6,7,8};

foreach(var item in ints)
{
    bool ehPar = item % 2 == 0;

    if(ehPar) ints.Remove(item);
}