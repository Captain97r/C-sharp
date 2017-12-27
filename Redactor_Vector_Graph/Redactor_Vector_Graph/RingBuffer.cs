﻿namespace Redactor_Vector_Graph {
   public class RingBuffer<T> {
        public T Value { get { return buffer[current];} }
        public int saveState = 0;
        private int head;
        private int bottom = 0;
        private int current;
        private int maxSize;
        private T[] buffer;
        public  RingBuffer(int max){
            maxSize = max;
            head = max - 1;
            current = head;
            buffer = new T[maxSize];
            }
        public void Push(T data) {
            if (current != head)
                head = current;
            head = (head + 1) % buffer.Length;
            current = head;
            if (head == bottom)
                bottom = (bottom + 1) % buffer.Length;
            buffer[head] = data;
        }
        public bool Down() {
            current = (current + buffer.Length - 1) % buffer.Length;
            if(current == bottom) {
              current = (current + 1) % buffer.Length;
              return false;
            }
            return true;
        }
        public bool Up() {
            if (current != head) {
                current = (current + 1) % buffer.Length;
                return true;
            }
            return false;
        }

    }
}
