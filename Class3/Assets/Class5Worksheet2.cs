using UnityEngine;

// 2 class in 1 script
public class myLinkList
{
    public class Node
    {
        public int data;
        public Node next;

        public Node()
        {
            data = 0;
            next = null;
        }

        public Node(int _value)
        {
            data = _value;
            next = null;
        }
    }

    Node _head;

    public myLinkList()
    {
        _head = null;
    }

    public myLinkList(int _value)
    {
        _head = null;
        append(_value);
    }

    public Node getHead()
    {
        return _head;
    }

    public Node getTail()
    {
        Node pointer = _head;
        while(pointer != null)
        {
            if(pointer.next == null)
            {
                return pointer;
            }
            pointer = pointer.next;
        }
        return null;
    }

    public void append(int _value)
    {
        Node temp = new Node(_value);

        if(_head == null)
        {
            _head = temp;
        }
        else
        {
            Node last_node = getTail();
            last_node.next = temp;
        }
    }
}

public class Class5Worksheet2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Enemy keke = new Enemy();
        Debug.Log(keke.hp);

        EnemyWalking boss = new EnemyWalking();
        Debug.Log(boss.hp);

        /*myLinkList list1 = new myLinkList();

        list1.append(11);
        list1.append(22);
        list1.append(33);

        myLinkList list2 = new myLinkList();

        list2.append(555);
        list2.append(666);

        myLinkList.Node pointer = list1.getHead();
        printList(pointer);

        printList(list2.getHead());*/

        /*while(pointer != null)
        {
            Debug.Log(pointer.data);
            pointer = pointer.next;
        }*/
    }

    void printList(myLinkList.Node pointer)
    {
        while(pointer != null)
        {
            Debug.Log(pointer.data);
            pointer = pointer.next;
        }
    }
}
