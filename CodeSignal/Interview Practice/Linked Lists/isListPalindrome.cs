// Singly-linked lists are already defined with this interface:
// class ListNode<T> {
//   public T value { get; set; }
//   public ListNode<T> next { get; set; }
// }
//
bool solution(ListNode<int> l) {
    if(l == null) return true;
    
    int lenDiv2 = 0;
    ListNode<int> fastPointer = l;
    ListNode<int> middPointer = l;
    
    // Find middlepoint of list
    while(fastPointer != null && fastPointer.next != null) {
        middPointer = middPointer.next;
        fastPointer = fastPointer.next.next;
        lenDiv2++;
    }
    
    // Reverse second half of linkedlist
    ListNode<int> prevPointer = middPointer;
    middPointer = middPointer.next;
    ListNode<int> nextPointer;
    while(middPointer != null) {
        nextPointer = middPointer.next;
        middPointer.next = prevPointer;
        prevPointer = middPointer;
        middPointer = nextPointer;
    }
    
    // Check if palindrome
    for(int i = 0; i < lenDiv2; i++) {
        if(l.value != prevPointer.value) return false;
        l = l.next;
        prevPointer = prevPointer.next;
    }
    
    return true;
}
