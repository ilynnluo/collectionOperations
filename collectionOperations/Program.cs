namespace collectionOperations
{
    public class QCollection<T>
    {
        private Queue<T> items;
        public QCollection()
        {
            items = new Queue<T>();
        }
        public void Enqueue(T item)
        {
            items.Enqueue(item);
        }
        public T Dequeue()
        {
            if(items.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            return items.Dequeue();
        }
        public List<T> Descending()
        {
            return items.OrderByDescending(item => item).ToList();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            QCollection<int> q = new QCollection<int>();
            q.Enqueue(1);
            q.Enqueue(10);
            q.Enqueue(5);
            q.Enqueue(9);

            List<int> descendQ = q.Descending();
            foreach(int item in descendQ)
            {
                Console.WriteLine(item);
            }
        }
    }
}
