namespace indexerTask
{
    internal class ListInt
    {
        private int[] arr;
        private int size;
        public ListInt()
        {
            arr = new int[10];
            size = 0;

        }
        public int this[int index]
        {
            get
            {
                
                return arr[index];
               
            }
            set 
            {
                if (index < 0 || index >= size) 
                { 
                    return; 
                }
                arr[index] = value;
            }   

        }
        public void Add(int num)
        { 
        }
        public void Add(params int[] nums)
        {
            foreach (int num in nums)
            { 
                Add(num);
            }      
        }
        public bool Contains(int num)
        {
            for (int i = 0; i < size; i++)
            { 
            if(arr[i] == num)
                    return true;
            }
            return false;
        }
        public int Pop()
        {
            if (size == 0)
                return 0;
            size--;
            return arr[size];

        }
        public float Sum()
        {
            int sum = 0;
            for (int i = 0; i < size; i++)
            { 
              sum += arr[i];
            
            }
            return sum;
        }
        public override string ToString()
        {
            string result = "";
            for(int i = 0;i < size; i++)
            { 
                result += arr[i]+"";
            
            }
            return result;
        }
        public int IndexOf(int num)
        {
            for (int i = 0; i < size; i++)
            { 
            
            if (arr[i] == num)
                    return i;
            }
            return -1;
        
        }
        public int LastIndexOf(int num)
        {
            for (int i = size - 1;i>= 0; i--)
                {
                if (arr[i] == num)
                        return i;
            }
            return -1;      
        }
        public void Insert(int num, int index)
        { 
        if(index < 0 || index >= size)  
                return;
            
        }
        public float Average()
        {
            if (size == 0)
            {
                return 0;
            }
            return (float)Sum()/ size;
        
        
        }
        
    }






}

