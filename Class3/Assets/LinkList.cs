using UnityEngine;

public class LinkList : MonoBehaviour
{
    public class Node
    {
        public int data;
        public Node next;
        public Node prev;

        public Node()
        {
            data = 0;
            next = null;
            prev = null;
        }
    }

    public Node head;

    // Start is called before the first frame update
    void Start()
    {
        Node n1 = new Node();
        Node n2 = new Node();
        Node n3 = new Node();

        head = n1;

        n1.data = 11;
        n2.data = 22;
        n3.data = 33;

        n1.next = n2;
        n2.next = n3;

        n3.prev = n2;
        n2.prev = n1;

        Node pointer;
        pointer = head;
        while(pointer != null)
        {
            Debug.Log(pointer.data);
            pointer = pointer.next;
        }

        // Debug.Log(((n1.next).prev).data);
    }
}
