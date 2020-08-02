using System;

namespace Practice
{
  public class Node
  {
    public int? Data { get; set; }
    public Node Link { get; set; }
  }

  public class LinkedList
  {
    public Node Head { get; set; }

    public LinkedList()
    {
      Head = new Node();
    }
    public void InserNodeAtFront(Node node) 
    {
      node.Link = Head.Link;
      Head.Link = node;
    }

    public void InserNodeAtLast(Node node)
    {
      var headNode = Head;
      while (headNode.Link != null)
      {
        headNode = headNode.Link;
      }
      headNode.Link = node;
    }

    public void InserNodeAtPosition(Node node, int position)
    {
      var headNode = Head;
      while (headNode.Link != null && position > 0)
      {
        headNode = headNode.Link;
        position--;
      }
      node.Link = headNode.Link;
      headNode.Link = node;
    }

    public void DisplayNodes()
    {
      var headNode = Head;
      while (headNode != null)
      {
        Console.Write(headNode.Data + " ");
        headNode = headNode.Link;
      }
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      var linkedList = new LinkedList();
      var firstNode = new Node();
      firstNode.Data = 1;
      firstNode.Link = null;
      var secondNode = new Node();
      secondNode.Data = 3;
      secondNode.Link = null;
      var thirdNode = new Node();
      thirdNode.Data = 2;
      thirdNode.Link = null;
      linkedList.InserNodeAtFront(firstNode);
      linkedList.InserNodeAtLast(secondNode);
      linkedList.InserNodeAtPosition(thirdNode, 1);
      linkedList.DisplayNodes();
      Console.ReadLine();
    }
  }
}
