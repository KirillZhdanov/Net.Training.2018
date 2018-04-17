using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    /// <summary>
    /// Queue
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Queue<T>:IEnumerable<T>
    {
        #region Fields

        /// <summary>
        /// Empty array
        /// </summary>
        private static  T[] emptyArray = new T[0];

        /// <summary>
        /// Array
        /// </summary>
        private T[] array;

        /// <summary>
        /// Head 
        /// </summary>
        private int head;

        /// <summary>
        /// Tail 
        /// </summary>
        private int tail;

        /// <summary>
        /// Resizing array
        /// </summary>
        private int growArray;

        

        #endregion

        

        /// <summary>
        /// Create empty queue
        /// </summary>
        public Queue()
        {
            array = emptyArray;
            GrowArray = 2;
        }

        /// <summary>
        /// Generating queue 
        /// </summary>
        /// <param name="collection"></param>
        public Queue(IEnumerable<T> collection)
        {
            if (collection == null)
                throw new NullReferenceException(nameof(collection));

            array = new T[4];
            Count = 0;
            GrowArray = 2;
          

            foreach (T obj in collection)
                Enqueue(obj);
        }

   
        public Queue(int capacity = 10, int arrayResize = 2)
        {
            if (capacity < 0)
                throw new ArgumentOutOfRangeException($"Requare {nameof(capacity)} more than zero");

            array = new T[capacity];
            GrowArray = arrayResize;
            StartValues();
        }

        

        #region Property

        /// <summary>
        /// Counter elements of queue
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Resizing array
        /// </summary>
        public int GrowArray
        {
            get { return growArray; }
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new ArgumentOutOfRangeException($"Requare {nameof(value)} between 1 to 10");
                }

                growArray = value;
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Enqueue adds an element to the end of the Queue<T>
        /// </summary>
        /// <param name="item"></param>
        public void Enqueue(T item)
        {
            if (Count == array.Length)
                SetCapacity(Count * GrowArray + 4);

            
            PutElementToTail(item);
        }

        /// <summary>
        /// Dequeue removes the oldest element from the start of the Queue<T>
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            if (Count == 0)
                throw new InvalidOperationException($"{nameof(Count)} should be more than zero");

          
            return TakeElementFromHead();
        }

        /// <summary>
        /// Peek returns the oldest element that is at the start of the Queue<T> but does not remove it from the Queue<T>
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            if (Count == 0)
                throw new InvalidOperationException();

            return array[head];
        }

        /// <summary>
        /// Clear all in queue
        /// </summary>
        public void Clear()
        {
            if (head < tail)
            {
                Array.Clear(array, head, Count);
            }
            else
            {
                Array.Clear(array, head, array.Length - head);
                Array.Clear(array, 0, tail);
            }

          
            StartValues();
        }

        
        public IEnumerator<T> GetEnumerator() => new Enumerator(this);
               
        IEnumerator IEnumerable.GetEnumerator() =>
            GetEnumerator();

        #endregion

        #region Private Methods

        /// <summary>
        /// Initialize values
        /// </summary>
        private void StartValues()
        {
            head = 0;
            tail = 0;
            Count = 0;
        }

        /// <summary>
        /// Extend array to bigger by capacity parameter
        /// </summary>
        /// <param name="capacity">New size for array</param>
        private void SetCapacity(int capacity)
        {
            var newArray = new T[capacity];

            if (Count > 0)
            {
                if (head < tail)
                {
                    Array.Copy(array, head, newArray, 0, Count);
                }
                else
                {
                    Array.Copy(array, head, newArray, 0, array.Length - head);
                    Array.Copy(array, 0, newArray, array.Length - head, tail);
                }
            }
                        
            head = 0;
            if (Count == capacity)
                tail = 0;
            else
                tail = Count;
            array = newArray;
        }

        /// <summary>
        /// Put <paramref name="item"/> element to queue
        /// </summary>
        /// <param name="item">Some new element</param>
        private void PutElementToTail(T item)
        {
            array[tail] = item;
            tail = (tail + 1) % array.Length;
            Count++;
        }

        /// <summary>
        /// Get and delete head element from queue
        /// </summary>
        /// <returns>Current head element</returns>
        private T TakeElementFromHead()
        {
            var result = array[head];
            array[head] = default(T);
            head = (head + 1) % array.Length;
            Count--;

            return result;
        }

        private T GetElement(int i)
        {
            return array[(head + i) % array.Length];
        }

        #endregion

        

        /// <summary>
        ///Iterator for Queue
        /// </summary>
        public struct Enumerator : IEnumerator<T>
        {
            #region Fields

            private Queue<T> queue;
            private int currentIndex;
            private T currentElement;

            #endregion

           

            /// <summary>
            /// Clone queue to Enumerator queue
            /// </summary>
            /// <param name="queue"></param>
            public Enumerator(Queue<T> queue)
            {
                this.queue = queue;
                currentIndex = -1;
                currentElement = default(T);
            }

           

            #region Property

            /// <summary>
            /// Get current element of Queue in foreach
            /// </summary>
            public T Current
            {
                get
                {
                    if (currentIndex < 0)
                        throw new InvalidOperationException();

                    return currentElement;
                }
            }

            #endregion

            #region Public Methods

            /// <summary>
            /// IEnumerator implementation of dispose method
            /// </summary>
            public void Dispose()
            {
                currentIndex = -2;
                currentElement = default(T);
            }

            /// <summary>
            /// IEnumerator implementation of MoveNext method for foreach
            /// </summary>
            /// <returns></returns>
            public bool MoveNext()
            {
                if (currentIndex == -2)
                    return false;

                currentIndex++;

                if (currentIndex == queue.Count)
                {
                    Dispose();
                    return false;
                }

                currentElement = queue.GetElement(currentIndex);
                return true;
            }

            #endregion

            

            object IEnumerator.Current { get { return Current; } }

            void IEnumerator.Reset()
            {
                currentIndex = -1;
                currentElement = default(T);
            }

          
        }

        

    }
}
