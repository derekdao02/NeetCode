public class DynamicArray {
    private int length;
    private int capacity;
    private int[] array;

    public DynamicArray(int capacity) {
        this.capacity = capacity;
        this.length = 0;
        this.array = new int[this.capacity];
    }

    public int Get(int i) {
        return array[i];
    }

    public void Set(int i, int n) {
        array[i] = n;
    }

    public void PushBack(int n) {
        if (length == capacity)
        {
           Resize();
        }

        array[length] = n;
        length++;
    }

    public int PopBack() {
        if (length > 0)
        {
           length--;
        }

        return array[length];
    }

    private void Resize() {
        capacity *= 2;
        int[] newArray = new int[capacity];

        for (int i = 0; i < length; i++)
        {
            newArray[i] = array[i];
        }

        array = newArray;
    }

    public int GetSize() {
        return length;
    }

    public int GetCapacity() {
        return capacity;
    }
}

