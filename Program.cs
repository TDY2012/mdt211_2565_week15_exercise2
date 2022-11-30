using System;

class Program
{
    static void Main(string[] args)
    {
        BinaryTree<char> tree = new BinaryTree<char>();

        tree.Add('A');
        tree.Add('B');
        tree.Add('C');
        tree.Add('D');
        tree.Add('E');

        for(int i=0; i<tree.GetLength(); i++)
        {
            Console.WriteLine(tree.Get(i));
        }
    }
}