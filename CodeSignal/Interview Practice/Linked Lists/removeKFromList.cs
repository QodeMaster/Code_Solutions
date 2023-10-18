// Singly-linked lists are already defined with this interface:
// class ListNode<T> {
//   public T value { get; set; }
//   public ListNode<T> next { get; set; }
// }
//
ListNode<int> solution(ListNode<int> l, int k) {
    if(l == null) return l;
    ListNode<int> prev    = null;
    ListNode<int> current = l;
    ListNode<int> start   = current;
    
    while(current != null) {
        if(current.value == k) { 
            if(prev == null) {
                prev = current;
                current = current.next;
                start = current;
                prev = null;
                continue;  
            } if(current.next == null) {
                prev.next = null;
                current = null;
                break;
            } else {
                current = current.next;
                prev.next = current;
                continue;
            }
        }
        prev = current;
        current = current.next;
    }
    
    return start;
}
